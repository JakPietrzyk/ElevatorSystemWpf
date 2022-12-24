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
            Brush brush = Brushes.Blue;
            if (elevatorManager.elevators[0].nextFloor == floor)
            {
                brush = Brushes.Red;
            }
            if (floor == 0)
            {
                ElevatorFrame0.Fill = brush;
            }
            if(floor == 1)
            {
                ElevatorFrame1.Fill = brush;
            }
            if(floor==2)
            {
                ElevatorFrame2.Fill = brush;
            }
            if (floor == 3)
            {
                ElevatorFrame3.Fill = brush;
            }
            if (floor == 4)
            {
                ElevatorFrame4.Fill = brush;
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
            elevatorManager.AddSingleFloor(0, "down");
        }

        private void floor0up_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(0, "up");
        }

        private void floor1down_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(1, "down");
        }

        private void floor1up_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(1, "up");
        }

        private void floor2down_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(2, "down");
        }

        private void floor2up_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(2, "up");
        }

        private void floor3down_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(3, "down");
        }

        private void floor3up_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(3, "up");
        }
        private void floor4down_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(4, "down");
        }
        private void floor4up_Click(object sender, RoutedEventArgs e)
        {
            elevatorManager.AddSingleFloor(4, "up");
        }

        private void floor0CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (elevatorManager.elevators[0].direction == "up")
            {
                elevatorManager.AddSingleFloor(0, "up");
            }
            else
            {
                elevatorManager.AddSingleFloor(0, "down");
            }
        }

        private void floor1CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (elevatorManager.elevators[0].direction == "up")
            {
                elevatorManager.AddSingleFloor(1, "up");
            }
            else
            {
                elevatorManager.AddSingleFloor(1, "down");
            }
        }

        private void floor2CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (elevatorManager.elevators[0].direction == "up")
            {
                elevatorManager.AddSingleFloor(2, "up");
            }
            else
            {
                elevatorManager.AddSingleFloor(2, "down");
            }
        }

        private void floor3CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (elevatorManager.elevators[0].direction == "up")
            {
                elevatorManager.AddSingleFloor(3, "up");
            }
            else
            {
                elevatorManager.AddSingleFloor(3, "down");
            }
        }

        private void floor4CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (elevatorManager.elevators[0].direction == "up")
            {
                elevatorManager.AddSingleFloor(4, "up");
            }
            else
            {
                elevatorManager.AddSingleFloor(4, "down");
            }
        }
    }
}
