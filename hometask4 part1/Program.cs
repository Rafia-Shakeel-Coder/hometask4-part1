using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask4_part1
{
   
        public class Book
        {
       
            public String title;
            public String author;
            public String isbn;
            public double price;

        
  public void Displaybookinfo()
        {
            Console.WriteLine("TITLE {0}",title);
            Console.WriteLine("AUTHOR {0}",author);
            Console.WriteLine("ISBN {0}",isbn);
            Console.WriteLine("PRICE {0}",price);
        }
         public void ApplyDiscount(double percentage)
        {
            double discountAmount = price * (percentage / 100);
            price -= discountAmount;
            Console.WriteLine("AFTER APPLYING DISCOUNT {0},{1}",price,discountAmount);
        }


        }
        internal class Program
        {
            static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "THE ATOMIC HABITS ";
            book.author = "JAMES CLEAR";
            book.isbn = "987627";
            book.price = 2500;
            //call the functions in main
            Console.WriteLine("BOOK INFORMATION");
            book.Displaybookinfo();
            Console.WriteLine("APPLIED DISCOUNT OF 10% on book");
            book.ApplyDiscount(10);
            Console.WriteLine("UPDATED INFORMATION OF BOOK AFTER APPLYING DISCOUNT ");
            book.Displaybookinfo();

        }
    }
}
