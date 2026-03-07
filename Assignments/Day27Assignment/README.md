<div align="center">
  <h1>📝 The Daily Logger</h1>
  <p><b>Persistent Data Storage with C# File I/O</b></p>
</div>

<div align="center">
  <h1>📊 Financial Data Persistence Suite</h1>
  <p><b>Daily Reflection Logging & Loan Portfolio Management</b></p>
</div>

<hr />

## 📌 Overview

This repository combines two essential data persistence modules in C#. It explores the lifecycle of external data—from capturing simple user reflections in a continuous text log to managing complex financial objects via structured CSV serialization and risk assessment logic.

---

## 🏗️ Module 1: The Loan Portfolio Manager

A professional-grade utility for serializing, parsing, and analyzing loan data using the CSV (Comma Separated Values) format.

### 🚀 Key Features

* **Structured Serialization:** Implements header-based CSV writing, ensuring data is compatible with external tools like Microsoft Excel.
* **Smart Appending:** Utilizes the `StreamWriter` append toggle to allow users to add new loan records to an existing database without data loss.
* **Risk Stratification Engine:** Automatically categorizes loans based on interest rate thresholds:
  <ul>
      <li>🔴 <b>High Risk:</b> Interest Rate > 10%</li>
      <li>🟡 <b>Medium Risk:</b> Interest Rate 5% – 10%</li>
      <li>🟢 <b>Low Risk:</b> Interest Rate < 5%</li>
    </ul>
* **Defensive Data Parsing:** Implements `<code>`double.TryParse`</code>` and header-skipping logic to prevent runtime crashes during mathematical conversions.
* **Financial Formatting:** Uses the `<code>`:C`</code>` currency formatter for localized, human-readable monetary displays.

---

## 📝 Module 2: The Daily Logger

A foundational I/O utility focused on the continuous capture of sequential text data.

### 🚀 Key Features

* **Historical Persistence:** Configures the `<code>`StreamWriter`</code>` constructor to "Seek-to-End," ensuring every daily reflection is preserved chronologically.
* **Resource Optimization:** Demonstrates efficient stream handling to ensure that system resources are released and data is flushed to the disk immediately after entry.

---

## 📊 Loan Analysis Summary

| Feature                    | Implementation Logic                            |
| :------------------------- | :---------------------------------------------- |
| **Data Format**      | Comma-Separated Values (CSV)                    |
| **Risk Logic**       | Conditional branching based on `InterestRate` |
| **Parsing Strategy** | `line.Split(',')` with Header-Skip            |
| **Persistence**      | `new StreamWriter(filePath, true)`            |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Namespaces:</b> <code>System.IO</code>, <code>System.Collections.Generic</code></li>
  <li><b>Framework:</b> .NET 6 / .NET 8</li>
  <li><b>Core Concepts:</b> File Stream Management, CSV Parsing, Data Validation, and Currency Formatting.</li>
</ul>

<hr />

<div align="center">
  <p><i>Engineered for reliable data storage and high-precision financial reporting in the .NET ecosystem.</i></p>
</div>
