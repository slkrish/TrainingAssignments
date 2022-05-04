using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal struct Books
    {
        private int Book_id;
        public int Bookid
        {
            get { return Bookid; }
            set { Bookid = value; }
        }
        public Books(int Bookid)
        {
            Book_id = Bookid;
        }
        public void display()
        {
            Console.WriteLine("The value of book is = "+Book_id);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Value of Book");
            Books book = new Books(Convert.ToInt32(Console.ReadLine()));
            book.display();
            Console.ReadLine();
        }
    }
}
