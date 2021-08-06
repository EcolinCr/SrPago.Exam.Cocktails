using SrPago.Examem.Cocktails.DataAccess.Implementation;
using SrPago.Examen.Cocktails.ViewModel.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SrPago.Examen.Cocktails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void search_Cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = search_Cmb.SelectedIndex;
            var result = new CocktailViewModel().GetListFilters(selection);
            var names = result.drinks.Select(x => x.str).ToList();
            list_listBx.ItemsSource = names;
        }
    }
}
