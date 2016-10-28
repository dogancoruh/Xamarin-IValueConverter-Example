using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Forms;

namespace CurrencyEntry
{
    public partial class MainPage : ContentPage
    {
        public static readonly BindableProperty AmountProperty = BindableProperty.Create(nameof(Amount), typeof(decimal), typeof(MainPage), 0m);

        public decimal Amount
        {
            get { return (decimal)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
            Amount = 1000000;
        }
    }
}
