using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06_2
{
     //-------Books-----//
    struct Books
    {
        public string Name;
        private int BookId { get; set; }

        public int BookID
        {
            get
            {
                return BookId;
            }
            set
            {
                BookId = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Book Id Is :{0}", BookId);
            Console.WriteLine("Book name is :{0}", Name);
        }


    }
    class StructEg1
    {
        static void Main()
        {
            Books book = new Books();
            book.BookID = 0007;
            book.Name = "Atomic Habits";
            book.Display();
            Console.ReadLine();
        }
    }
}
