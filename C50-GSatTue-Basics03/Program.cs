using System.Security.Cryptography;
using System.Threading.Channels;

namespace C50_GSatTue_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Q1. Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            string Title= "clean code";
            string UpperTitle = Title.ToUpper();
            Console.WriteLine(Title);
            Console.WriteLine(UpperTitle);
            #endregion
        }
    }
}
