using System;

namespace PolyDb
{
    public abstract class DbConnection
    {
        private string ConnectionString;
        private TimeSpan Timeout;

        public DbConnection()
        {
            ConnectionString = " ";
        }

        public abstract void Opening();
        public abstract void Closing();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection() : base()
        {

        }

        public override void Opening()
        {
            Console.WriteLine("Opening SQL Database");
        }

        public override void Closing()
        {
            Console.WriteLine("Closing SQL Database");
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

            var sql = new SqlConnection();
            sql.Opening();
        }
    }
}
