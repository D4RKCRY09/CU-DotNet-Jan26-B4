<div align="center">
  <h1>🚕 OLA Driver Management System</h1>
  <p><b>One-to-Many Relationship Modeling & Financial Aggregation</b></p>
</div>

<hr />

## 📌 Overview

This module demonstrates a **One-to-Many relationship** between drivers and their completed trips within a ride-sharing ecosystem. The application processes a collection of drivers, iterates through their nested ride history, and calculates total earnings using object-oriented principles.

---

## 🚀 Key Architectural Components

### 🔹 1. Data Models

The system is built on two primary entities:

<ul>
  <li><b>OLADriver Class:</b> Acts as the "Parent" entity. It stores identity details (ID, Name, Vehicle Number) and maintains a <code>List<Ride></code> to track historical activity.</li>
  <li><b>Ride Class:</b> Acts as the "Child" entity. It captures granular trip data including unique IDs, geographic route (From/To), and the specific <code>Fare</code> charged for that journey.</li>
</ul>

### 🔹 2. Nested Iteration & Aggregation

The application utilizes nested loops to traverse the hierarchical data structure:

<ul>
  <li><b>Outer Loop:</b> Iterates through the <code>List<OLADriver></code> to identify each service provider.</li>
  <li><b>Inner Loop:</b> Accesses the <code>Rides</code> property of each driver to display individual trip logs.</li>
  <li><b>Accumulation Logic:</b> Dynamically sums the <code>Fare</code> of every ride to produce a "Total Fare" summary for each driver.</li>
</ul>

---

## 📊 Sample Output Structure

The system generates a structured report similar to the following:

<pre>
Driver: Rajesh (Vehicle: MH-12-AB-1234)
--------------------------------------
- Ride ID: 501 | Pune -> Mumbai | Fare: 2500
- Ride ID: 502 | Mumbai -> Lonavala | Fare: 1200
Total Earnings: 3700
======================================
</pre>

---

## 📋 Core Concepts Mastered

| Concept                    | Application in Project                                                |
| :------------------------- | :-------------------------------------------------------------------- |
| **Composition**      | Embedding a `List<Ride>` inside the `OLADriver` class.            |
| **Encapsulation**    | Managing driver and ride properties through strongly-typed objects.   |
| **Data Aggregation** | Calculating running totals across nested collections.                 |
| **Formatting**       | Generating human-readable console reports from complex object graphs. |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Collections:</b> <code>System.Collections.Generic.List<T></code></li>
  <li><b>Framework:</b> .NET 6 / .NET 8</li>
  <li><b>Design Pattern:</b> Domain Modeling (Parent-Child)</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed to demonstrate mastery over relational object modeling and collection-based reporting.</i></p>
</div>
