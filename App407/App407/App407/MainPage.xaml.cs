using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App407
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            TestViewModel model = new TestViewModel();

            this.BindingContext = model;
        }
    }

    public class RoundPicker : Picker {


    }

    public class TestViewModel : INotifyPropertyChanged
    {
        public string BedsAmount { get; set; }
        public string MaxPrice { get; set; }
        public List<MaxPriceModel> MaxPriceList { get; set; }
        public List<Beds> BedsList { get; set; }
        private Beds _bedType;
        public Beds BedSelected
        {
            get
            {
                return _bedType;
            }
            set
            {
                if (_bedType != value)
                {
                    _bedType = value;

                    if (_bedType != null)
                    {

                        BedsAmount = _bedType.Name;

                        if (PropertyChanged != null)
                        {
                            PropertyChanged(this, new PropertyChangedEventArgs("BedSelected"));
                        }
                    }
                }
            }
        }
        private MaxPriceModel _maxPriceSelected;

        public event PropertyChangedEventHandler PropertyChanged;

        public MaxPriceModel MaxPriceSelected
        {
            get
            {
                return _maxPriceSelected;
            }
            set
            {
                if (_maxPriceSelected != value)
                {
                    _maxPriceSelected = value;

                    if (_maxPriceSelected != null)
                    {

                        MaxPrice = _maxPriceSelected.maxPrice;


                        if (PropertyChanged != null)
                        {
                            PropertyChanged(this, new PropertyChangedEventArgs("MaxPriceSelected"));
                        }
                    }
                }
            }
        }

        public class Beds
        {
            public string Name { get; set; }
        }

        public TestViewModel()
        {
            BedsList = GetBeds();
            MaxPriceList = GetMaxPrice();
        }

        public List<MaxPriceModel> GetMaxPrice()
        {
            var maxprice = new List<MaxPriceModel>()
      {
          new MaxPriceModel(){maxPrice = "100 000"},
          new MaxPriceModel(){maxPrice = "200 000"},
          new MaxPriceModel(){maxPrice = "300 000"},
          new MaxPriceModel(){maxPrice = "400 000"},
          new MaxPriceModel(){maxPrice = "500 000"},
          new MaxPriceModel(){maxPrice = "600 000"},
          new MaxPriceModel(){maxPrice = "700 000"},
          new MaxPriceModel(){maxPrice = "800 000"},
          new MaxPriceModel(){maxPrice = "900 000"},
          new MaxPriceModel(){maxPrice = "1 000 000"},
      };
            return maxprice;
        }
        public List<Beds> GetBeds()
        {
            var beds = new List<Beds>()
        {
            new Beds() { Name = "1" },
            new Beds() { Name = "2" },
            new Beds() { Name = "3" },
            new Beds() { Name = "4" },
            new Beds() { Name = "5" },
            new Beds() { Name = "6" },
            new Beds() { Name = "7" },
            new Beds() { Name = "8" },
            new Beds() { Name = "9" },
            new Beds() { Name = "10" },
        };
            return beds;
        }
    }

    public class MaxPriceModel
    {
        public string maxPrice { get; set; }
    }
}
