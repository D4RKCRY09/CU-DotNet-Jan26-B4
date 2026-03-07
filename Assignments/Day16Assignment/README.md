<div align="center">
  <h1>🚀 C# Object-Oriented Programming Portfolio</h1>
  <p><b>Static Configuration, Order Processing & Height Calculation</b></p>
</div>

<hr />

## 📌 Overview
This repository showcases a suite of C# implementations designed to master **Object-Oriented Programming (OOP)**. The modules range from global utility management using static members to complex instance-based business logic and data normalization.

---

## ⚙️ Module 1: Static Configuration Tracker
Demonstrates **Utility Class Design** and the lifecycle of static members.


<ul>
  <li><b>Static Constructor:</b> Automates one-time initialization of global defaults (<code>ApplicationName</code>, <code>Environment</code>).</li>
  <li><b>Global State Tracking:</b> Uses a static <code>AccessCount</code> to monitor system-wide method calls.</li>
  <li><b>Global Access:</b> Implements <code>Initialize</code> and <code>Reset</code> logic accessible without object instantiation.</li>
</ul>

---

## 🏗️ Module 2: Order Processing Domain
Focuses on **Encapsulation** and **Non-Static Instance Interaction**.


<ul>
  <li><b>Instance Lifecycle:</b> Utilizes dual constructors to manage distinct order states.</li>
  <li><b>Business Validation:</b> Enforces strict rules for customer naming and a one-time discount policy (1–30%).</li>
  <li><b>Data Protection:</b> Private fields with controlled property access prevent unauthorized state changes.</li>
</ul>

---

## 📏 Module 3: Height Calculation System
Focuses on **Arithmetic Logic** and **Operator-like Behavior**.

<ul>
  <li><b>Automated Normalization:</b> Mathematical logic that converts excess inches (≥ 12) into feet automatically.</li>
  <li><b>Method-Driven Math:</b> The <code>AddHeights</code> method demonstrates returning new object instances.</li>
  <li><b>Custom Representation:</b> Overrides <code>ToString()</code> for standardized imperial output.</li>
</ul>

---

## 🛠️ Technical Stack
<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Target Framework:</b> .NET 6 / .NET 8</li>
  <li><b>Key Concepts:</b> Static vs Instance Members, Encapsulation, Constructor Overloading, Validation Logic.</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed for technical up-skilling in C# and .NET software engineering.</i></p>
</div>