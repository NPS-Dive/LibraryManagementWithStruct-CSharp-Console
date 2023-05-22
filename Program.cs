using System;

namespace Test6_LibraryManagementWithStruct
{
    internal class Program
    {
        static Book[] booksArrayList = new Book[85758575];
        static int count = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("\n---IPBSES.com---\nLibrary Management with Struct in Console\n");


            while (true)
            {
                Console.Write("\nPlease choose one of the following numbers:\n" +
                              "1. Add Book\n" +
                              "2. Edit Book Information\n" +
                              "3. Delete Book Entry\n" +
                              "4. Recover Book Information\n" +
                              "5. Search for Book\n" +
                              "6. Print/show Book Info\n" +
                              "7. Print List of All Books\n" +
                              "8. Exit\n");
                int inputMenu = Convert.ToInt16(Console.ReadLine());

                switch (inputMenu)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        EditBookInfo();
                        break;
                    case 3:
                        DeleteBook();
                        break;
                    case 4:
                        Recovery();
                        break;
                    case 5:
                        SearchBook();
                        break;
                    case 6:
                        PrintBookInfo();
                        break;
                    case 7:
                        PrintAllList();
                        break;
                    case 8:
                        return;
                }
            }
        }

        struct Book
        {
            public String Title;
            public String Author;
            public int ISBN;
            public Boolean delete;
        }

        public static void AddBook()
        {
            Console.Write("Please Enter Book Title: ");
            booksArrayList[count].Title = Console.ReadLine();

            Console.Write("Please Enter Author's Name: ");
            booksArrayList[count].Author = Console.ReadLine();

            Console.Write("Please Enter ISBN: ");
            booksArrayList[count].ISBN = int.Parse(Console.ReadLine().Trim());
            booksArrayList[count].delete = false;
            count++;
        }

        public static void EditBookInfo()
        {
            Console.Write("Please Enter ISBN for Edit book Information: ");
            int searchKey = int.Parse(Console.ReadLine().Trim());
            int token = -1;

            for (int i = 0; i < count; i++)
            {
                if (booksArrayList[i].ISBN == searchKey && booksArrayList[i].delete != true)
                {
                    token = i;
                    Console.Write("Please Enter Edited Title: ");
                    booksArrayList[i].Title = Console.ReadLine();
                    Console.Write("Please Enter Edited Author: ");
                    booksArrayList[i].Author = Console.ReadLine();
                }
            }

            if (token == -1)
            {
                Console.WriteLine("Pardon! There is no book with ISBN '" + searchKey + "'");
            }
            else
            {
                Console.WriteLine("Edited Information of the Book with ISBN '" + searchKey + "', Book Title: '" +
                                  booksArrayList[token].Title + "', & Author: '" + booksArrayList[token].Author + "'");
            }
        }

        public static void DeleteBook()
        {
            Console.Write("Please Enter ISBN for Delete book Information: ");
            int searchKey = int.Parse(Console.ReadLine().Trim());
            int token = -1;

            for (int i = 0; i < count; i++)
            {
                if (booksArrayList[i].ISBN == searchKey && booksArrayList[i].delete != true)
                {
                    token = i;
                    booksArrayList[i].delete = true;
                }
            }

            if (token == -1)
            {
                Console.WriteLine("Pardon! There is no book with ISBN '" + searchKey + "'");
            }
            else
            {
                Console.WriteLine("Information of the Book with ISBN '" + searchKey + "', Book Title: '" +
                                  booksArrayList[token].Title + "', & Author: '" + booksArrayList[token].Author +
                                  "' has been deleted successfully!");
            }
        }

        public static void Recovery()
        {
            Console.Write("Please Enter ISBN for Delete book Information: ");
            int searchKey = int.Parse(Console.ReadLine().Trim());
            int token = -1;

            for (int i = 0; i < count; i++)
            {
                if (booksArrayList[i].ISBN == searchKey)
                {
                    token = i;
                    booksArrayList[i].delete = false;
                }
            }

            if (token == -1)
            {
                Console.WriteLine("Pardon! There is no book with ISBN '" + searchKey + "'");
            }
            else
            {
                Console.WriteLine("Information of the Book with ISBN '" + searchKey + "', Book Title: '" +
                                  booksArrayList[token].Title + "', & Author: '" + booksArrayList[token].Author +
                                  "' has been restored successfully!");
            }
        }

        public static void SearchBook()
        {
            Console.Write("Please Enter ISBN for search book: ");
            int searchKey = int.Parse(Console.ReadLine().Trim());
            int token = -1;

            for (int i = 0; i < count; i++)
            {
                if (booksArrayList[i].ISBN == searchKey && booksArrayList[i].delete != true)
                {
                    token = i;
                }
            }

            if (token == -1)
            {
                Console.WriteLine("Pardon! There is no book with ISBN '" + searchKey + "'");
            }
            else
            {
                Console.WriteLine("Found Book with ISBN '" + searchKey + "', Book Title: '" +
                                  booksArrayList[token].Title + "', & Author: '" + booksArrayList[token].Author + "'");
            }
        }

        public static void PrintBookInfo()
        {
            Console.Write("Please Enter ISBN for print book Information: ");
            int searchKey = int.Parse(Console.ReadLine().Trim());
            int token = -1;

            for (int i = 0; i < count; i++)
            {
                if (booksArrayList[i].ISBN == searchKey && booksArrayList[i].delete != true)
                {
                    token = i;
                }
            }

            if (token == -1)
            {
                Console.WriteLine("Pardon! There is no book with ISBN '" + searchKey + "'");
            }
            else
            {
                Console.WriteLine("Information of Book with ISBN '" + searchKey + "': --> Book Title: '" +
                                  booksArrayList[token].Title + "', & Author: '" + booksArrayList[token].Author + "'");
            }
        }

        public static void PrintAllList()
        {
            for (int i = 0; i < count; i++)
            {
                if (booksArrayList[i].delete != true)
                {
                    Console.WriteLine("\nNumber [" + (i + 1) + "]: Title: '" + booksArrayList[i].Title +
                                      "', Author: '" + booksArrayList[i].Author + "', & ISBN '" +
                                      booksArrayList[i].ISBN +
                                      "'\n");
                }
            }
        }
    }
}