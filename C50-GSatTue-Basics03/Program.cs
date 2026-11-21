using System.Globalization;
using System.Text;

namespace C50_GSatTue_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // 1]------------------

            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);

            #endregion

            #region Question 2
            // 2]-------------------

            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(str1,str2));

            #endregion

            #region Question 3
            // 3]---------------

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);

            #endregion

            #region Question 4
            // 4]----------------
            // شيل الكومنت عن السؤال الي فات كمان معاه علشان بكمل عليه

            //sb.Replace("Book List", "Libraray");
            //Console.WriteLine(sb);


            #endregion

            #region Question 5
            // 5]----------------

            //string title = "CLean Code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + ", " + "Pages: " + pages);

            #endregion

            #region Question 6
            // 6]---------------

            //string title = "CLean Code";
            //int pages = 464;
            //Console.WriteLine($"Book: {title}, Pages: {pages}");

            #endregion

            #region Question 7
            // 7]----------------

            //string title = "CLean Code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book: {0}, Pages: {1}",title,pages));

            #endregion

            #region Question 8
            // 8]-----------------

            //int pages = 464;
            //if(pages>300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");

            #endregion

            #region Question 9
            // 9]---------------

            //int pages = 464;
            //bool isAvailable = false;
            //if(pages>300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            //else
            //    Console.WriteLine("You cannot");

            #endregion

            #region Question 10
            // 10]-------------------

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case ("Clean Code"):
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case ("Refactoring"):
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            #endregion

            #region Question 11
            // 11]------------------

            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            #endregion

            #region Question 12
            // 12]------------------

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. {books[i]}");
            //}

            #endregion

            #region Question 13
            // 13]------------------

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i=0;
            //while (i<books.Length)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //    i++;
            //}

            #endregion

            #region Question 14
            // 14]----------------

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i<3);

            #endregion

            #region Question 15
            // 15]-------------

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int count = 1;
            //foreach (string book in books)
            //{
            //    Console.WriteLine($"{count}. {book}");
            //    count++;
            //}

            #endregion

            #region Question 16
            // 16]-----------------

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //        break;
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}

            #endregion

            #region Question 17
            // 17]---------------------

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int count = 1;
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine($"{count}. {books[i]}");
            //    count++;
            //}

            #endregion

            #region Question 18
            // 18]--------------------

            //PrintFirstBook();

            #endregion


        }

        #region Question 18 (function)
        // 18]---------------

        //public static void PrintFirstBook()
        //{
        //    string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //    if (books.Length == 0)
        //        return;
        //    else
        //        Console.WriteLine(books[0]);
        //}

        #endregion
    }
}
