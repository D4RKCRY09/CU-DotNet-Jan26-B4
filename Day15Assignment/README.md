<div align="center">
  <h1>🚀 C# Object-Oriented Programming Portfolio</h1>
  <p><b>Height Management & Order Processing Systems</b></p>
</div>

<hr />

## 📌 Overview
This repository showcases two distinct C# implementations focusing on core **Object-Oriented Programming (OOP)** principles. These projects demonstrate advanced class design, instance-based logic, and data normalization techniques within the .NET ecosystem.

---

## 🏗️ Module 1: Order Processing Domain
Focuses on **Encapsulation** and **Non-Static Class Design** to manage commercial transactions.



### 🚀 Key Features
* **Instance Lifecycle:** Uses dual constructors (Default and Parameterized) to manage state initialization (Date/Status).
* **Strict Validation:** * Enforces valid `CustomerName` (non-null/empty).
    * Restricts `ApplyDiscount` to a range of **1-30%** and ensures it is applied **only once** per instance.
* **Data Protection:** Utilizes private fields with read-only properties for `OrderId` and `TotalAmount`.

### 📋 Sample Output
<pre>
Order Id: 101
Customer: Rahul
Total Amount: 720.00
Status: NEW
</pre>

---

## 📏 Module 2: Height Calculation System
Focuses on **Arithmetic Logic** and **Constructor Overloading** for imperial measurements.



### 🚀 Key Features
* **Automated Normalization:** Internal logic automatically converts excess inches ($\ge 12$) into feet, maintaining mathematical accuracy.
* **Object Interaction:** The `AddHeights` method accepts a `Height` object and returns a brand-new instance (Return-by-Value).
* **Format Overriding:** Overrides the native `.ToString()` method for human-readable output (e.g., `5 feet 6.5 inches`).

### 📋 Sample Output
<pre>
Height - 5 feet 6.5 inches
Height - 5 feet 7.5 inches
Height - 11 feet 2.0 inches
</pre>

---

## 🛠️ Technical Stack
* **Language:** C#
* **Framework:** .NET 6 / .NET 8
* **Patterns:** Encapsulation, Constructor Overloading, Method Overriding.

<hr />

<div align="center">
  <p><i>Developed as part of a technical up-skilling module for modern Software Engineering roles.</i></p>
</div>