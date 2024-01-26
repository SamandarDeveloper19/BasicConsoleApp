namespace BasicConsoleApp.Classes
{
    class Book
    {
        string bookName;
        string authorName;

        public string BookName
        {
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            }
        }
        public string AuthorName
        {
            get
            {
                return authorName;
            }
            set
            {
                authorName = value;
            }
        }
        public int Price { get; set; } //the price of book is changeable

        public Book(string bookName, string authorName)
        {
            this.bookName = bookName;
            this.authorName = authorName;
        }

        public void Information()
        {
            Console.WriteLine(
                $"Name of book is {BookName}, name of author is {AuthorName}, price of book is {Price}");
        }
    }
}