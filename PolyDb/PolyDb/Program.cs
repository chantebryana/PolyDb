using System;

namespace PolyDb
{
    public abstract class DbConnection
    {
        //properties
        //ConnectionString : string
        //Timeout : TimeSpan

        //DbConnection(ConnectionString )
        //{
        //    ConnectionString = " ";
        //}

        public abstract void Opening();
    }

    public class SqlConnection : DbConnection
    {
        public override void Opening()
        {
            Console.WriteLine("Opening SQL Database");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var timeTest = new TimeSpan(5, 6, 22);
            Console.WriteLine(timeTest.ToString());
            string stringTest = "abc";
            Console.WriteLine(stringTest);

            var db = new SqlConnection();
            db.Opening();
        }
    }
}
