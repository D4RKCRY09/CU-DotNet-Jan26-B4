Case Study: Simple User Login Message Processor
Business Scenario
A console application displays login status messages entered by different users.
Because users type messages manually, the input may contain extra spaces and mixed casing.
Your task is to clean the message, check its meaning, and display a formatted result.
________________________________________
Input Specification (Single ReadLine Only)
The program receives one line of input in the following format:
<UserName>|<LoginMessage>
Example Input
Sharad|  LOGIN Successful  
________________________________________
Functional Requirements
________________________________________
1. String Operations (Entry Level)
Clean the LoginMessage:
1.	Remove leading and trailing spaces using Trim()
2.	Convert the message to lowercase using ToLower()
Example:
"  LOGIN Successful  "
→ "login successful"
________________________________________
2. String Search
Check whether the cleaned message contains the word:
"successful"
•	Use Contains() or IndexOf()
•	Case-insensitive (already handled by ToLower())
________________________________________
3. String Comparison
The system defines a standard login success message:
"login successful"
Compare the cleaned message with the standard message using:
Equals()
Determine:
•	Whether the message is standard
•	Or custom
________________________________________
4. Business Rules
•	If the keyword “successful” is not found
•	STATUS: LOGIN FAILED
•	If the keyword is found and message matches standard
•	STATUS: LOGIN SUCCESS
•	If the keyword is found but message does not match standard
•	STATUS: LOGIN SUCCESS (CUSTOM MESSAGE)
________________________________________
5. Formatted Display (Mandatory)
Display the output exactly in this format:
User     : Sharad
Message  : login successful
Status   : LOGIN SUCCESS
Requirements:
•	Labels aligned
•	Clean spacing
•	No extra blank lines
________________________________________
Constraints (Beginner Friendly)
•	✔ One Console.ReadLine() only
•	✔ Use basic string APIs:
o	Trim
o	ToLower
o	Contains or IndexOf
o	Equals
•	❌ No regex
•	❌ No culture APIs
________________________________________
Sample Test Cases
Input
Amit| Login successful 
Output Status
LOGIN SUCCESS
________________________________________
Input
Neha|login successful today
Output Status
LOGIN SUCCESS (CUSTOM MESSAGE)
________________________________________
Input
Ravi|invalid password
Output Status
LOGIN FAILED
________________________________________
What This Exercise Helps Learners Practice
Concept	Level
Trim & case conversion	Basic
String search	Basic
String comparison	Basic
Console formatting	Basic
Real-world thinking	Introductory

