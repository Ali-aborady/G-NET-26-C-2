namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Regions
            /*
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example
            Console.WriteLine("\n" + new string('-', 70) + "\n");

            //to specify blocks of code that can be expanded or collapsed in the Visual Studio code editor.
            */
            #endregion

            #region Question 2: Variable Declaration -Explicit vs Implicit
            /*
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
                 /// specify the data type yourself & Can declare without initializing

            int num = 10;
            string name = "Ali";

            // IMPLICIT DECLARATION 
                 ///compiler determine the type & Must initialize when declaring
            var num2 = 20;
            var name2 = "Ali";
            */
            #endregion

            #region Question 3: Constants
            /*
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════
            //Value never changes --> Prevents accidental modification
            //Better performance --> Value is replaced at compile time
            //Self - documenting - Makes it clear the value is fixed
            //Memory efficient -No memory allocated at runtime

            const double PI = 3.14;
            const string AppName = "C#_Basics01";
            */
            #endregion

            #region Question 4: Class-level vs Method-level Scope

            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════
            //Class level scope :-
            ///Variables declared inside the class but outside any method. 
            ///Can be accessed by all methods in the class.

            //Method - Level Scope
            ///Variables declared inside a method. 
            ///Can only be accessed within that specific method.



            #endregion

            #region Question 5: Block-level Scope
            /*
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════
                 //Block - level scope means a variable is only accessible within the { }
                 //braces where it's declared.
            

            public void method()
            {
                int x = 10;  // Method-level scope

                if (x > 5)
                {
                    int y = 20;  // Block-level scope - only in this if block
                    Console.WriteLine(x);  
                    Console.WriteLine(y);   
                }

                Console.WriteLine(x);  
                //Console.WriteLine(y);  // error 
            }
            */
            #endregion


            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════
            //Local Variables :- Created when method is called , Destored when method exits
            //   & New copy created each method call

            //Static Variables :- Created when program starts , lives until program end
            //   & One copy shared across all instances
            /*
             public class Counter
             {
                 static int staticCount = 0;  
                 int localCount;               

                 public void ShowCount()
                 {
                     int localVar = 5;         
                     staticCount++;
                     Console.WriteLine(staticCount);  
                 }
             }
            */
            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════

            //Garbage Collector (GC) automatically manages memory by:-

            //Finding objects no longer in use
            //Freeing the memory they occupied
            //How it affects object lifetime:
            //Objects live as long as something references them
            //GC destroys objects when no references exist
            //You can't predict exactly when GC will run

            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════
            // Variable shadowing :- declaring a new variable with the same name as one in an outer scope.

            /*public void Example()
            {
               int x = 10;  // Outer variable

               if (true)
               {
                   int x = 20;  // ERROR, Can't shadow x in same method
               }
            }
            */

            //But shadowing is allowed between class-level and method-level.
            #endregion


            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════
            //Must start with a letter or underscore(_)
            //Can contain letters, digits, underscore - no spaces
            //Cannot be a C# keyword (like int, class, if)
            //Case sensitive (myVar != MyVar)
            //Cannot start with a digit
            #endregion

            #region Question 10: Naming Conventions
            // 
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for:
            //    (a) local variables,
            //    (b) class names, 
            //    (c) constants?
            // ══════════════════════════════════════════════════════════════════════
            /*
             Local variables   camelCase (starts lowercase)
             Class names       PascalCase (starts uppercase)
             Constants         PascalCase (starts uppercase)
            */
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════
            // Syntax Error    Code breaks language rules          int x = "hello";
            // Runtime Error   Happens while program runs          Dividing by zero: 10 / 0
            // Logical Error   Code runs but gives wrong result    Using + instead of * in calculation
            #endregion

        }
    }
}
