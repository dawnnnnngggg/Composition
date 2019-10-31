using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Author
    {
        private string Name, Email;
        private char Gender;
        public Author(string name, string email, char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public char GetGender()
        {
            return this.Gender;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }
        public override string ToString()
        {
            return String.Format("Author[name={0}, email={1}, gender={2}]", this.Name, this.Email, this.Gender);
        }
    }
}
