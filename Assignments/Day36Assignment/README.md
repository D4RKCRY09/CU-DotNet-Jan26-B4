<div align="center">
  <h1>🗄️ Relational Database Mastery Portfolio</h1>
  <p><b>SQL Query Optimization, Complex Joins, and Analytical Aggregations</b></p>
</div>

<hr />

## 📌 Overview

This repository features an advanced progression of SQL query modules designed for relational database management systems. The curriculum moves from fundamental table linking to complex analytical logic, utilizing the standard Northwind schema to solve real-world business intelligence challenges.

---

## 📈 Level 1: The Join Foundation

Focuses on **Normalization** and establishing the primary relationships between core business entities.

<ul>
  <li><b>Relational Mapping:</b> Connecting Products to Categories and Suppliers to identify inventory sources.</li>
  <li><b>Sales Attribution:</b> Linking Order data with Customer profiles and Employee records to track organizational accountability.</li>
  <li><b>Logistics Integration:</b> Utilizing the Shippers table to trace international fulfillment for specific regions like France.</li>
</ul>

---

## 📊 Level 2: Aggregations with Joins

Focuses on **Business Intelligence** by consolidating data across multiple tables to generate performance metrics.

<ul>
  <li><b>Inventory Analytics:</b> Grouping units in stock by Category to monitor supply levels.</li>
  <li><b>Revenue Tracking:</b> Calculating total customer expenditure by joining Order Details and calculating the product of Price and Quantity.</li>
  <li><b>Sales Leaderboards:</b> Ranking employee performance and identifying top-selling products through <code>COUNT</code> and <code>SUM</code> operations.</li>
</ul>

---

## 🔗 Level 3: Subqueries & Self-Joins

Focuses on **Advanced Data Relationships** and nested logic for comparative analysis.

<ul>
  <li><b>Self-Referencing Logic:</b> Implementing Self-Joins on the Employee table to map internal management hierarchies (Employees vs. Managers).</li>
  <li><b>Comparative Filtering:</b> Using subqueries to identify products priced above the global average.</li>
  <li><b>Set Theory Operations:</b> Utilizing <code>NOT IN</code> and <code>NOT EXISTS</code> to isolate customers with zero transaction history.</li>
</ul>

---

## 🚀 Level 4: Complex Logic & Advanced Joins

Focuses on **Enterprise-Scale Queries** involving multi-bridge joins and correlated logic.

<ul>
  <li><b>Spatial Analysis:</b> Connecting four tables (Employees, EmployeeTerritories, Territories, Regions) to map geographic coverage.</li>
  <li><b>Correlated Subqueries:</b> Generating category-specific insights, such as identifying the "Most Expensive Product" within its specific group.</li>
  <li><b>Conditional Aggregation:</b> Using <code>HAVING</code> clauses to filter customers with high-diversity purchasing habits (e.g., across 3+ different categories).</li>
</ul>

---

## 📋 Core SQL Concepts Mastered

| Skill Level            | Primary Operators & Clauses                              |
| :--------------------- | :------------------------------------------------------- |
| **Foundational** | `INNER JOIN`, `ON`, `WHERE`                        |
| **Analytical**   | `GROUP BY`, `SUM`, `COUNT`, `AVG`, `LIMIT/TOP` |
| **Relational**   | `SELF JOIN`, `NOT EXISTS`, `IN`                    |
| **Advanced**     | `HAVING`, `CORRELATED SUBQUERY`, `MULTI-WAY JOIN`  |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> SQL (Structured Query Language)</li>
  <li><b>Compatibility:</b> T-SQL (SQL Server), PostgreSQL, MySQL</li>
  <li><b>Design Pattern:</b> Relational Algebra and Set Theory</li>
</ul>

<hr />

<div align="center">
  <p><i>Engineered for high-performance data retrieval and scalable database architecture.</i></p>
</div>
