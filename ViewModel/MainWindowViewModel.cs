using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppMVVMAssignmentProject2.Commands;
using WpfAppMVVMAssignmentProject2.Model;

namespace WpfAppMVVMAssignmentProject2.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            AddCommand = new AddCommand(this);

            Professions.Add("Engineer");
            Professions.Add("Doctor");
            Professions.Add("Clerk");
            Professions.Add("Teacher");
            Professions.Add("Soldier");

        }
        public ICommand AddCommand { get; set; }


        private ObservableCollection<string> _professions = new ObservableCollection<string>();
        public ObservableCollection<string> Professions
        {
            get { return _professions; }
            set { _professions = value; }
        }

        public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person>();
        
        public Person Person { get; set; } = new Person();

        public Person PreparePerson(string name, string profession)
        {
            Person person = new Person();
            person.Name = name;
            person.Profession= profession;

            return person;
        }

        public void Reset()
        {
            Person.Name = string.Empty;
            Person.Profession = string.Empty;
        }

        public void Add()
        {
            Person person = PreparePerson(Person.Name, Person.Profession);
            Persons.Insert(0, person);
            Reset();
        }

        public bool CanAdd()
        {
            if (string.IsNullOrEmpty(Person.Name))
                return false;
            else if (string.IsNullOrEmpty(Person.Profession))
                return false;

            return true;
        }

    }
}
