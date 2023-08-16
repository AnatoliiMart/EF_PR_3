namespace EF_PR_3.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearPress { get; set; }

        public int id_Author { get; set; }
    }
}
