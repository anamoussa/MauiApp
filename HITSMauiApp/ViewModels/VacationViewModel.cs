using HITSMauiApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HITSMauiApp.ViewModels
{
       public class VacationViewModel : INotifyPropertyChanged
         {
        readonly IList<Vacation> source;
        Vacation selectedVacation;

        public ObservableCollection<Vacation> Vacations { get; private set; }

        public Vacation SelectedVacation
        {
            get
            {
                return selectedVacation;
            }
            set
            {
                if (selectedVacation != value)
                {
                    selectedVacation = value;
                }
            }
        }

        public ICommand DeleteCommand => new Command<Vacation>(RemoveVacation);
        public ICommand FavoriteCommand => new Command<Vacation>(FavoriteVacation);

        public VacationViewModel()
        {
            source = new List<Vacation>();
            CreateVacationCollection();

            SelectedVacation = Vacations.Skip(3).FirstOrDefault();
            OnPropertyChanged("SelectedVacation");

        }

        void CreateVacationCollection()
        {


            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });
            source.Add(new Vacation { tybe = "annual Leave", from = DateOnly.MaxValue, to = DateOnly.MaxValue, noOfDays = 2, category = "annual", Details = "no details to show" });

            Vacations = new ObservableCollection<Vacation>(source);
        }

        void RemoveVacation(Vacation Vacation)
        {
            if (Vacations.Contains(Vacation))
            {
                Vacations.Remove(Vacation);
            }
        }

        void FavoriteVacation(Vacation Vacation)
        {
            Vacation.IsFavorite = !Vacation.IsFavorite;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }


}
