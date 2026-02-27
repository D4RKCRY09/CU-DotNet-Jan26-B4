<div align="center">
  <h1>🏏 Cricket Performance Tracker & Secure Terminal</h1>
  <p><b>Data Parsing, Exception Handling, and Console Security</b></p>
</div>

<hr />

## 📌 Overview

This repository contains two distinct C# modules focusing on secure user input and complex data processing. The primary project is a statistical analysis engine for cricket players, while the secondary module implements a high-security terminal interface for masked credential entry.

---

## 🚀 Case Study 1: Cricket Player Performance Tracker

A specialized utility designed for the "HackerLand Cricket League" to transform raw CSV data into meaningful performance metrics.

### 🔹 Advanced Business Logic

The system implements high-precision cricket formulas with conditional logic:

<ul>
  <li><b>Strike Rate (SR):</b> Calculates the scoring rate per 100 balls, identifying the most impactful hitters.</li>
  <li><b>Batting Average (Avg):</b> A dynamic calculation that adjusts based on the player's <code>IsOut</code> status, ensuring statistical accuracy for "not out" scenarios.</li>
</ul>

### 🔹 Robust Data Processing

* **CSV Parsing:** Efficiently splits and maps comma-separated values into a strongly-typed `<code>`Player`</code>` class.
* **Resilient Exception Handling:** Implements defensive programming to handle missing files, invalid numeric formats, and potential `<b>`DivideByZero`</b>` errors during math operations.
* **Data Filtration:** Automatically filters out statistical outliers (players with fewer than 10 balls faced) to ensure the leaderboard remains competitive.
* **Custom Sorting:** Utilizes `<code>`List&lt;T&gt;.Sort`</code>` to arrange the final roster by Strike Rate in descending order.

---

## 🔐 Case Study 2: The Secure Terminal

A security-focused interface module designed for masked character entry and credential protection.

### 🔹 Key Security Features

* **Character Masking:** Utilizes `<code>`Console.ReadKey(true)`</code>` to intercept keystrokes before they are echoed to the screen, replacing them with a custom `<code>`*`</code>` mask.
* **Buffer Management:** Captures the true `<code>`KeyChar`</code>` value into a secure string buffer while maintaining a visual "System Message" for the user.
* **State Preservation:** Uses iterative loops to ensure exactly 4 digits are captured, preventing unauthorized access lengths.

---

## 📊 Performance Metric Summary

| Metric                | Calculation Logic    | Handling Rule                      |
| :-------------------- | :------------------- | :--------------------------------- |
| **Strike Rate** | (Runs / Balls) * 100 | Must handle zero-ball scenarios    |
| **Average**     | Runs / Dismissals    | If Not Out, Average = Total Runs   |
| **Leaderboard** | Strike Rate (DESC)   | Minimum 10 balls faced requirement |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>I/O Management:</b> <code>System.IO</code> (File Parsing), <code>Console.ReadKey</code></li>
  <li><b>Data Structures:</b> <code>List<Player></code>, <code>String.Split</code></li>
  <li><b>Mathematical Precision:</b> Double-precision floating-point arithmetic</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed for professional data analysis and secure interface design within the .NET ecosystem.</i></p>
</div>
