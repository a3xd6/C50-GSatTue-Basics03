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

            StringBuilder sb= new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);

            #endregion
        }
    }
}
