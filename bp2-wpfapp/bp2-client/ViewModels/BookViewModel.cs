using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using bp2_client.Models;

namespace bp2_client.ViewModels
{
    public class Books : ViewModelBase
    {
        ObservableCollection<Book> _books = new();
        Book _newBook = new();
        string _errorMessage = "";
        
        public IDelegateCommand CreateBookCommand { protected set; get; }
        public IDelegateCommand DeleteBookCommand { protected set; get; }

        
        public ObservableCollection<Book> BooksCollection {
            get { return _books; }
            set { SetProperty(ref _books, value); }
        }
        
        public Books()
        {
            CreateBookCommand = new DelegateCommand(ExecuteCreateBooks);
            DeleteBookCommand = new DelegateCommand(ExecuteDeleteBook);

            LoadBooks();
        }

        public Book NewBook
        {
            get => _newBook;
            set => SetProperty(ref _newBook, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        private async void LoadBooks()
        {
            const string url = "https://localhost:7072/api/books";

            HttpClient client = new();

            try
            {
                var response = await client.GetFromJsonAsync<List<Book>>(url);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        _books.Add(item);
                    }
                }
            }
            catch (HttpRequestException)
            {
                ErrorMessage = "Failed to fetch books";
            }
        }

        async void ExecuteCreateBooks(object parameter)
        {
            const string url = "https://localhost:7072/api/books";

            HttpClient client = new();

            try
            {
                var response = await client.PostAsJsonAsync(url, _newBook);

                if (response.IsSuccessStatusCode)
                {
                    _newBook.Title = "";
                    _newBook.Overview = "";

                    var newBook = await client.GetFromJsonAsync<Book>(response.Headers.Location);

                    if (newBook != null)
                    {
                        _books.Add(newBook);
                    }
                }
            }
            catch (HttpRequestException)
            {
                ErrorMessage = "Failed to add book to database";
            }
        }

        async void ExecuteDeleteBook(object id)
        {
            var url = "https://localhost:7072/api/books/" + (int)id;

            HttpClient client = new HttpClient();

            try
            {
                var response = await client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    Book book = _books.First((item) => item.ID == (int)id);

                    _books.Remove(book);
                }
            }
            catch (HttpRequestException)
            {
                ErrorMessage = "Failed to remove todo";
            }
        }
    }
}
