<div align="center">
  <h1>🛡️ SafeDrive Policy Optimizer</h1>
  <p><b>High-Performance Insurance Management System</b></p>
</div>

<hr />

## 📌 Overview

The SafeDrive Policy Optimizer is a robust backend utility designed for the insurance industry to manage large-scale policy databases. The system leverages the high-speed lookup capabilities of Dictionaries to handle bulk financial adjustments, regulatory data retention, and secure data retrieval.

---

## 🚀 Key Features

### 🔹 Bulk Risk Adjustment

To maintain financial stability, the system identifies high-risk profiles and applies automated premium adjustments.

<ul>
  <li><b>Criteria:</b> Targets policies with a <code>RiskScore</code> exceeding 75.</li>
  <li><b>Adjustment:</b> Applies a 5% increase to premiums.</li>
  <li><b>Precision:</b> Uses <code>decimal</code> data types to ensure 100% financial accuracy and prevent rounding errors during calculations.</li>
</ul>

### 🔹 Automated Data Retention (Clean-Up)

Ensures compliance with data privacy and retention laws by pruning outdated records.

<ul>
  <li><b>Logic:</b> Scans the database for policies with a <code>RenewalDate</code> older than 3 years.</li>
  <li><b>Concurrency Safety:</b> Implements a multi-step deletion process to avoid "Collection Modified" exceptions, ensuring system stability during iterations.</li>
</ul>

### 🔹 Optimized Security Lookup

Provides an instant, crash-proof retrieval mechanism for policy data.

<ul>
  <li><b>Performance:</b> Utilizes the <b>O(1)</b> average time complexity of Dictionary lookups for near-instant response times.</li>
  <li><b>Safety:</b> Features a "Safe-Check" algorithm that provides a custom "Not Found" response for invalid IDs, preventing runtime crashes.</li>
</ul>

---

## 📋 Technical Requirements & Constraints

| Requirement                    | Implementation Detail                                               |
| :----------------------------- | :------------------------------------------------------------------ |
| **Data Structure**       | `<code>`Dictionary&lt;string, Policy&gt;`</code>`               |
| **Financial Accuracy**   | Mandatory use of`<code>`decimal`</code>` for all Premium fields |
| **Efficiency**           | O(1) Time Complexity for ID-based searches                          |
| **Collection Integrity** | Staging-key deletion strategy to maintain iteration safety          |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Framework:</b> .NET 6 / .NET 8</li>
  <li><b>Collections:</b> <code>System.Collections.Generic</code></li>
  <li><b>Core Concepts:</b> Dictionary Hashing, LINQ for Filtering, Data Encapsulation.</li>
</ul>

<hr />

<div align="center">
  <p><i>Engineered for compliance, scalability, and high-precision financial management.</i></p>
</div>
