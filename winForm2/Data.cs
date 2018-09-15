using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm2
{
    public class Data : INotifyPropertyChanged
    {

        public Data(int number)
        {
            this.paNumber = number;
        }


        private int paNumber;


        public int Number   
        {
            get
            {
                return this.paNumber;
            }
            set
            {
                this.paNumber = value;
                RaisePropertyChanged("Number");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;


        void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }


}
