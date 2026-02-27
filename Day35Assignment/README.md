<div align="center">
  <h1>🌲 Hierarchical Data Structures in C#</h1>
  <p><b>Modeling Organizational Charts with General Trees & Recursion</b></p>
</div>

<hr />

## 📌 Overview

This module demonstrates the implementation of a **General Tree** data structure to model real-world hierarchical reporting. By simulating an Organizational Chart, the project explores the relationship between "Parent" and "Child" nodes, list-based collection management, and the power of recursive algorithms for deep traversal.

---

## 🚀 Key Technical Components

### 🔹 1. The Generic Node Design

The foundation of the hierarchy is the `<code>`EmployeeNode`</code>` class, which acts as a container for both data and relationships.

<ul>
  <li><b>Encapsulation:</b> Stores identity data (Name and Position) while maintaining a private <code>List</code> of direct reports.</li>
  <li><b>Dynamic Growth:</b> The <code>AddReport()</code> method allows the tree to grow horizontally and vertically without pre-defined limits on the number of subordinates.</li>
</ul>

### 🔹 2. Recursive Traversal Logic

Visualizing a tree requires visiting every node in a logical order. The system implements a `<b>`Depth-First Search (DFS)`</b>` approach using recursion.

<ul>
  <li><b>Depth Tracking:</b> An integer parameter tracks the "level" of the current node relative to the root.</li>
  <li><b>Visual Indentation:</b> Dynamically generates white space and connectors (e.g., <code>└──</code>) to represent seniority and reporting lines visually in the console.</li>
  <li><b>Base Case & Iteration:</b> Automatically terminates at leaf nodes (employees with no reports) while iterating through all branches of the organization.</li>
</ul>

---

## 📊 Structural Representation

The implementation supports multi-level depth, as shown in the organizational path:

<pre>
CEO (Root)
└── Director (Level 1)
    └── Manager (Level 2)
        └── Senior Dev (Level 3)
        └── Junior Dev (Level 3)
</pre>

---

## 📋 Core Concepts Mastered

| Concept                         | Application in Project                                                    |
| :------------------------------ | :------------------------------------------------------------------------ |
| **General Tree**          | One-to-many relationship modeling between managers and reports.           |
| **Recursion**             | Efficiently printing nested data without complex nested loops.            |
| **Collection Management** | Using `List<T>` to manage dynamic child nodes.                          |
| **Object Composition**    | Integrating `EmployeeNode` into the `OrganizationTree` manager class. |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Collections:</b> <code>System.Collections.Generic</code> (List)</li>
  <li><b>Framework:</b> .NET 6 / .NET 8</li>
  <li><b>Complexity:</b> O(N) Time Complexity for full tree traversal.</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed to master the implementation of non-linear data structures and recursive logic in software engineering.</i></p>
</div>
