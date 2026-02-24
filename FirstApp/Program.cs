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

        }
    }
}
