\# Task 4 Reflection



\## 1. What differences did you observe moving from procedural to class-based design?



When I first worked with the payroll calculator, the program was mainly based around separate calculations and input/output statements. Moving it into a `Payroll` class made the code more organised because the payroll data and the operations performed on that data were kept together. The class also allowed me to control how values such as hours, rate and tax rate could be changed by using validation. This made the program easier to maintain and allowed the same `Payroll` class to be reused in other parts of the program, such as the unit tests.



\## 2. How does static typing affect your workflow?



C# being statically typed means that I need to specify the type of each variable and property, such as `double` for hours and `decimal` for monetary values. At first this required more attention than Python because I had to think about the types being used and conversions between them. However, it also helped identify incorrect types and some errors earlier when compiling the program. Using types such as `decimal` for the payroll rate and calculations also made the intended use of the values clearer.



