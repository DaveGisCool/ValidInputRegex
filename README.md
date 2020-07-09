# ValidInputRegex
DevBuild Lab 3 Regex

Task: Write a program that will recognize invalid inputs using regular expressions.
What will the application do?
● The program will validate different kinds of input.
Build Specifications
1. Try to figure these out without looking up others’ solutions!
2. Write a method that will validate names. Names can only have alphabets, they should start with a capital letter, and they have a maximum length of 30.
3. Write a method that will validate emails. An email should be in the following format: {combination of alphanumeric characters, with a length between 5 and 30, and there are no special characters}@{combination of alphanumeric characters, with a length between 5 and 10, and there is no special characters }.{domain can be combination of alphanumeric characters with a length of two or three}
4. Write a method that will validate phone numbers. A phone number should be in the following format: {area code of 3 digits} – {3digits} – {4 digits} such as 313-555-1212
5. Write a method that will validate date based on the following format: (dd/mm/yyyy).
Hints:
● Use https://regexr.com/ to try out the regular expressions before adding them to your C# code.
Extended Challenges:
● Accept multiple possible formats for telephone numbers, including (313)-555-1212 and 313.555.1212
● Accept 1 or 2 digits for month and day (in which case the invalid date example below would be valid)
● Only accept the proper ranges for month (1-12) and day (1-31).
● Write a method that validates HTML elements (Example: <p> </p> is a valid html element, and <h1 <h1> is not valid. Don’t worry about special cases where you have self-contained HTML elements).
