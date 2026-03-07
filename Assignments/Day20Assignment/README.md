<div align="center">
  <h1>✈️ SkyHigh Flight Aggregator</h1>
  <p><b>Advanced Sorting with IComparable and IComparer</b></p>
</div>

<hr />

## 📌 Overview
SkyHigh is a flight search engine module designed to transform raw, unsorted airline data into structured, user-friendly views. By implementing advanced sorting interfaces, the system provides a seamless experience for different user personas, ranging from budget-conscious travelers to time-sensitive professionals.

[Image of IComparable vs IComparer in C#]

---

## 🚀 Key Features

### 🔹 Natural Sorting (The Economy View)
The system utilizes <b>Natural Sorting</b> via the <code>IComparable</code> interface. By default, the flight engine prioritizes affordability, automatically arranging flight data from the lowest to the highest price.

### 🔹 Custom Sorting Strategies
To support diverse user preferences, the engine implements the <b>Strategy Pattern</b> through <code>IComparer</code>:
<ul>
  <li><b>Duration Comparison (Business Runner View):</b> Arranges flights based on travel time, ensuring the shortest durations are displayed first.</li>
  <li><b>Departure Comparison (Early Bird View):</b> Organizes flights chronologically, prioritizing the earliest departure times.</li>
</ul>

