﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shpora_Update
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        public void content(int temp)
        {
            switch (temp)
            {
                case 0:
                    one.IsVisible = true;
                    break;
                case 1:
                    two.IsVisible = true;
                    break;
                case 2:
                    three.IsVisible = true;
                    break;
                case 3:
                    four.IsVisible = true;
                    break;
                case 4:
                    five.IsVisible = true;
                    break;
            }
        }
    }
}