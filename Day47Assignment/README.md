<div align="center">
  <h1>📦 The Cargo Manifest Optimizer</h1>
  <p><b>Deeply Nested Collection Traversal & LINQ Data Transformation</b></p>
</div>

<hr />

## 📌 Overview

The Cargo Manifest Optimizer is an advanced data-processing module designed to manage a three-tier hierarchical structure: **Rows** → **Containers** → **Items**. This project demonstrates mastery over complex collection traversal, safe data handling of edge cases, and the use of modern LINQ techniques to flatten and reorganize multi-dimensional data.

---

## 🚀 Key Functional Requirements

### 🔹 Task A: The "Deep Search" (Filtering)

Implements a traversal algorithm to identify high-density storage units across the entire cargo bay.

<ul>
  <li><b>Mechanism:</b> Iterates through all bay rows and container IDs.</li>
  <li><b>Aggregation:</b> Sums individual <code>Item</code> weights within each container.</li>
  <li><b>Output:</b> Returns a flattened <code>List<string></code> of ContainerIDs that exceed a specific weight threshold.</li>
</ul>

### 🔹 Task B: The "Category Audit" (Grouping)

Performs a global inventory check to provide a statistical breakdown of item types.

<ul>
  <li><b>Dictionary Mapping:</b> Generates a <code>Dictionary<string, int></code> where keys represent unique categories (e.g., Tech, Food, Furniture).</li>
  <li><b>Data Consolidation:</b> Counts every occurrence of an item within a specific category, regardless of its row or container location.</li>
</ul>

### 🔹 Task C: The "Structural Reorganizer" (Transformation)

The most complex operation, converting a hierarchical database into a sorted, unique flat file.

<ul>
  <li><b>Flattening:</b> Uses <code>SelectMany</code> to collapse the 3D structure into a linear list of items.</li>
  <li><b>De-duplication:</b> Removes redundant entries based on the Item <code>Name</code>.</li>
  <li><b>Primary Sort:</b> Alphabetical order by <code>Category</code>.</li>
  <li><b>Secondary Sort:</b> Weight in <b>Descending</b> order within each category.</li>
</ul>

---

## 🛡️ Robustness & Safety

The engine is engineered to handle real-world data irregularities without runtime failures:

<ul>
  <li><b>Null-Safety:</b> Validates empty rows and empty containers using null-coalescing and conditional checks.</li>
  <li><b>Edge Case Stability:</b> Specifically tested against "Row 3" (empty container list) and "C206" (container with zero items).</li>
  <li><b>Performance:</b> Prioritizes LINQ Method Syntax over triple-nested <code>foreach</code> loops to reduce code complexity and improve readability.</li>
</ul>

---

## 📊 Logic Summary Table

| Operation            | Goal                    | Technical Strategy                  |
| :------------------- | :---------------------- | :---------------------------------- |
| **Filtering**  | Find Heavy Containers   | `Select` + `Where` (Weight Sum) |
| **Grouping**   | Category Item Count     | `GroupBy` + `ToDictionary`      |
| **Flattening** | 3D List to 1D List      | `SelectMany` (Double call)        |
| **Sorting**    | Category/Weight Ranking | `OrderBy` + `ThenByDescending`  |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Data Structures:</b> <code>List<List<Container>></code>, <code>Dictionary<string, int></code></li>
  <li><b>Technology:</b> LINQ (Method Syntax)</li>
  <li><b>Framework:</b> .NET 6 / .NET 8</li>
</ul>

<hr />

<div align="center">
  <p><i>Engineered for complex logistics management and high-performance collection processing.</i></p>
</div>
