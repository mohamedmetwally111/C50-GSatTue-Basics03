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
            string Title= "Clean Code";
            int pages = 464;
            string result = "Book: " + Title + ", Pages: " + pages;
            Console.WriteLine(result);
            #endregion

        }
    }
}
