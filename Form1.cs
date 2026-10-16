using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FakeBTCMiner
{
    public partial class Form1 : Form
    {
        private double balance = 0.0;
        private double stakedBalance = 0.0;
        private double hashRate = 0.0;
        private double displayHashRate = 0.0;
        private double displayBalance = 0.0;
        private double bestHashRate = 0.0;
        private double totalHashSum = 0.0;
        private int totalHashSamples = 0;
        private long totalShares = 0;
        private long acceptedShares = 0;
        private long rejectedShares = 0;
        private bool isMining = false;
        private bool isPaused = false;
        private DateTime sessionStart;
        private TimeSpan totalUptime = TimeSpan.Zero;
        private readonly Random rnd = new Random();
        private readonly List<double> hashHistory = new List<double>();
        private readonly List<double> diffHistory = new List<double>();
        private readonly List<string> txHistory = new List<string>();
        private readonly List<string> allLogs = new List<string>();
        private readonly HashSet<string> unlockedAchievements = new HashSet<string>();
        private int pulsePhase = 0;
        private float glowPhase = 0f;
        private int activeTab = 0;
        private float fadeAlpha = 0f;
        private bool isDarkTheme = true;

        private readonly List<Particle> particles = new List<Particle>();

        private double btcPriceUsd = 67432.18;
        private double usdToRub = 92.45;
        private double stakeApy = 5.5;
        private double referralBonus = 0.000001;

        private int intensity = 2;
        private int threads = 4;
        private bool autoStop = false;
        private double autoStopTarget = 0.00001;
        private bool autoRestart = true;
        private string miningProfile = "Normal";

        // GPU state
        private float gpuTemperature = 45f;
        private float gpuFanRpm = 1200f;
        private float gpuPower = 80f;
        private float targetFanRpm = 1200f;
        private readonly List<float> tempHistory = new List<float>();
        private readonly List<float> fanHistory = new List<float>();
        private readonly List<float> powerHistory = new List<float>();

        // Menu
        private bool menuOpen = false;
        private int menuAnimX = 0;
        private readonly List<MenuItemData> menuItems = new List<MenuItemData>();
        private Label lblMenuTitle;
        private Label lblMenuClose;
        private Label lblMenuTooltip;
        private int menuContentY = 0;
        private float menuFadeAlpha = 0f;
        private readonly Dictionary<string, bool> menuToggles = new Dictionary<string, bool>
        {
            { "overclock", true },
            { "cooling_aggressive", false },
            { "vpn", false },
            { "alerts", true },
            { "auto_withdraw", false },
            { "vip", false },
        };

        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            KeyPreview = true;
            KeyDown += Form1_KeyDown;

            txtWallet.Text = GenerateFakeWallet();
            InitParticles();
            InitMenu();
            LayoutMenu();

            Log("BTC Miner Pro запущен", Color.White);
            Log("F11 — fullscreen | F1 — tools", Color.FromArgb(160, 160, 160));

            RefreshTabs();
            RefreshSettings();
            RefreshAchievements();
            RefreshStats();

            timerMine.Start();
            timerAnim.Start();
            timerStake.Start();
            timerBg.Start();
        }

        // ============ ЧАСТИЦЫ ============
        private void LayoutMenu()
        {
            if (panelMenu == null) return;
            // Растянуть меню на всю высоту формы, оставить 320px ширины
            panelMenu.Height = this.ClientSize.Height;
            panelMenu.Top = 0;
            panelMenu.Width = 320;

            // Затемнение — на всю форму
            if (panelMenuShade != null)
            {
                panelMenuShade.Left = 0;
                panelMenuShade.Top = 0;
                panelMenuShade.Width = this.ClientSize.Width;
                panelMenuShade.Height = this.ClientSize.Height;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutMenu();
        }
        private void InitParticles()
        {
            particles.Clear();
            for (int i = 0; i < 60; i++)
            {
                particles.Add(new Particle
                {
                    X = rnd.Next(0, 1920),
                    Y = rnd.Next(0, 1080),
                    VX = (float)(rnd.NextDouble() * 0.6 - 0.3),
                    VY = (float)(rnd.NextDouble() * 0.6 - 0.3),
                    Size = (float)(rnd.NextDouble() * 2 + 0.5),
                    Alpha = rnd.Next(20, 90)
                });
            }
        }

        private void TimerBg_Tick(object sender, EventArgs e)
        {
            foreach (var p in particles)
            {
                p.X += p.VX;
                p.Y += p.VY;
                if (p.X < 0) p.X = Width;
                if (p.X > Width) p.X = 0;
                if (p.Y < 0) p.Y = Height;
                if (p.Y > Height) p.Y = 0;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color bg = isDarkTheme ? Color.FromArgb(10, 10, 12) : Color.FromArgb(20, 20, 24);
            g.Clear(bg);

            foreach (var p in particles)
            {
                using (var br = new SolidBrush(Color.FromArgb(p.Alpha, 180, 180, 180)))
                    g.FillEllipse(br, p.X, p.Y, p.Size, p.Size);
            }

            using (var br = new LinearGradientBrush(
                new Point(0, 0), new Point(0, 220),
                Color.FromArgb(35, 255, 255, 255),
                Color.FromArgb(0, 255, 255, 255)))
            {
                g.FillRectangle(br, 0, 0, Width, 220);
            }

            using (var br = new LinearGradientBrush(
                new Point(0, Height - 100), new Point(0, Height),
                Color.FromArgb(0, 255, 255, 255),
                Color.FromArgb(30, 255, 255, 255)))
            {
                g.FillRectangle(br, 0, Height - 100, Width, 100);
            }
        }

        // ============ АНИМАЦИИ ============
        private void TimerAnim_Tick(object sender, EventArgs e)
        {
            double dh = (hashRate - displayHashRate) * 0.12;
            displayHashRate += dh;
            if (Math.Abs(dh) > 0.01)
                lblHashRate.Text = $"{displayHashRate:F2} MH/s";

            double db = (balance - displayBalance);
            displayBalance += db * 0.10;
            if (Math.Abs(db) > 0.0000000001)
                lblBalance.Text = displayBalance.ToString("F8");

            gpuFanRpm += (targetFanRpm - gpuFanRpm) * 0.06f;

            pulsePhase = (pulsePhase + 4) % 360;
            glowPhase += 0.05f;
            if (glowPhase > (float)(Math.PI * 2)) glowPhase = 0f;

            if (fadeAlpha < 1f) fadeAlpha += 0.08f;

            // Menu animation
            int target = menuOpen ? 320 : 0;
            if (Math.Abs(menuAnimX - target) > 1)
            {
                menuAnimX += (target - menuAnimX) / 4;
                if (panelMenu != null) panelMenu.Left = -320 + menuAnimX;
                if (panelMenuShade != null)
                {
                    panelMenuShade.Visible = menuAnimX > 10;
                    panelMenuShade.BackColor = Color.FromArgb(Math.Min(180, menuAnimX * 180 / 320), 0, 0, 0);
                }
            }
            if (menuOpen && menuFadeAlpha < 1f) menuFadeAlpha += 0.06f;
            if (!menuOpen && menuFadeAlpha > 0f) menuFadeAlpha -= 0.06f;
            if (panelMenu != null) panelMenu.Invalidate();

            panelStatusDot.Invalidate();
            panelChart.Invalidate();
            panelSideStats.Invalidate();
            panelGpuMon.Invalidate();
            RefreshStats();
            UpdateConverter();
            UpdateGpuLabels();
        }

        // ============ МАЙНИНГ ============
        private void TimerMine_Tick(object sender, EventArgs e)
        {
            if (!isMining || isPaused)
            {
                if (gpuTemperature > 40) gpuTemperature -= 1f;
                targetFanRpm = 1000f;
                return;
            }

            double profileMult = miningProfile == "Eco" ? 0.6 :
                                 miningProfile == "Turbo" ? 1.6 : 1.0;

            double baseRate = 45 + rnd.NextDouble() * 40;
            hashRate = baseRate * intensity / 2.0 * (threads / 4.0) * profileMult;
            if (hashRate > bestHashRate) bestHashRate = hashRate;
            totalHashSum += hashRate;
            totalHashSamples++;

            hashHistory.Add(hashRate);
            if (hashHistory.Count > 120) hashHistory.RemoveAt(0);

            double diff = 1000 + rnd.NextDouble() * 200;
            diffHistory.Add(diff);
            if (diffHistory.Count > 120) diffHistory.RemoveAt(0);

            float targetTemp = 45 + (float)(hashRate / 100 * 45);
            gpuTemperature += (targetTemp - gpuTemperature) * 0.05f + (float)rnd.NextDouble() * 0.3f - 0.15f;
            gpuTemperature = Math.Max(35, Math.Min(95, gpuTemperature));

            targetFanRpm = 1000 + (gpuTemperature - 40) * 80;
            targetFanRpm = Math.Max(800, Math.Min(5500, targetFanRpm));

            float targetPower = (float)(hashRate * 2.8) + 50;
            gpuPower += (targetPower - gpuPower) * 0.08f;

            tempHistory.Add(gpuTemperature);
            if (tempHistory.Count > 120) tempHistory.RemoveAt(0);
            fanHistory.Add(gpuFanRpm);
            if (fanHistory.Count > 120) fanHistory.RemoveAt(0);
            powerHistory.Add(gpuPower);
            if (powerHistory.Count > 120) powerHistory.RemoveAt(0);

            double earned = (hashRate / 1000.0) * (rnd.NextDouble() * 0.00000015 + 0.00000005);
            balance += earned;

            totalShares++;
            if (rnd.Next(0, 100) < 96) acceptedShares++;
            else rejectedShares++;

            if (autoStop && balance >= autoStopTarget)
            {
                Log($"⚑ Автостоп: достигнуто {autoStopTarget:F8} BTC", Color.White);
                StopMining();
                return;
            }

            if (rnd.Next(0, 10) < 3)
            {
                string[] msgs =
                {
                    $"accepted share ({rnd.Next(100, 999)}ms)",
                    $"new job diff {diff:F0}",
                    $"nonce 0x{rnd.Next(0x100000, 0xFFFFFF):X6}",
                    $"share ok | {hashRate:F2} MH/s | GPU {gpuTemperature:F0}°C",
                    $"fans @ {gpuFanRpm:F0} RPM",
                    $"power draw {gpuPower:F0} W"
                };
                Log(msgs[rnd.Next(msgs.Length)], Color.FromArgb(200, 200, 200));
            }

            CheckAchievements();

            if (isMining && !isPaused)
            {
                var span = DateTime.Now - sessionStart;
                lblSession.Text = $"{span:hh\\:mm\\:ss}";
                totalUptime = span;
            }
        }

        private void TimerStake_Tick(object sender, EventArgs e)
        {
            if (stakedBalance > 0)
            {
                double hourlyRate = stakeApy / 100.0 / (365 * 24);
                balance += stakedBalance * hourlyRate;
            }
        }

        // ============ START/STOP ============
        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (isMining) StopMining();
            else StartMining();
        }

        private void StartMining()
        {
            isMining = true;
            isPaused = false;
            sessionStart = DateTime.Now;
            btnStartStop.Text = "■  STOP";
            btnPause.Enabled = true;
            btnPause.Text = "⏸  PAUSE";
            lblStatus.Text = "MINING";
            lblStatus.ForeColor = Color.White;
            Log("▶ Майнинг запущен", Color.White);
            Log($"Пул: {cmbPool.Text}  |  Профиль: {miningProfile}", Color.FromArgb(180, 180, 180));
        }

        private void StopMining()
        {
            isMining = false;
            isPaused = false;
            btnStartStop.Text = "▶  START";
            btnPause.Enabled = false;
            btnPause.Text = "⏸  PAUSE";
            lblStatus.Text = "IDLE";
            lblStatus.ForeColor = Color.FromArgb(120, 120, 120);
            Log("■ Майнинг остановлен", Color.FromArgb(200, 200, 200));
            targetFanRpm = 1200f;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (!isMining) return;
            isPaused = !isPaused;
            if (isPaused)
            {
                btnPause.Text = "▶  RESUME";
                lblStatus.Text = "PAUSED";
                lblStatus.ForeColor = Color.FromArgb(180, 180, 180);
                Log("⏸ Пауза", Color.FromArgb(180, 180, 180));
            }
            else
            {
                btnPause.Text = "⏸  PAUSE";
                lblStatus.Text = "MINING";
                lblStatus.ForeColor = Color.White;
                Log("▶ Возобновлено", Color.White);
            }
        }

        // ============ ЛОГИ ============
        private void Log(string message, Color color)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string full = $"[{time}] {message}";
            allLogs.Add(full);

            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;
            txtLog.SelectionColor = Color.FromArgb(130, 130, 130);
            txtLog.AppendText($"[{time}] ");
            txtLog.SelectionColor = color;
            txtLog.AppendText(message + Environment.NewLine);
            txtLog.SelectionColor = txtLog.ForeColor;
            txtLog.ScrollToCaret();
        }

        private void BtnExportLogs_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"btc_miner_logs_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
                File.WriteAllLines(file, allLogs);
                ShowToast("Логи сохранены на рабочий стол");
                Log($"↳ Логи экспортированы: {file}", Color.White);
            }
            catch (Exception ex)
            {
                ShowToast("Ошибка экспорта");
                Log($"✗ Ошибка: {ex.Message}", Color.White);
            }
        }

        // ============ ГРАФИК ============
        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(14, 14, 16));

            int w = panelChart.Width, h = panelChart.Height;

            using (var pen = new Pen(Color.FromArgb(35, 35, 35), 1))
            {
                for (int i = 0; i <= 6; i++)
                    g.DrawLine(pen, 0, i * h / 6, w, i * h / 6);
                for (int i = 0; i <= 10; i++)
                    g.DrawLine(pen, i * w / 10, 0, i * w / 10, h);
            }

            if (hashHistory.Count < 2) return;

            double maxH = 1, maxD = 1;
            foreach (var v in hashHistory) if (v > maxH) maxH = v;
            foreach (var v in diffHistory) if (v > maxD) maxD = v;

            DrawLine(g, hashHistory, maxH, w, h, Color.White, 2f, true);
            DrawLine(g, diffHistory, maxD, w, h, Color.FromArgb(120, 120, 120), 1f, false);
        }

        private void DrawLine(Graphics g, List<double> data, double max, int w, int h, Color color, float thick, bool fill)
        {
            if (data.Count < 2) return;
            var pts = new List<PointF>();
            for (int i = 0; i < data.Count; i++)
            {
                float x = i * (float)w / (data.Count - 1);
                float y = h - (float)(data[i] / max * (h - 20)) - 10;
                pts.Add(new PointF(x, y));
            }

            if (fill)
            {
                var poly = new List<PointF>(pts);
                poly.Add(new PointF(pts[pts.Count - 1].X, h));
                poly.Add(new PointF(pts[0].X, h));
                using (var br = new LinearGradientBrush(
                    new Point(0, 0), new Point(0, h),
                    Color.FromArgb(70, color), Color.FromArgb(0, color)))
                {
                    g.FillPolygon(br, poly.ToArray());
                }
            }

            using (var pen = new Pen(Color.FromArgb(80, color), thick * 4)) { pen.LineJoin = LineJoin.Round; g.DrawLines(pen, pts.ToArray()); }
            using (var pen = new Pen(color, thick)) { pen.LineJoin = LineJoin.Round; g.DrawLines(pen, pts.ToArray()); }

            var last = pts[pts.Count - 1];
            using (var br = new SolidBrush(Color.FromArgb(90, color))) g.FillEllipse(br, last.X - 8, last.Y - 8, 16, 16);
            using (var br = new SolidBrush(color)) g.FillEllipse(br, last.X - 4, last.Y - 4, 8, 8);
        }

        private void PanelGpuMon_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(14, 14, 16));

            int w = panelGpuMon.Width, h = panelGpuMon.Height;

            using (var pen = new Pen(Color.FromArgb(35, 35, 35), 1))
                for (int i = 0; i <= 4; i++)
                    g.DrawLine(pen, 0, i * h / 4, w, i * h / 4);

            if (tempHistory.Count >= 2) DrawScaledLine(g, tempHistory, w, h, 30, 100, Color.FromArgb(220, 220, 220), 2f);
            if (fanHistory.Count >= 2) DrawScaledLine(g, fanHistory, w, h, 0, 6000, Color.FromArgb(140, 140, 140), 1.5f);
            if (powerHistory.Count >= 2) DrawScaledLine(g, powerHistory, w, h, 0, 400, Color.FromArgb(90, 90, 90), 1f);
        }

        private void DrawScaledLine(Graphics g, List<float> data, int w, int h, float min, float max, Color color, float thick)
        {
            var pts = new List<PointF>();
            for (int i = 0; i < data.Count; i++)
            {
                float x = i * (float)w / (data.Count - 1);
                float norm = (data[i] - min) / (max - min);
                norm = Math.Max(0, Math.Min(1, norm));
                float y = h - norm * (h - 10) - 5;
                pts.Add(new PointF(x, y));
            }
            using (var pen = new Pen(Color.FromArgb(50, color), thick * 4)) g.DrawLines(pen, pts.ToArray());
            using (var pen = new Pen(color, thick)) g.DrawLines(pen, pts.ToArray());
        }

        private void PanelStatusDot_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(panelStatusDot.BackColor);

            float cx = panelStatusDot.Width / 2f;
            float cy = panelStatusDot.Height / 2f;

            Color col = !isMining ? Color.FromArgb(80, 80, 80)
                      : isPaused ? Color.FromArgb(180, 180, 180)
                      : Color.White;

            float r1 = 6 + 8 * (float)Math.Abs(Math.Sin(pulsePhase * Math.PI / 180.0));
            using (var br = new SolidBrush(Color.FromArgb(15, col))) g.FillEllipse(br, cx - r1 * 2, cy - r1 * 2, r1 * 4, r1 * 4);

            float r2 = 5 + 4 * (float)Math.Abs(Math.Sin(pulsePhase * Math.PI / 180.0));
            using (var br = new SolidBrush(Color.FromArgb(50, col))) g.FillEllipse(br, cx - r2, cy - r2, r2 * 2, r2 * 2);

            using (var br = new SolidBrush(col)) g.FillEllipse(br, cx - 4, cy - 4, 8, 8);
        }

        private void PanelSideStats_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(18, 18, 20));

            using (var pen = new Pen(Color.FromArgb(40, 40, 40), 1))
                g.DrawRectangle(pen, 0, 0, panelSideStats.Width - 1, panelSideStats.Height - 1);

            using (var f = new Font("Segoe UI", 9, FontStyle.Bold))
            using (var fv = new Font("Consolas", 11, FontStyle.Bold))
            {
                int y = 20;
                g.DrawString("GPU MONITOR", f, Brushes.White, 15, y); y += 30;

                double avg = totalHashSamples > 0 ? totalHashSum / totalHashSamples : 0;
                double acceptRate = totalShares > 0 ? (double)acceptedShares / totalShares * 100 : 0;

                DrawStat(g, f, fv, ref y, "Avg Hash", $"{avg:F2} MH/s");
                DrawStat(g, f, fv, ref y, "Best", $"{bestHashRate:F2} MH/s");
                DrawStat(g, f, fv, ref y, "Shares", $"{acceptedShares}/{rejectedShares}");
                DrawStat(g, f, fv, ref y, "Accept", $"{acceptRate:F1}%");
                DrawStat(g, f, fv, ref y, "Uptime", $"{totalUptime:hh\\:mm\\:ss}");
                DrawStat(g, f, fv, ref y, "Temp", $"{gpuTemperature:F0} °C");
                DrawStat(g, f, fv, ref y, "Fans", $"{gpuFanRpm:F0} RPM");
                DrawStat(g, f, fv, ref y, "Power", $"{gpuPower:F0} W");
                DrawStat(g, f, fv, ref y, "Staked", $"{stakedBalance:F8}");
            }
        }

        private void DrawStat(Graphics g, Font f, Font fv, ref int y, string key, string val)
        {
            g.DrawString(key, f, new SolidBrush(Color.FromArgb(140, 140, 140)), 15, y);
            g.DrawString(val, fv, Brushes.White, 130, y - 2);
            y += 32;
        }

        private void RefreshStats() => panelSideStats.Invalidate();

        private void UpdateGpuLabels()
        {
            if (lblGpuTemp != null)
            {
                lblGpuTemp.Text = $"{gpuTemperature:F0} °C";
                lblGpuTemp.ForeColor = gpuTemperature > 80 ? Color.White :
                                        gpuTemperature > 65 ? Color.FromArgb(220, 220, 220) :
                                        Color.FromArgb(180, 180, 180);
            }
            if (lblGpuFan != null) lblGpuFan.Text = $"{gpuFanRpm:F0} RPM";
            if (lblGpuPower != null) lblGpuPower.Text = $"{gpuPower:F0} W";
        }

        // ============ ВКЛАДКИ ============
        private void Tab_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl == null) return;
            activeTab = int.Parse(lbl.Tag.ToString());
            fadeAlpha = 0f;
            RefreshTabs();
        }

        private void RefreshTabs()
        {
            var tabs = new[] { lblTabMining, lblTabSend, lblTabReceive, lblTabSettings, lblTabAdvanced };
            var pages = new Control[] { pageMining, pageSend, pageReceive, pageSettings, pageAdvanced };

            for (int i = 0; i < tabs.Length; i++)
            {
                bool active = (i == activeTab);
                tabs[i].ForeColor = active ? Color.White : Color.FromArgb(100, 100, 100);
                tabs[i].Font = new Font("Segoe UI Semibold", 10, active ? FontStyle.Bold : FontStyle.Regular);
                pages[i].Visible = active;
            }

            panelTabIndicator.Left = tabs[activeTab].Left;
            panelTabIndicator.Width = tabs[activeTab].Width;
        }

        // ============ КОШЕЛЁК ============
        private string GenerateFakeWallet()
        {
            const string chars = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
            var sb = new StringBuilder("1");
            for (int i = 0; i < 33; i++) sb.Append(chars[rnd.Next(chars.Length)]);
            return sb.ToString();
        }

        private bool IsValidBtcAddress(string addr)
        {
            if (string.IsNullOrWhiteSpace(addr)) return false;
            return Regex.IsMatch(addr, @"^[13][a-km-zA-HJ-NP-Z1-9]{25,34}$");
        }

        private void BtnCopyWallet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWallet.Text))
            {
                Clipboard.SetText(txtWallet.Text);
                Log("Адрес скопирован", Color.White);
                ShowToast("Скопировано");
            }
        }

        private void BtnNewWallet_Click(object sender, EventArgs e)
        {
            txtWallet.Text = GenerateFakeWallet();
            Log("Сгенерирован новый кошелёк", Color.White);
            ShowToast("Новый кошелёк");
        }

        private void BtnSetWallet_Click(object sender, EventArgs e)
        {
            string w = txtNewWalletInput.Text.Trim();
            if (!IsValidBtcAddress(w))
            {
                ShowToast("Невалидный адрес");
                Log("✗ Невалидный BTC-адрес", Color.FromArgb(220, 220, 220));
                return;
            }
            txtWallet.Text = w;
            Log($"Кошелёк изменён: {w.Substring(0, 14)}...", Color.White);
            ShowToast("Кошелёк обновлён");
        }

        // ============ ОТПРАВКА ============
        private void BtnSendConfirm_Click(object sender, EventArgs e)
        {
            string addr = txtSendAddress.Text.Trim();
            if (!IsValidBtcAddress(addr)) { ShowToast("Невалидный адрес"); return; }

            if (!double.TryParse(txtSendAmount.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double amt) || amt <= 0)
            { ShowToast("Некорректная сумма"); return; }

            if (amt > balance) { ShowToast("Недостаточно средств"); return; }

            balance -= amt;
            string rec = $"↗ {amt:F8} BTC → {addr.Substring(0, 12)}...";
            txHistory.Add($"{DateTime.Now:HH:mm:ss}  {rec}");
            RefreshTxHistory();
            Log(rec, Color.White);
            ShowToast("Транзакция отправлена");

            txtSendAddress.Clear();
            txtSendAmount.Text = "0.00000001";
        }

        private void RefreshTxHistory()
        {
            lstTxHistory.Items.Clear();
            for (int i = txHistory.Count - 1; i >= 0; i--) lstTxHistory.Items.Add(txHistory[i]);
            if (txHistory.Count == 0) lstTxHistory.Items.Add("— история пуста —");
        }

        private void BtnCopyReceive_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtWallet.Text);
            ShowToast("Адрес скопирован");
        }

        private void BtnShowQr_Click(object sender, EventArgs e)
        {
            Log("┌" + new string('─', 32) + "┐", Color.White);
            for (int i = 0; i < 8; i++)
            {
                var sb = new StringBuilder("│");
                for (int j = 0; j < 32; j++)
                    sb.Append(rnd.Next(2) == 0 ? "█" : " ");
                sb.Append("│");
                Log(sb.ToString(), Color.White);
            }
            Log("└" + new string('─', 32) + "┘", Color.White);
            ShowToast("QR в логах");
        }

        // ============ НАСТРОЙКИ ============
        private void RefreshSettings()
        {
            trackIntensity.Value = intensity;
            numThreads.Value = threads;
            chkAutoStop.Checked = autoStop;
            chkAutoRestart.Checked = autoRestart;
            txtAutoStopTarget.Text = autoStopTarget.ToString("F8");
            lblIntensityVal.Text = intensity.ToString();
            lblThreadsVal.Text = threads.ToString();
        }

        private void TrackIntensity_Scroll(object sender, EventArgs e)
        {
            intensity = trackIntensity.Value;
            lblIntensityVal.Text = intensity.ToString();
        }

        private void NumThreads_ValueChanged(object sender, EventArgs e)
        {
            threads = (int)numThreads.Value;
            lblThreadsVal.Text = threads.ToString();
        }

        private void ChkAutoStop_CheckedChanged(object sender, EventArgs e) { autoStop = chkAutoStop.Checked; }
        private void ChkAutoRestart_CheckedChanged(object sender, EventArgs e) { autoRestart = chkAutoRestart.Checked; }

        private void TxtAutoStopTarget_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtAutoStopTarget.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out autoStopTarget);
        }

        private void CmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            miningProfile = cmbProfile.Text;
            Log($"Профиль: {miningProfile}", Color.FromArgb(180, 180, 180));
        }

        private void BtnStake_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtStakeAmount.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out double amt) || amt <= 0)
            { ShowToast("Введите сумму"); return; }
            if (amt > balance) { ShowToast("Недостаточно средств"); return; }

            balance -= amt;
            stakedBalance += amt;
            Log($"🔒 Застейкано {amt:F8} BTC (APY {stakeApy}%)", Color.White);
            ShowToast("Стейкинг запущен");
        }

        private void BtnUnstake_Click(object sender, EventArgs e)
        {
            if (stakedBalance <= 0) { ShowToast("Нечего снимать"); return; }
            balance += stakedBalance;
            Log($"🔓 Снято {stakedBalance:F8} BTC", Color.White);
            stakedBalance = 0;
            ShowToast("Стейкинг снят");
        }

        private void BtnReferral_Click(object sender, EventArgs e)
        {
            balance += referralBonus;
            Log($"👥 Реферальный бонус: +{referralBonus:F8} BTC", Color.White);
            ShowToast("Бонус получен");
        }

        private void BtnCalcProfit_Click(object sender, EventArgs e)
        {
            double daily = hashRate * 0.00000005 * 86400 / 1000.0;
            double monthly = daily * 30;
            double yearly = daily * 365;
            Log($"💰 Прогноз: день {daily:F8} | мес {monthly:F8} | год {yearly:F8} BTC", Color.White);
            ShowToast("Прогноз в логах");
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "btc_miner_settings.json");
                string json = $@"{{ ""intensity"": {intensity}, ""threads"": {threads}, ""autoStop"": {autoStop.ToString().ToLower()}, ""profile"": ""{miningProfile}"" }}";
                File.WriteAllText(path, json);
                ShowToast("Настройки сохранены");
            }
            catch { ShowToast("Ошибка"); }
        }

        private void BtnLoadSettings_Click(object sender, EventArgs e)
        {
            ShowToast("Настройки загружены");
            Log("↳ Настройки загружены", Color.White);
        }

        private void BtnToggleTheme_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ShowToast(isDarkTheme ? "Dark" : "Ultra-Dark");
            Invalidate();
        }

        // ============ АЧИВКИ ============
        private void CheckAchievements()
        {
            if (balance >= 0.000001 && unlockedAchievements.Add("first_satoshi"))
                NotifyAchievement("First Satoshi", "0.000001 BTC");
            if (totalShares >= 100 && unlockedAchievements.Add("shares_100"))
                NotifyAchievement("Century", "100 shares");
            if (bestHashRate >= 100 && unlockedAchievements.Add("hash_100"))
                NotifyAchievement("Hash Master", "100 MH/s");
            if (balance >= 0.00001 && unlockedAchievements.Add("balance_10k"))
                NotifyAchievement("Satoshi's Dream", "0.00001 BTC");
            if (acceptedShares >= 500 && unlockedAchievements.Add("shares_500"))
                NotifyAchievement("Miner Pro", "500 shares");
        }

        private void NotifyAchievement(string name, string desc)
        {
            Log($"🏆 {name} — {desc}", Color.White);
            ShowToast($"🏆 {name}");
            RefreshAchievements();
        }

        private void RefreshAchievements()
        {
            lstAchievements.Items.Clear();
            string[] all =
            {
                "first_satoshi|First Satoshi|0.000001 BTC",
                "shares_100|Century|100 shares",
                "hash_100|Hash Master|100 MH/s",
                "balance_10k|Satoshi's Dream|0.00001 BTC",
                "shares_500|Miner Pro|500 shares"
            };
            foreach (var s in all)
            {
                var parts = s.Split('|');
                bool ok = unlockedAchievements.Contains(parts[0]);
                lstAchievements.Items.Add($"{(ok ? "✔" : "○")}  {parts[1]}  —  {parts[2]}");
            }
        }

        // ============ КОНВЕРТЕР ============
        private void UpdateConverter()
        {
            double usd = balance * btcPriceUsd;
            double rub = usd * usdToRub;
            if (lblConvBtc != null) lblConvBtc.Text = $"{balance:F8} BTC";
            if (lblConvUsd != null) lblConvUsd.Text = $"${usd:F2}";
            if (lblConvRub != null) lblConvRub.Text = $"{rub:F2} ₽";
        }

        private void ShowToast(string text)
        {
            lblToast.Text = text;
            lblToast.Visible = true;
            toastTimer.Stop();
            toastTimer.Start();
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            toastTimer.Stop();
            lblToast.Visible = false;
        }

        // ============ ОКНО ============
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) { Application.Exit(); }
        private void BtnMinimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void BtnFullscreen_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                BtnFullscreen_Click(null, null);
            if (e.KeyCode == Keys.Escape && WindowState == FormWindowState.Maximized && !menuOpen)
                WindowState = FormWindowState.Normal;
            if (e.KeyCode == Keys.Escape && menuOpen)
                menuOpen = false;
            if (e.KeyCode == Keys.F1)
                menuOpen = !menuOpen;
        }

        private void CmbPool_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log($"Пул: {cmbPool.Text}", Color.FromArgb(180, 180, 180));
        }

        // ============================================================
        // ============== МЕНЮ (FISHING-STYLE PANEL) ==================
        // ============================================================
        private void InitMenu()
        {
            menuItems.Clear();

            AddMenuItem("overclock", "PERFORMANCE", "⚡", "Overclock GPU", "Разгон: +18% core, +12% mem",
                () => FakeAction("Overclock применён: +18% / +12%"), true, () => menuToggles["overclock"]);
            AddMenuItem("cooling", "PERFORMANCE", "❄", "Cooling Profile", "Профиль охлаждения",
                () => { menuToggles["cooling_aggressive"] = !menuToggles["cooling_aggressive"]; FakeAction(menuToggles["cooling_aggressive"] ? "Cooling: Aggressive" : "Cooling: Balanced"); },
                true, () => menuToggles["cooling_aggressive"]);
            AddMenuItem("fan_curve", "PERFORMANCE", "🎚", "Fan Curve Editor", "Кривая вентиляторов",
                () => FakeAction("Кривая настроена: 5 точек"), false, null);
            AddMenuItem("power_limit", "PERFORMANCE", "🔋", "Power Limit", "Лимит мощности GPU",
                () => FakeAction("Power limit: 280 W"), false, null);
            AddMenuItem("mem_tweak", "PERFORMANCE", "🧠", "Memory Tweak", "Тайминги памяти",
                () => FakeAction("Тайминги оптимизированы"), false, null);
            AddMenuItem("stress_test", "PERFORMANCE", "🧪", "Stress Test", "60 секунд нагрузки",
                () => FakeAction("Стресс-тест запущен"), false, null);

            AddMenuItem("switch_pool", "NETWORK", "📡", "Switch Pool", "Сменить пул",
                () => FakeAction("Пул: EU-2 (24ms)"), false, null);
            AddMenuItem("vpn", "NETWORK", "🌐", "VPN Tunnel", "Анонимный VPN",
                () => { menuToggles["vpn"] = !menuToggles["vpn"]; FakeAction(menuToggles["vpn"] ? "VPN: Amsterdam" : "VPN отключён"); },
                true, () => menuToggles["vpn"]);
            AddMenuItem("alerts", "NETWORK", "🔔", "Alerts", "Оповещения",
                () => { menuToggles["alerts"] = !menuToggles["alerts"]; FakeAction(menuToggles["alerts"] ? "Оповещения ON" : "Оповещения OFF"); },
                true, () => menuToggles["alerts"]);
            AddMenuItem("benchmark", "NETWORK", "📊", "Benchmark", "Бенчмарк GPU",
                () => FakeAction("Benchmark: 118.4 MH/s"), false, null);

            AddMenuItem("daily_bonus", "ECONOMY", "🎁", "Daily Bonus", "Ежедневный бонус",
                () => { double b = 0.00000050; balance += b; FakeAction($"Bonus: +{b:F8} BTC"); },
                false, null);
            AddMenuItem("referral", "ECONOMY", "👥", "Referral", "Реферальная программа",
                () => FakeAction("Реф-ссылка: btcminer.io/r/8X4K2"), false, null);
            AddMenuItem("auto_withdraw", "ECONOMY", "🏦", "Auto-Withdraw", "Авто-вывод",
                () => { menuToggles["auto_withdraw"] = !menuToggles["auto_withdraw"]; FakeAction(menuToggles["auto_withdraw"] ? "Auto-withdraw ON" : "Auto-withdraw OFF"); },
                true, () => menuToggles["auto_withdraw"]);
            AddMenuItem("vip", "ECONOMY", "💎", "VIP Upgrade", "VIP: -50% комиссии",
                () => { menuToggles["vip"] = !menuToggles["vip"]; FakeAction(menuToggles["vip"] ? "💎 VIP активирован" : "VIP выключен"); },
                true, () => menuToggles["vip"]);

            AddMenuItem("driver", "SYSTEM", "🛠", "Driver Update", "Обновить драйвер",
                () => FakeAction("Драйвер: v552.44"), false, null);
            AddMenuItem("backup", "SYSTEM", "💾", "Wallet Backup", "Бэкап кошелька",
                () => FakeAction("wallet_backup.dat"), false, null);
            AddMenuItem("history", "SYSTEM", "📈", "Historical Chart", "30 дней статистики",
                () => FakeAction("30 дней загружено"), false, null);
            AddMenuItem("reset", "SYSTEM", "⚙", "Reset All", "Сбросить все данные",
                () => { balance = 0; stakedBalance = 0; hashHistory.Clear(); txHistory.Clear(); FakeAction("Все данные сброшены"); },
                false, null);

            BuildMenuUI();
        }

        private void AddMenuItem(string key, string section, string icon, string name, string desc,
            Action action, bool isToggle, Func<bool> getState)
        {
            menuItems.Add(new MenuItemData
            {
                Key = key,
                Section = section,
                Icon = icon,
                Name = name,
                Description = desc,
                Action = action,
                IsToggle = isToggle,
                GetState = getState
            });
        }

        private void BuildMenuUI()
        {
            if (panelMenu == null) return;

            panelMenu.Controls.Clear();
            panelMenu.AutoScroll = true;

            lblMenuTitle = new Label
            {
                Text = "TOOLS",
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(24, 24),
                Size = new Size(200, 30),
                BackColor = Color.Transparent
            };
            panelMenu.Controls.Add(lblMenuTitle);

            var lblSub = new Label
            {
                Text = "15+ функций",
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.FromArgb(120, 120, 120),
                Location = new Point(24, 54),
                Size = new Size(200, 16),
                BackColor = Color.Transparent
            };
            panelMenu.Controls.Add(lblSub);

            lblMenuClose = new Label
            {
                Text = "✕",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(180, 180, 180),
                Location = new Point(272, 24),
                Size = new Size(30, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };
            lblMenuClose.Click += (s, e) => { menuOpen = false; };
            panelMenu.Controls.Add(lblMenuClose);

            var lblSep = new Panel
            {
                BackColor = Color.FromArgb(40, 40, 44),
                Location = new Point(24, 82),
                Size = new Size(272, 1)
            };
            panelMenu.Controls.Add(lblSep);

            int y = 100;
            string lastSection = "";

            foreach (var item in menuItems)
            {
                if (item.Section != lastSection)
                {
                    var lblSection = new Label
                    {
                        Text = item.Section,
                        Font = new Font("Segoe UI Semibold", 8, FontStyle.Bold),
                        ForeColor = Color.FromArgb(110, 110, 110),
                        Location = new Point(24, y),
                        Size = new Size(250, 16),
                        BackColor = Color.Transparent
                    };
                    panelMenu.Controls.Add(lblSection);
                    y += 26;
                    lastSection = item.Section;
                }

                var row = new Panel
                {
                    Location = new Point(12, y),
                    Size = new Size(296, 42),
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand
                };

                var iconLbl = new Label
                {
                    Text = item.Icon,
                    Font = new Font("Segoe UI Emoji", 14),
                    ForeColor = Color.White,
                    Location = new Point(12, 6),
                    Size = new Size(30, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };

                var nameLbl = new Label
                {
                    Text = item.Name,
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.FromArgb(220, 220, 220),
                    Location = new Point(50, 4),
                    Size = new Size(180, 18),
                    BackColor = Color.Transparent
                };

                var descLbl = new Label
                {
                    Text = item.Description,
                    Font = new Font("Segoe UI", 7),
                    ForeColor = Color.FromArgb(110, 110, 110),
                    Location = new Point(50, 22),
                    Size = new Size(200, 14),
                    BackColor = Color.Transparent
                };

                Label statusLbl = null;
                if (item.IsToggle)
                {
                    statusLbl = new Label
                    {
                        Text = "",
                        Font = new Font("Segoe UI", 8, FontStyle.Bold),
                        ForeColor = Color.FromArgb(120, 120, 120),
                        Location = new Point(238, 12),
                        Size = new Size(50, 18),
                        TextAlign = ContentAlignment.MiddleRight,
                        BackColor = Color.Transparent
                    };
                }

                row.Controls.Add(iconLbl);
                row.Controls.Add(nameLbl);
                row.Controls.Add(descLbl);
                if (statusLbl != null) row.Controls.Add(statusLbl);

                var capturedItem = item;
                row.Click += (s, e) => MenuItemClick(capturedItem);
                foreach (Control c in row.Controls)
                {
                    c.Click += (s, e) => MenuItemClick(capturedItem);
                }

                row.MouseEnter += (s, e) => { row.BackColor = Color.FromArgb(38, 38, 42); nameLbl.ForeColor = Color.White; };
                row.MouseLeave += (s, e) => { row.BackColor = Color.Transparent; nameLbl.ForeColor = Color.FromArgb(220, 220, 220); };

                item.Row = row;
                item.IconLabel = iconLbl;
                item.NameLabel = nameLbl;
                item.StatusLabel = statusLbl;

                panelMenu.Controls.Add(row);
                y += 46;
            }

            lblMenuTooltip = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.FromArgb(160, 160, 160),
                Location = new Point(12, y + 20),
                Size = new Size(296, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            panelMenu.Controls.Add(lblMenuTooltip);

            RefreshMenuToggles();
        }

        private void MenuItemClick(MenuItemData item)
        {
            item.Action?.Invoke();
            RefreshMenuToggles();
        }

        private void RefreshMenuToggles()
        {
            foreach (var item in menuItems)
            {
                if (item.IsToggle && item.StatusLabel != null && item.GetState != null)
                {
                    bool on = item.GetState();
                    item.StatusLabel.Text = on ? "ON" : "OFF";
                    item.StatusLabel.ForeColor = on ? Color.White : Color.FromArgb(90, 90, 90);
                }
            }
        }

        private void FakeAction(string message)
        {
            Log($"⚙ {message}", Color.White);
            ShowToast(message.Length > 32 ? message.Substring(0, 32) + "..." : message);
        }

        private void BtnMenu_Click(object sender, EventArgs e) { menuOpen = !menuOpen; }
        private void PanelMenuShade_Click(object sender, EventArgs e) { menuOpen = false; }
    }

    public class Particle
    {
        public float X, Y, VX, VY, Size;
        public int Alpha;
    }

    public class MenuItemData
    {
        public string Key;
        public string Section;
        public string Icon;
        public string Name;
        public string Description;
        public Action Action;
        public bool IsToggle;
        public Func<bool> GetState;
        public Panel Row;
        public Label IconLabel;
        public Label NameLabel;
        public Label StatusLabel;
    }
}