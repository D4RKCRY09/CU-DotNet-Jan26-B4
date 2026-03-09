<div align="center">
  <h1>📈 StreamBuzz Engagement Analytics</h1>
  <p><b>Creator Performance Tracking & Data Aggregation Engine</b></p>
</div>

<hr />

## 📌 Overview
StreamBuzz is a digital content platform designed to monitor creator engagement over a 4-week cycle. This application implements a robust data tracking system using the `CreatorStats` model, allowing for real-time registration, threshold-based performance filtering, and global statistical averaging.



---

## 🚀 Key Functional Modules

### 🔹 1. Creator Registration (`RegisterCreator`)
The system captures the creator's identity and a fixed-length array of engagement data.
* **Data Structure:** Stores a `string` name and a `double[]` representing four consecutive weeks of performance.
* **Storage:** Records are appended to a global `EngagementBoard` list, maintaining a persistent log for the session.

### 🔹 2. Threshold Analysis (`GetTopPostCounts`)
A specialized filter that identifies "high-performance" streaks.
* **Logic:** For every creator, the method evaluates their `WeeklyLikes` against a user-defined `likeThreshold`.
* **Mapping:** Returns a `Dictionary<string, int>` where the key is the creator's name and the value represents the frequency (count) of weeks where they met or exceeded the goal.
* **Edge Case:** If the threshold is set so high that no posts qualify (e.g., 5000+ likes), the system gracefully returns an empty dictionary and displays a "No top-performing posts" message.



### 🔹 3. Global Statistics (`CalculateAverageLikes`)
An aggregation engine that provides the "big picture" of platform engagement.
* **Algorithm:** Flattens the nested weekly arrays from all registered creators and computes the arithmetic mean of every recorded data point.
* **Formula:** $$Average = \frac{\sum \text{All Weekly Likes}}{\text{Total Number of Data Points}}$$

---

## 📋 System Requirements & Logic
| Feature | Technical Implementation |
| :--- | :--- |
| **Creator Metadata** | `CreatorName` (string), `WeeklyLikes` (double array) |
| **Collection Type** | `List<CreatorStats>` for primary storage |
| **Search Result** | `Dictionary<string, int>` for performance hits |
| **User Interface** | Menu-driven console (Switch/Case or If-Else loop) |



---

## 🛠️ Technical Stack
<ul>
  <li><b>Language:</b> C#</li>
  <li><b>Key Namespaces:</b> <code>System.Collections.Generic</code>, <code>System.Linq</code></li>
  <li><b>Data Structures:</b> Arrays, Lists, Dictionaries</li>
  <li><b>Framework:</b> .NET Core / .NET 6 / .NET 8</li>
</ul>

<hr />

<div align="center">
  <p><i>Developed to master data persistence, dictionary mapping, and statistical calculation in the .NET ecosystem.</i></p>
</div>
