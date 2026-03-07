<div align="center">
  <h1>🗄️ Relational Database Mastery Portfolio</h1>
  <p><b>SQL Query Optimization, Complex Joins, and Analytical Aggregations</b></p>
</div>

<div align="center">
  <h1>🔏 The Vowel-Shift Cipher</h1>
  <p><b>Algorithmic String Transformation & Character Mapping</b></p>
</div>

<hr />

## 📌 Overview

The Vowel-Shift Cipher is a specialized cryptographic utility designed to obscure lowercase text through conditional character rotation. Unlike a standard Caesar Cipher, this engine applies distinct logic paths for vowels and consonants, including sequence wrapping and "collision" avoidance for vowel-skipping.

---

## 🚀 Transformation Logic

### 🔹 Vowel Rotation (The Circular Sequence)

Vowels are treated as a closed-loop system. When the engine identifies a vowel, it maps it to the subsequent entry in the vowel sequence.

* **Sequence:** `a → e → i → o → u → a`
* **Wrap-Around:** The final vowel `u` automatically resets to the beginning of the sequence `a`.

### 🔹 Consonant Shifting (The Skip Protocol)

Consonants follow the standard alphabetical order, but with an integrated "Vowel-Skip" safeguard to maintain the cipher's unique structure.

* **Standard Shift:** `b → c`, `g → h`, `p → q`.
* **The Skip Rule:** If the incremented character results in a vowel, the engine jumps to the next available character (e.g., `d → f` because `e` is skipped; `h → j` because `i` is skipped).

---

## 📋 Case Study: "abcdu"

| Input Char  | Category  | Transformation                                        | Result |
| :---------- | :-------- | :---------------------------------------------------- | :----- |
| **a** | Vowel     | Shift to next vowel (`e`)                           | `e`  |
| **b** | Consonant | Shift to next letter (`c`)                          | `c`  |
| **c** | Consonant | Shift to next letter (`d`)                          | `d`  |
| **d** | Consonant | Shift to `e` → *Vowel Detected* → Skip to `f` | `f`  |
| **u** | Vowel     | Wrap-around sequence to `a`                         | `a`  |

---

## 🛠️ Technical Stack

<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Data Structures:</b> <code>string</code>, <code>char[]</code>, or <code>StringBuilder</code> for high-performance mutation.</li>
  <li><b>Logic:</b> Conditional branching (Switch/Case or If-Else) and modulus arithmetic for wrap-around.</li>
  <li><b>Target Framework:</b> .NET 6 / .NET 8</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed to demonstrate mastery over string manipulation, conditional logic, and algorithmic sequencing.</i></p>
</div>
