using System.Collections.Generic;

namespace EF_PR_3.Models
{
    class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }

        public override string ToString() => $"{Id}:  {FirstName}  {LastName}";
    }
}
