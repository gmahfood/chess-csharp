# ♟️ chess-csharp

![.NET](https://img.shields.io/badge/.NET-10.0-purple) ![C#](https://img.shields.io/badge/C%23-13.0-blue) ![Status](https://img.shields.io/badge/status-in%20development-orange)

A passion project born from a love of chess. This is my attempt at building a fully featured, modern chess game from scratch using C# and .NET 10 — starting from a clean engine and growing into something much bigger.

Chess has always been one of my favorite games, and after drawing inspiration from several open source chess repos on GitHub, I wanted to challenge myself to build my own version and push C# as far as it can go.

---

## 🏗️ Project Structure
```
chess-csharp/
├── src/
│   ├── ChessEngine/        # Core game logic — pure C#, no UI dependencies
│   ├── ChessDesktop/       # Avalonia cross-platform desktop app
│   ├── ChessWeb.Api/       # ASP.NET Core backend
│   └── ChessWeb.Client/    # Blazor WebAssembly frontend
├── tests/
│   └── ChessEngine.Tests/  # xUnit test suite
├── global.json
└── Chess.slnx
```

---

## ✅ Current State

The project is in early development. The core engine is being built first with a strong focus on clean architecture and test coverage before any UI is added.

- [x] Solution scaffold with all projects
- [x] `Square.cs` — board position with File and Rank enums
- [x] `Piece.cs` — abstract base class for all chess pieces
- [x] `Board.cs` — 8x8 board with piece initialization
- [ ] Individual piece classes (Pawn, Knight, Bishop, Rook, Queen, King)
- [ ] Move generation and validation
- [ ] Check, checkmate, and stalemate detection
- [ ] Special rules (castling, en passant, promotion)

---

## 🔮 Future Plans

This is the long term vision for where this project is going:

### 🎮 Gameplay
- Easy / Medium / Hard AI difficulty using Minimax with Alpha-Beta pruning
- Move tracker and full game history with PGN export
- Pawn promotion UI, draw conditions, and clock support

### 🤖 LLM Move Commentary
One of the most unique planned features — an integrated LLM that watches your game and gives real-time commentary on your moves. Think of it as a grandmaster sitting beside you, reacting to every decision you make.

### 🌐 Web Version
- Full Blazor WebAssembly frontend reusing the same C# engine
- Real-time multiplayer via ASP.NET Core + SignalR
- Potentially a React frontend as an alternative UI

### 🎲 3D Web Experience
- A 3D chess board rendered in the browser
- Unity (C#) engine integration for a fully immersive experience
- Online play with game history and player profiles

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# 13 / .NET 10 |
| Desktop UI | Avalonia UI |
| Web Frontend | Blazor WebAssembly |
| Web Backend | ASP.NET Core |
| Real-time | SignalR |
| Testing | xUnit |
| Version Control | Git + GitHub |

---

## 🚀 Getting Started
```bash
git clone https://github.com/gmahfood/chess-csharp.git
cd chess-csharp
dotnet build
dotnet test
```

Requires .NET 10 SDK — download at https://dotnet.microsoft.com/download

---

## 👤 Author

George Mahfood — [@gmahfood](https://github.com/gmahfood)

---

## 📄 License

MIT License — feel free to learn from it, just give credit.
