using System.Collections.Generic;
using Xamarin.Forms;
namespace Shpora_Update
{
    public class Commi
    {
        public string Name { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public List<Commi> Commies { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Commies = new List<Commi>
            {
                new Commi {Name ="Самое основное"},
                   new Commi {Name ="Двойные углы"},
                      new Commi {Name ="Синус суммы, косинус разности"},
                         new Commi {Name ="Сумма синусов, разность косинусов"},
                            new Commi {Name ="Тройные углы"}
            };
            this.BindingContext = this;
        }

        private void CommiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Page1 page1 = new Page1();
            Navigation.PushAsync(page1);
            page1.content(e.SelectedItemIndex);
        }
    }
}