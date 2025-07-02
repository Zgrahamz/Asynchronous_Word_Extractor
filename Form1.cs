using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchronous_Word_Extractor
{
    public partial class BookWordListerForm : Form
    {
        public BookWordListerForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e) => Close();
        //Zach Graham
        private async void submitBtn_Click(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            var book1 = openFileDialog1.FileName;
            var book2 = openFileDialog2.FileName;

            var wordtask = ListBookWords(book1, book2);
            tasks.Add(wordtask);

            await Task.WhenAll(tasks);

            submitBtn.Enabled = false;

            if (string.IsNullOrWhiteSpace(selectedBook1.Text) || string.IsNullOrWhiteSpace(selectedBook2.Text))
            {
                MessageBox.Show("Please use the browse buttons to select books to display.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else
            {
                submitBtn.Enabled = true;
            }
        }
        //Zach Graham
        private async Task ListBookWords(string book1, string book2)
        {
            await Task.WhenAll(
                ProcessBookAsync(book1, displayBook1),
                ProcessBookAsync(book2, displayBook2)
            );
        }
        //Zach Graham
        private async Task ProcessBookAsync(string bookPath, RichTextBox displayBox)
        {
            if (string.IsNullOrWhiteSpace(bookPath)) return;

            var lines = await Task.Run(() => System.IO.File.ReadAllLines(bookPath));
            var noPunctLines = lines.Where(word => !string.IsNullOrWhiteSpace(word))
                .AsParallel()
                .Select(x => x.ToLower().Trim()
                    .Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "")
                    .Replace("!", "").Replace("?", "").Replace("\"", "").Replace("'", "")
                    .Replace("(", "").Replace(")", ""));
            var filteredLines = noPunctLines.SelectMany(word => word.Split(' '));
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            filteredLines.ToList().ForEach(word =>
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount.Add(word, 1);
            });

            var cutoff = wordCount.Where(word => !string.IsNullOrWhiteSpace(word.Key))
                .OrderByDescending(word => word.Value)
                .Take(10);

            displayBox.Clear();
            foreach (var word in cutoff)
            {
                displayBox.AppendText($"{word.Key}: {word.Value}{Environment.NewLine}");
            }
        }

        private void browseBtn1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedBook1.Text = openFileDialog1.FileName.Split('\\').LastOrDefault();
            }
        }

        private void browseBtn2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedBook2.Text = openFileDialog2.FileName.Split('\\').LastOrDefault();
            }
        }
    }
}
