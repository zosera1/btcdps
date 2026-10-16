# btcdeepseek

A fake Bitcoin mining farm simulator built with C# and Windows Forms. Dark UI, smooth animations, fake GPU monitoring, and a slide-out tools panel. Everything is simulated — no real mining, no blockchain, no wallet interaction.

> **Disclaimer:** This is a UI/UX demo project. It does not mine Bitcoin, does not connect to any pool, does not use your GPU, and does not send transactions. Do not use it to mislead anyone.

---

## Features

- Fullscreen monochrome interface (black / white / grays)
- Glow effects, animated particle background, smooth value transitions
- Live charts: hash rate, difficulty, GPU temperature, fan speed, power draw
- Slide-out tools panel with 18 simulated functions
- Fake GPU monitoring (temperature, RPM, wattage rise while "mining")
- Mining profiles: Eco / Normal / Turbo
- Wallet generator with basic BTC address validation
- Send / Receive / Stake screens
- Achievements, transaction history, daily bonus, referral system
- BTC ↔ USD ↔ RUB converter
- Export logs and settings to JSON

---

## Requirements

- Windows 7 / 8 / 10 / 11
- .NET Framework 4.7.2 or newer
- Visual Studio 2019 / 2022 (to build from source)

---

## Build from source

git clone https://github.com/zosera1/btcdeepseek.git
cd btcdeepseek
start btcdeepseek.sln


In Visual Studio:

Build -> Rebuild Solution (Ctrl+Shift+B)
Debug -> Start Debugging (F5)


Prebuilt binaries are available under **Releases**.

---

## Controls

| Key / Button   | Action                       |
|----------------|------------------------------|
| `☰`            | Open tools panel             |
| `F1`           | Toggle tools panel           |
| `F11`          | Toggle fullscreen            |
| `Esc`          | Close panel / exit fullscreen|
| `START`        | Start simulated mining       |
| `PAUSE`        | Pause                        |
| `PROFIT`       | Show profit forecast in log  |

---

## Project layout

btcdeepseek/
├── FakeBTCMiner/
│ ├── Form1.cs
│ ├── Form1.Designer.cs
│ ├── Form1.resx
│ ├── Program.cs
│ ├── icon.ico
│ ├── App.config
│ └── Properties/
├── btcdeepseek.sln
├── .gitignore
├── LICENSE
└── README.md

---

## How it works

Four timers drive the whole thing:

- `timerMine` (700 ms) — generates random hash rate, adds fake earnings, writes log entries
- `timerAnim` (16 ms) — smooth value interpolation, pulse animation, panel slide, particle motion
- `timerBg` (30 ms) — moves background particles
- `timerStake` (3 s) — accrues staking rewards

All charts and glow effects are drawn manually with GDI+ in `OnPaint` handlers. No external libraries.

---

## Tools panel

The slide-out panel contains 18 simulated actions grouped into four sections:

- **Performance** — Overclock GPU, Cooling Profile, Fan Curve, Power Limit, Memory Tweak, Stress Test
- **Network** — Switch Pool, VPN Tunnel, Alerts, Benchmark
- **Economy** — Daily Bonus, Referral, Auto-Withdraw, VIP Upgrade
- **System** — Driver Update, Wallet Backup, Historical Chart, Reset All

Each action writes to the log and shows a toast. Toggle-type actions keep an ON/OFF state.

---

## Notes

- Mining is entirely fake. Balance, hash rate, temperature and fan RPM are randomized values.
- The wallet generator produces valid-looking but non-functional addresses.
- Settings are saved to `%USERPROFILE%\Desktop\btc_miner_settings.json`.
- Logs are exported to the desktop as `btc_miner_logs_YYYYMMDD_HHMMSS.txt`.

---

## License

MIT. See `LICENSE`.
