using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Human> Humans = new ObservableCollection<Human> { };
        public MainWindow()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = Humans;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Human one = new Human(TextBoxName.Text, TextBoxLastName.Text, TextBoxPhone.Text,
                BoxCountry.Text, BoxAge.SelectedDate.ToString());
            if (GenderJ.IsChecked == true)
            {
                one.Gender = "Мужчина";
            }
            else
            {
                one.Gender = "Женщина";
            }
            Humans.Add(one);
        }

        private void DataGrid1_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Human selectedhuman = Humans[DataGrid1.SelectedIndex];
            Binding bindingName = new Binding("Name")
            {
                Source = Humans[DataGrid1.SelectedIndex],
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(TextBoxName, TextBox.TextProperty, bindingName);
            Binding bindingLastName = new Binding("LastName")
            {
                Source = Humans[DataGrid1.SelectedIndex],
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(TextBoxLastName, TextBox.TextProperty, bindingLastName);
            Binding bindingPhone = new Binding("Phone")
            {
                Source = Humans[DataGrid1.SelectedIndex],
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            BindingOperations.SetBinding(TextBoxPhone, TextBox.TextProperty, bindingPhone);
        }
    }
}
