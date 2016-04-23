using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace HeadlessClient.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        public LibraryViewModel()
        {
            List<string> test = new List<string>();
            test.Add("Link 1");
            test.Add("Link 2");
            test.Add("Link 3");
            Experiences = test;
        }

        public const string ExperiencesPropertyName = "Experiences";
        private List<string> _experiences;
        public List<string> Experiences
        {
            get
            {
                return _experiences;
            }

            set
            {
                if (_experiences == value)
                {
                    return;
                }

                _experiences = value;
                RaisePropertyChanged(ExperiencesPropertyName);
            }
        }
    }
}