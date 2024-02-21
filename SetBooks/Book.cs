using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetBooks
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public EducationClass Education { get; set; } = 0;

        public Book() { 
        
        }
        public Book(string title, string autor, EducationClass education) { 
            Title = title;
            Autor = autor;  
            Education = education;

        }

        public override string ToString()
        {
            return Title + " " + Autor + " " + Education.ToString();
        }

    }

    public enum EducationClass
    {
        Pierwsza = 0,
        Druga = 1,
        Trzecia = 2,

    }
}
