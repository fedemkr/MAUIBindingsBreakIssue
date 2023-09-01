using System;
using System.ComponentModel;

namespace BindingNullIssue
{
    public class Person
    {
        public bool IsVisible { get; set; }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        Person _person;

        public MainViewModel()
		{
		}

        public string Title => "This is a title";

        public Person Person => _person;

        public bool IsTitleVisible => _person.IsVisible;

        public bool IsTitleVisibleThatThrowsDirectly => throw new Exception("Whoops!");

        public string Subtitle => "the subtitle"; // this won't be considered when binding IsTitleVisible or IsTitleVisibleThatThrowsDirectly but yes if binding Person.IsVisible

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

