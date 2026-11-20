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
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"Title: {title}");
            //Console.WriteLine($"Upper Title: {upperTitle}");


            #endregion
            #region Question 2
            //2.Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            //to check if they point to the same object in memory.
            //string s1 = "Clean Code";
            //string s2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(s1, s2));
            #endregion

            #region Question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            //object.Print the final result.
            //StringBuilder sb = new StringBuilder("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);

            #endregion

            #region Question 4
            //4.Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". 
            // Print the result.
            //stringbuilder sb = new stringbuilder("book list");
            //sb.replace("book list", "library");
            //Console.WriteLine(sb);


            #endregion

            #region Question 5
            //5.Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
            // Pages: 464" using the + operator. 
            string title = "clean code";
            int pages = 464;
            Console.WriteLine("book: " + title + " ,pages: " + pages);
            #endregion

        }
    }
}
