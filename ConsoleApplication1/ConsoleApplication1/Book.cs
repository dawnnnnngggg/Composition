using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book
    {
        private string Name;
        private double Price;
        private Author[] Authors;
        private int Qty;
        //public Book(string name, Author author, double price, int qty)
        //{
        //    this.Name = name;
        //    this.Author = author;
        //    this.Price = price;
        //    this.Qty = 0;
        //}
        public Book(string name, Author[] authors, double price, int qty = 0)
            //:this(name,author,price)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = qty;
        }
        public string GetName()
        {
            return this.Name;
        }
        public Author[] GetAuthors()
        {
            return this.Authors;
        }
        public double GetPrice()
        {
            return this.Price;
        }
        public int GetQty()
        {
            return this.Qty;
        }
        public void SetPrice(double price)
        {
            this.Price = price;
        }
        public void SetQty(int qty)
        {
            this.Qty = qty;
        }
        public override string ToString()
        {
            string author = "";
            for (int i = 0; i < Authors.Length;i++ )
                author += this.Authors[i].ToString()+",";         
            return String.Format("Book[name={0},author={{{3}}}, price={1}, qty={2}]", this.Name, this.Price, this.Qty, author);
                
        }
        //public string GetAuthorName() { return this.Author.GetName(); }
        //public string GetAuthorEmail() { return this.Author.GetEmail(); }
        //public char GetAuthorGender() { return this.Author.GetGender(); }
    }
    
}
