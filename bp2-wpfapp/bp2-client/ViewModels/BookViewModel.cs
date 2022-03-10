using System;
using System.ComponentModel;
using bp2_client.Models;

sealed class MyViewModel : INotifyPropertyChanged
{
    private Book _book;
    
    public string Title { 
        get {return _book.Title;} 
        set {
            if(_book.Title != value) {
                _book.Title = value;
                OnPropertyChange("Title");
            }
        }
    }

    public string Overview {
        get { return _book.Overview; }
        set {
            if (_book.Overview != value) {
                _book.Overview = value;
                OnPropertyChange("Overview");
            }
        }
    }

    public MyViewModel() {
        _book = new Book {
            ID = 1,
            Title = "Dune",
            Overview = "Fear is the mind killer",
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChange(string propertyName) {
        if(PropertyChanged != null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}