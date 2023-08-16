using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace EF_PR_3.Models
{
    internal class AuthorsRepository : IRepository<Author>, IDisposable
    {
        SqlConnection connection = null;

        public AuthorsRepository()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
        }


        public int Create(Author obj)
        {
            string sql = "INSERT INTO Authors(FirstName, LastName) VALUES (@FirstName, @LastName)";
            return connection.Execute(sql, obj);
        }

        public int Delete(Author obj)
        {
            string sql = "DELETE FROM Authors WHERE ID = @Id";
            return connection.Execute(sql, obj);
        }

        public void Dispose() => connection?.Dispose();

        public List<Author> GetAll()
        {
            string sql = "SELECT * FROM Authors";
            var authors = connection.Query<Author>(sql).ToList();
            return authors;
        }

        public Author GetById(int id)
        {
            string sql = "SELECT * FROM Authors WHERE Id = @Id";
            Author author = connection.QueryFirstOrDefault<Author>(sql, new { Id = id });
            return author;
        }

        public List<Author> GetBySurname(string searchingSurname)
        {
            string sql = "SELECT * FROM Authors WHERE LastName = @LastName";
            var authors = connection.Query<Author>(sql, new { LastName = searchingSurname }).ToList();
            return authors;
        }

        public int Update(Author obj)
        {
            string sql = "UPDATE Authors SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id";
            return connection.Execute(sql, obj);
        }
        public Dictionary<int, Author> GetAuthorsBooks()
        {
            var query = "SELECT * FROM Authors JOIN Books ON Authors.Id = Books.Id_Author";

            var authors = new Dictionary<int, Author>();

            var result = connection.Query<Author, Book, Author>(
                query,
                (author, book) => {

                    Author authorEntry;

                    if (!authors.TryGetValue(author.Id, out authorEntry))
                    {
                        authors.Add(author.Id, author);
                        author.Books = new List<Book>();
                        authorEntry = author;
                    }

                    authorEntry.Books.Add(book);

                    return authorEntry;
                },
                splitOn: "Id"
                );
            return authors;
        }
    }
}
