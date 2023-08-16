using EF_PR_3.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_PR_3
{
    public partial class Form1 : Form
    {
        private AuthorsRepository repository;

        public Form1()
        {
            InitializeComponent();
            cmbBox_SearchType.SelectedIndex = 0;
            using (repository = new AuthorsRepository())
            {
                lstBox_AllAuthors.DataSource = repository.GetAll();
            }
        }

        private void btn_AddAuthor_Click(object sender, EventArgs e)
        {
            using (repository = new AuthorsRepository())
            {
                if (txtBox_AuthorName.Text == string.Empty || txtBox_AuthorSurname.Text == string.Empty)
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Author author = new Author { FirstName = txtBox_AuthorName.Text, LastName = txtBox_AuthorSurname.Text };
                    repository.Create(author);
                    lstBox_AllAuthors.DataSource = repository.GetAll();
                    txtBox_AuthorName.Text = string.Empty;
                    txtBox_AuthorSurname.Text = string.Empty;
                }
            }
        }

        private void lstBox_AllAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author author = lstBox_AllAuthors.SelectedItem as Author;
            txtBox_AuthorNameUpd.Text = author.FirstName;
            txtBox_AuthorSurnameUpd.Text = author.LastName;
            lstBox_AuthorBooks.Items.Clear();
            using (repository = new AuthorsRepository())
            {
                foreach (var item in repository.GetAuthorsBooks())
                {
                    if (item.Key == author.Id)
                    {
                        foreach (var item1 in item.Value.Books)
                        {
                            string bookInfo = $"{item1.Name}";
                            lstBox_AuthorBooks.Items.Add(bookInfo);
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (repository = new AuthorsRepository())
            {
                if (txtBox_AuthorNameUpd.Text == string.Empty || txtBox_AuthorSurnameUpd.Text == string.Empty)
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Author author = lstBox_AllAuthors.SelectedItem as Author;
                    author.FirstName = txtBox_AuthorNameUpd.Text;
                    author.LastName = txtBox_AuthorSurnameUpd.Text;
                    repository.Update(author);
                    lstBox_AllAuthors.DataSource = repository.GetAll();
                    txtBox_AuthorNameUpd.Text = string.Empty;
                    txtBox_AuthorSurnameUpd.Text = string.Empty;
                }
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            switch (cmbBox_SearchType.SelectedIndex)
            {
                case 0:
                    if (txtBox_SearchValue.Text == string.Empty)
                        MessageBox.Show("Значение для поиска не было введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (!int.TryParse(txtBox_SearchValue.Text, out int result))
                    {
                        MessageBox.Show("Введенное значение не является числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        using (repository = new AuthorsRepository())
                        {

                            if (repository.GetById(result) != null)
                                lstBox_SearchedAuthors.Items.Add(repository.GetById(int.Parse(txtBox_SearchValue.Text)));
                            else
                                MessageBox.Show("Ничего не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    break;
                case 1:
                    if (txtBox_SearchValue.Text == string.Empty)
                        MessageBox.Show("Значение для поиска не было введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        using (repository = new AuthorsRepository())
                        {
                            if (repository.GetBySurname(txtBox_SearchValue.Text).FirstOrDefault() != null)
                                lstBox_SearchedAuthors.DataSource = repository.GetBySurname(txtBox_SearchValue.Text);
                            else
                                MessageBox.Show("Ничего не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    break;
            }
        }
    }
}
