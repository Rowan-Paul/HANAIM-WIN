using System;
using System.Linq;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using bp2_client.Models;

namespace bp2_client.ViewModels
{
    public class Books : ViewModelBase
    {
        private ObservableCollection<Book> _books = new();
        private Book _newBook = new();
        private string _errorMessage = "";
        private string _infoMessage = "";
        private const string ApiUrl = "https://localhost:7072/";

        public IDelegateCommand CreateBookCommand { protected set; get; }
        public IDelegateCommand DeleteBookCommand { protected set; get; }


        public ObservableCollection<Book> BooksCollection
        {
            get => _books;
            set => SetProperty(ref _books, value);
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
        public string InfoMessage
        {
            get => _infoMessage;
            set => SetProperty(ref _infoMessage, value);
        }

        private async void LoadBooks()
        {
            const string url = ApiUrl + "api/books";

            HttpClient client = new();

            try
            {
                var response = await client.GetFromJsonAsync<List<Book>>(url);

                if (response != null || response.Count > 0)
                {
                    _books.Clear();
                    foreach (var item in response)
                    {
                        _books.Add(item);
                    }
                }
                else
                {
                    throw new HttpRequestException();
                }
            }
            catch (HttpRequestException)
            {
                InfoMessage = "";
                ErrorMessage = "Failed to fetch books";
            }
        }

        private async void ExecuteCreateBooks(object parameter)
        {
            const string url = ApiUrl + "api/books";

            HttpClient client = new();

            try
            {
                if (string.IsNullOrEmpty(_newBook.Title) || string.IsNullOrEmpty(_newBook.Overview))
                {
                    throw new HttpRequestException();
                }

                var response = await client.PostAsJsonAsync(url, _newBook);

                if (response.IsSuccessStatusCode)
                {
                    _newBook.Title = "";
                    _newBook.Overview = "";
                    ErrorMessage = "";
                    InfoMessage = "Added book";
                    OnPropertyChanged(NewBook.Title);
                    OnPropertyChanged(NewBook.Overview);

                    LoadBooks();
                }
                else
                {
                    throw new HttpRequestException();
                }
            }
            catch (HttpRequestException)
            {
                InfoMessage = "";
                ErrorMessage = "Failed to add book to database";
            }
        }

        async void ExecuteDeleteBook(object id)
        {
            var url = ApiUrl + "api/books/" + (int) id;

            HttpClient client = new HttpClient();

            try
            {
                var response = await client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    ErrorMessage = "";
                    InfoMessage = "Deleted book";
                    LoadBooks();
                }
            }
            catch (HttpRequestException)
            {
                InfoMessage = "";
                ErrorMessage = "Failed to remove todo";
            }
        }
    }
}