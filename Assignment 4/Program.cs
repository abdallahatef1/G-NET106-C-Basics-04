using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print  the second price(index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and  shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //   int[,] shelfCopies =
            //{
            //  { 3, 5 },
            // { 1, 4 }
            // };

            //   Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Write a method called PrintWelcomeMessage that takes no parameters and prints  "Welcome to the Library!".Call it from Main.
            // PrintWelcomeMessage();
            #endregion

            #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            // PrintBookTitle("Clean Code");   
            #endregion

            #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);  // 400 because the method does not change the original variable, it only changes a copy of it. pass by value 
           // Console.WriteLine("pages after call = " + pages);
            #endregion
        }
        #region q3 class method 
        //static void PrintWelcomeMessage()
        // {
        //  Console.WriteLine("Welcome to the Library!");

        // }
        #endregion

        #region q4 class method
        //static void PrintBookTitle(string title)
        // {
        //  Console.WriteLine("Book title: " + title);
        //}
        #endregion
         
        #region q5 class method
       // static void AddBonusPages(int pages) {
         //   pages += 50;
        //}
        #endregion
    }
}
