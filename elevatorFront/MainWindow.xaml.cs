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


        public void colorElevator(int floor)
        {
            ElevatorFrame0.Fill = Brushes.White;
            ElevatorFrame1.Fill = Brushes.White;
            ElevatorFrame2.Fill = Brushes.White;
            ElevatorFrame3.Fill = Brushes.White;
            ElevatorFrame4.Fill = Brushes.White;

            if (floor == 0)
            {
                ElevatorFrame0.Fill = Brushes.Blue;
            }
            if(floor == 1)
            {
                ElevatorFrame1.Fill = Brushes.Blue;
            }
            if(floor==2)
            {
                ElevatorFrame2.Fill = Brushes.Blue;
            }
            if (floor == 3)
            {
                ElevatorFrame3.Fill = Brushes.Blue;
            }
            if (floor == 4)
            {
                ElevatorFrame4.Fill = Brushes.Blue;
            }
        }
        private void startElevator_Click(object sender, RoutedEventArgs e)
        {
            colorElevator(elevatorManager.elevators[0].currentFloor);
            Thread.Sleep(500);
            elevatorManager.MakeStep();
            

        }

        private void floor0down_clik(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 4);
            }
        }

        private void floor0up_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(0, 4);
            }
        }

        private void floor1down_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 4);
            }
        }

        private void floor1up_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(1, 4);
            }
        }

        private void floor2down_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 4);
            }
        }

        private void floor2up_Click(object sender, RoutedEventArgs e)
        {
            if(floor0CheckBox.IsChecked==true)
            {
                elevatorManager.AddRequestFromButton(2, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(2, 4);
            }



        }

        private void floor3down_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 4);
            }
        }

        private void floor3up_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(3, 4);
            }
        }
        private void floor4down_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 4);
            }
        }
        private void floor4up_Click(object sender, RoutedEventArgs e)
        {
            if (floor0CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 0);
            }
            if (floor1CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 1);
            }
            if (floor2CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 2);
            }
            if (floor3CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 3);
            }
            if (floor4CheckBox.IsChecked == true)
            {
                elevatorManager.AddRequestFromButton(4, 4);
            }
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
