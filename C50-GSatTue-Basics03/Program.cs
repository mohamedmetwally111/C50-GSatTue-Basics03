using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace C50_GSatTue_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Q1. Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            //string Title= "clean code";
            //string UpperTitle = Title.ToUpper();
            //Console.WriteLine(Title);
            //Console.WriteLine(UpperTitle);
            #endregion

            #region question 2
            //Q2. Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            //string Text_1 = "Clean Code";
            //string Text_2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(Text_1, Text_2));
            #endregion

            #region question 3
            //Q3. Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            //StringBuilder Sb = new StringBuilder();
            //Sb.Append("Book List");
            //Sb.Append(" - Update");
            //Console.WriteLine(Sb);
            #endregion

            #region question 4
            //Q4. Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            //StringBuilder Sb = new StringBuilder();
            //Sb.Append("Book List");
            //Sb.Append(" - Update");
            //Sb.Replace("Book List", "Library");
            //Console.WriteLine(Sb);
            #endregion

            #region question 5
            //Q5. Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.
            //string Title= "Clean Code";
            //int pages = 464;
            //string result = "Book: " + Title + ", Pages: " + pages;
            //Console.WriteLine(result);
            #endregion

            #region question 6
            //Q6. Build the same sentence as above, but using string interpolation ($"..."). 
            //string Title= "Clean Code";
            //int pages = 464;
            //string result = $"Book: {Title}, Pages: {pages}";
            //Console.WriteLine(result);
            #endregion

            #region question 7
            //Q7. Build the same sentence as above, but using string interpolation ($"..."). 
            //string Title= "Clean Code";
            //int pages = 464;
            //string result = $"Book: {Title}, Pages: {pages}";
            //Console.WriteLine(result);
            #endregion

            #region question 8
            //Q8. Build the same sentence again, but using string.Format(). 
            //string Title= "Clean Code";
            //int pages = 464;
            //string result = string.Format("Book: {0}, Pages {1}",Title,pages);
            //Console.WriteLine(result);
            #endregion

            #region question 9
            //Q9. Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion

            #region question 10
            //Q10. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator. 
            //int pages = 464;
            //bool isAvailable = true;
            //if(pages>300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region question 11
            //Q11. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else. 
            //string Title = "Refactoring";
            //switch(Title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region question 12
            //Q12. Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string Store= pages>300 ? "Long Book" : "Short Book";
            //Console.WriteLine(Store);
            #endregion

            #region question 13
            //Q13. Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i=0;i<books.Length;i++)
            //{
            //    Console.WriteLine($"{i+1}. {books[i]}");
            //}
            #endregion

            #region question 14
            //Q14. Using the same books array, use a while loop to print every book title. 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while(i<books.Length)
            //{
            //    Console.WriteLine($"{i+1}. {books[i]}");
            //    i++;
            //}
            #endregion

            #region question 15
            //Q15. Write a do-while loop that prints "Checking book..." exactly 3 times. 
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i<4);
            #endregion

            #region question 16
            //Q16. Using the same books array, use a foreach loop to print every book title. 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region question 17
            //Q17. Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring"
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i=0;i<books.Length;i++)
            //{
            //    if (books[i]== "Refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"{i+1} {books[i]}");
            //}
            #endregion

            #region question 18
            //Q18.Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine($"{i + 1} {books[i]}");
            }
            #endregion

        }
    }
}
