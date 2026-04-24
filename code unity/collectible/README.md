# 🎮 Unity Endless Runner Game

Proyek ini adalah game **endless runner** yang dibuat menggunakan Unity dengan fitur utama seperti player movement, collectible items, AI bird (eagle), dan sistem environment yang terus di-generate secara dinamis.

---

## 🚀 Fitur Utama

- 🏃 Player movement (lari otomatis & kontrol pemain)
- 💰 Sistem collectible (coin)
- 🦅 AI Bird (leader & follower system)
- 🌍 Procedural environment (level generator)
- ⚠️ Obstacle & collision system
- 📏 Distance tracking (jarak tempuh)
- 🔄 Object rotation (animasi sederhana)
- 🧩 Modular script structure

---

## 🧠 Struktur Project

### 📁 Player
- `PlayerMove.cs`  
  Mengatur pergerakan karakter utama

---

### 📁 Collectible
- `CollectCoin.cs` → Logika pengambilan coin  
- `CollectibleControl.cs` → Kontrol object collectible  
- `LevelDistance.cs` → Menghitung jarak tempuh  
- `RotateObject.cs` → Animasi rotasi object  

---

### 📁 Eagle (AI System)
- `IBird.cs` → Interface untuk sistem burung  
- `Leader Bird.cs` → Burung utama (leader)  
- `FollowerBird.cs` → Burung pengikut  
- `Eagle Follow.cs` → Logika mengikuti target  
- `Bird.cs` → Base behavior burung  

---

### 📁 Environment
- `GenerateLevel.cs` → Generate level secara dinamis  
- `DestroyerSection.cs` → Hapus bagian level lama  
- `LevelBoundary.cs` → Batas area permainan  
- `LevelStarter.cs` → Start level  
- `ObstacleCollision.cs` → Deteksi tabrakan  
- `EndRunSequence.cs` → Game over / end sequence  

---

### 📁 Menu
- `MainMenu.cs` → Kontrol menu utama  

---

## 🛠️ Teknologi yang Digunakan

- 🎮 Unity Engine  
- 💻 C# Programming  
- 🧩 Object-Oriented Programming (OOP)  
- 🔄 Procedural Generation  

---

## 🎯 Tujuan Proyek

Proyek ini dibuat untuk:
- Mempelajari dasar pengembangan game di Unity
- Implementasi sistem modular dalam game
- Mengembangkan logika AI sederhana (follower system)
- Membuat game dengan sistem endless runner

---

## ▶️ Cara Menjalankan

1. Buka project di Unity Hub
2. Load scene utama
3. Klik tombol **Play**
4. Gunakan kontrol untuk menjalankan karakter

---

## 📌 Pengembangan Selanjutnya

- ✨ Tambah UI score & leaderboard
- 🔊 Tambah sound effect & background music
- 🎨 Improve visual & asset
- 🤖 Integrasi AI / gesture control (future idea)
- ⚔️ Tambah fitur interaktif (misalnya weapon system)

---

## 👨‍💻 Author

Dibuat sebagai bagian dari pembelajaran dan pengembangan skill di bidang game development & software engineering.

---