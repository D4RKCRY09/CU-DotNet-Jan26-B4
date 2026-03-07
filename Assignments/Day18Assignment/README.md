<div align="center">
  <h1>🧬 C# Inheritance & Method Hiding Portfolio</h1>
  <p><b>Loan EMI System & Employee Compensation Management</b></p>
</div>

<hr />

## 📌 Overview

This repository features two comprehensive case studies exploring **Class Inheritance** and **Member Hiding (`new` keyword)** in C#. These projects demonstrate how to extend base functionality and redefine behaviors in scenarios where polymorphism (virtual/override) is restricted due to legacy or architectural constraints.

---

## 🏦 Case Study 1: Loan EMI Calculation System

A specialized financial module designed to calculate repayments for various loan products using method hiding to apply specific interest rates and fees.

### 🚀 Key Features

* `<b>`Member Hiding:`</b>` Implements the `<code>`new`</code>` keyword to redefine `<code>`CalculateEMI()`</code>` for specific loan types without virtual methods.
* `<b>`HomeLoan Logic:`</b>` Applies a flat 8% interest rate plus a 1% processing fee calculation.
* `<b>`CarLoan Logic:`</b>` Integrates a flat 9% interest rate and a fixed ₹15,000 insurance charge.
* `<b>`Array Processing:`</b>` Demonstrates base-class reference behavior when iterating through mixed loan objects in a loop.

### 📋 Expected Behavior

<ul>
  <li><b>Base Reference:</b> Calls the 10% simple interest method.</li>
  <li><b>Derived Reference:</b> Calls the product-specific (8% or 9%) logic.</li>
</ul>

---

## 👔 Case Study 2: Employee Compensation System

An organizational utility for calculating annual salaries across diverse employee categories (Permanent, Contract, and Intern).

### 🚀 Key Features

* `<b>`Permanent Employee:`</b>` Dynamic salary computation including 20% HRA, 10% Special Allowance, and experience-based Loyalty Bonuses (₹50,000).
* `<b>`Contract Employee:`</b>` Logic-based completion bonuses (₹30,000) based on contract duration (≥ 12 months).
* `<b>`Intern Employee:`</b>` Streamlined fixed-stipend calculation.
* `<b>`Reference Shadowing:`</b>` Explicitly demonstrates the difference between calling methods via a base class variable (`<code>`Employee`</code>`) versus a derived class variable.
