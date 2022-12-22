using ElevatorSystemConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace elevatorFront
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ElevatorManager elevatorManager = new ElevatorManager(1);
        public MainWindow()
        {
            
            InitializeComponent();
        }



        private void startElevator_Click(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(500);
            elevatorManager.MakeStep();
            if (elevatorManager.elevators[0].currentFloor==4)
            {
                ElevatorFrame0.Fill = Brushes.Blue;
            }
            

        }

        private void floor0down_clik(object sender, RoutedEventArgs e)
        {
            if(floor0CheckBox.IsChecked==true)
            {
                floor0down.Content = "XD";
            }
        }

        private void floor0up_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor1down_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor1up_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor2down_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor2up_Click(object sender, RoutedEventArgs e)
        {
            if(floor4CheckBox.IsChecked==true)
            {
                elevatorManager.AddRequestFromButton(2, 4);
            }
        }

        private void floor3down_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor3up_Click(object sender, RoutedEventArgs e)
        {

        }
        private void floor4down_Click(object sender, RoutedEventArgs e)
        {

        }
        private void floor4up_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor0CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor1CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor2CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor3CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void floor4CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
