using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstProject.ViewViewModel.ListView.ListViewNames
{
    public class ListViewNamesViewModel : BaseViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        private List<Person> _person;

        public ListViewNamesViewModel()
        {
            Title = Titles.ListViewNamesTitle;
            Persons = new ObservableCollection<Person>();
            _person = Person.GetName();
            this.LoadPersons();
        }

        private void LoadPersons()
        {
            try
            {
                Persons.Clear();
                foreach(var p in _person)
                {
                    Persons.Add(p);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}