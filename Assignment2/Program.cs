using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Assignment2
{
    internal class Program
    {
        //Question 18
        static void PrintFirstBook(string[] books)
        {
            if(books.Length== 0) return;
            Console.WriteLine(books[0]);
        }
        static void Main(string[] args)
        {
            #region Question 1
          //  1.Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
          // both title and upperTitle to show that title did not change.
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Upper Title: {upperTitle}");


            #endregion

        }
    }
}
