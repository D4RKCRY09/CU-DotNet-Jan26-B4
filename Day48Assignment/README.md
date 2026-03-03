<div align="center">
  <h1>📋 Global Banking & Identity Enrollment Portal</h1>
  <p><b>Comprehensive Web Entry Form for Bank Account Opening & KYC</b></p>
</div>

<div align="center">
  <h1>🎓 College Admission Entry Form</h1>
  <p><b>Structured Data Gathering & Input Validation</b></p>
</div>

<hr />

## 📌 Overview

This module represents a comprehensive **College Admission Form**, utilizing a table-based layout for structured data collection. The project demonstrates the application of specific HTML5 attributes to enforce data integrity, such as age restrictions via date ranges, score validation, and pattern-based input constraints.

---

## 🚀 Key Functional Features

### 🔹 1. Identification & Eligibility

The form captures foundational applicant data with built-in validation rules:

* `<b>`Name Mapping:`</b>` Uses the `pattern` attribute to ensure alphabetical entries and `required` to prevent empty submissions.
* `<b>`Age Validation:`</b>` Implements `min` and `max` attributes on the `date` input to restrict applicants within a specific birth year range (2000–2008).
* `<b>`Identity Masking:`</b>` Includes specialized inputs for gender selection via radio buttons for mutually exclusive choices.

### 🔹 2. Academic & Contact Verification

Ensures the quality of incoming data through numeric and type-specific constraints:

* `<b>`Contact Channels:`</b>` Utilizes `type="email"` for automatic format verification and `pattern` on text inputs to validate mobile number formats.
* `<b>`Academic Benchmarking:`</b>` The 10th and 12th score fields use `type="number"` with strict range boundaries (`min=75`, `max=100`) to filter eligible applicants.

### 🔹 3. Enrollment Preferences

Leverages selection-based controls to capture student requirements:

* `<b>`Course Selection:`</b>` A `<select>` dropdown provides a predefined list of academic paths (BTech, BCA, MBA).
* `<b>`Logistical Needs:`</b>` Captures hostel requirements and financial support status through dropdowns and binary checkboxes.

---

## 📊 Alignment & Layout Strategy

To maintain a clean, professional aesthetic, the form is encapsulated within a **Tabular Grid**:

<ul>
  <li><b>Label Positioning:</b> Descriptive text is placed within <code><td></code> elements to ensure horizontal alignment with input controls.</li>
  <li><b>Input Accessibility:</b> Uses <code><label for="..."></code> to map text to their respective IDs, enhancing the clickable area and screen-reader compatibility.</li>
  <li><b>Action Controls:</b> Grouped in the final row, providing clear <code>submit</code> and <code>reset</code> functionalities to manage the form lifecycle.</li>
</ul>

---

## 🛠️ Technical Stack

<ul>
  <li><b>Markup:</b> HTML5</li>
  <li><b>Layout Engine:</b> HTML <code><table></code> for precise control alignment.</li>
  <li><b>Validation:</b> Regex-based `pattern`, `required` booleans, and numeric range clamping.</li>
  <li><b>Framework:</b> Vanilla HTML5 for cross-browser compatibility.</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed as a reference for robust, user-friendly academic data collection.</i></p>
</div>
