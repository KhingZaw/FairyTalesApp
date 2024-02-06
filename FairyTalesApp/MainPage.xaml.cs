using FairyTalesApp.Model;
using System.Collections.ObjectModel;

namespace FairyTalesApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FairyTales> FairyTale { get; set; }
        public ObservableCollection<FairyTales> FairyTale1 {  get; set; }


        public MainPage()
        {
            InitializeComponent();
            InitializeTales();
            BindingContext = this;
        }

        private void InitializeTales()
        {
            FairyTale = new ObservableCollection<FairyTales>
            {
                new FairyTales {Name = "Cinderella",ReadTime = new TimeSpan(0,30,0),Image="cinderella.jpg"},
                new FairyTales {Name = "Snow White",ReadTime = new TimeSpan(0,30,0),Image="snow.jpg"},
                new FairyTales {Name = "Rapunzel",ReadTime = new TimeSpan(0,30,0),Image="rapunzel.jpg"},
                new FairyTales {Name = "Litte Red Ridding Hood",ReadTime = new TimeSpan(0,30,0),Image="hood.jpg"},    
                new FairyTales {Name = "Beauty and the Beast",ReadTime = new TimeSpan(0,30,0),Image="beauty.jpg"}
            
            };
            FairyTale1 = new ObservableCollection<FairyTales>
            {
                new FairyTales {Name = "Snow White", ReadTime = new TimeSpan (0,30,0),Image= "snow.jpg"},
                new FairyTales {Name = "Rapunzel", ReadTime = new TimeSpan (0,30,0),Image= "rapunzel.jpg"},
                new FairyTales {Name = "Cinderella", ReadTime = new TimeSpan (0,30,0),Image= "cinderella.jpg"},
                new FairyTales {Name = "Beauty and the Beast", ReadTime = new TimeSpan (0,30,0),Image= "beauty.jpg"},
                new FairyTales {Name = "Litte Red Ridding Hood", ReadTime = new TimeSpan (0,30,0),Image= "hood.jpg"}
            
            };
        }
    }
}