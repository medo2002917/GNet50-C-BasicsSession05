namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region Question 01

            // Console.WriteLine(book.password);

            // Compilation Error:
            // password is inaccessible due to
            // its protection level.

            // Private members can only be accessed
            // inside their containing class.

            #endregion

            #region Question 02

            Console.WriteLine(book.copiesInStock);

            // Internal members can be accessed
            // within the same assembly.

            #endregion

            #region Question 03

            book.Title = "Clean Code";

            Console.WriteLine(book.Title);

            #endregion

            #region Question 04

            book.Genre = Genre.Science;

            Console.WriteLine(book.Genre);

            #endregion

            #region Question 05

            Console.WriteLine((int)Genre.Fiction);

            Console.WriteLine((int)Genre.NonFiction);

            Console.WriteLine((int)Genre.Science);

            #endregion

            #region Question 06

            int genreNumber = 1;

            Genre genre = (Genre)genreNumber;

            Console.WriteLine(genre);

            #endregion

            #region Question 07

            genre = Genre.Fiction;

            string genreText = genre.ToString();

            Console.WriteLine(genreText);

            #endregion

            #region Question 08

            genreText = "Science";

            genre = (Genre)Enum.Parse(typeof(Genre), genreText);

            Console.WriteLine(genre);

            #endregion

            #region Question 09

            genreText = "Mystery";

            bool isParsed = Enum.TryParse(genreText, out genre);

            if (isParsed)
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

            #endregion
        }
    }
}
