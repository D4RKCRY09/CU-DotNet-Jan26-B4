<div align="center">
  <h1>💸 Automated Trip Expense Equalizer</h1>
  <p><b>Algorithmic Debt Settlement & Financial Reporting</b></p>
</div>

<hr />

## 📌 Overview

The Trip Expense Equalizer is a high-precision settlement engine designed to resolve group debts. It automates the complex "who owes whom" logic by calculating a fair share for all participants and generating the most efficient transaction path to balance the books.

---

## 🚀 Core Engine Logic

### 🔹 1. Fair Share Calculation

The engine first aggregates the total expenditure of the entire group and divides it by the total number of participants. This determines the "zero-point" or the target spend for every individual.

* **Total Group Spend:** $\sum \text{Individual Payments}$
* **Target Balance:** $\frac{\text{Total Spend}}{\text{Participant Count}}$

### 🔹 2. Balance Identification

Participants are categorized based on their variance from the fair share:

<ul>
  <li><b>Creditors (+):</b> Individuals who paid more than the average and are owed money.</li>
  <li><b>Debtors (-):</b> Individuals who paid less than the average and must contribute to the pool.</li>
</ul>

### 🔹 3. Minimal Transaction Algorithm

The system uses a matching algorithm to clear debts efficiently. It pairs the largest debtors with the largest creditors iteratively until all balances reach zero. This ensures the fewest number of transactions possible, reducing the logistical burden on the group.

---

## 📊 Data Export & Accuracy

The system prioritizes financial integrity through standardized reporting:

<ul>
  <li><b>Precision:</b> All calculations utilize <code>decimal</code> types to prevent floating-point inaccuracies.</li>
  <li><b>CSV Output:</b> Generates a clean, portable <code>Payer, Receiver, Amount</code> file compatible with banking and spreadsheet software.</li>
  <li><b>Rounding:</b> Automatically rounds to two decimal places to match real-world currency standards.</li>
</ul>

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Data Structures:</b> <code>Dictionary<string, decimal></code> for balance tracking, <code>List<Transaction></code> for the ledger.</li>
  <li><b>Algorithms:</b> Greedy algorithm for settlement optimization.</li>
  <li><b>I/O:</b> <code>System.IO.StreamWriter</code> for CSV generation.</li>
</ul>

<hr />

<div align="center">
  <p><i>Engineered for seamless group travel and transparent financial reconciliation.</i></p>
</div>
