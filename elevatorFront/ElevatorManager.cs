using elevatorFront;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ElevatorSystemConsole
{
    public class ElevatorManager
    {
        public List<Elevator> elevators { get; set; }

        public List<int> floorUp { get; set; }
        public List<int> floorDown { get; set; }
        public bool isEmpty { get; set; }

        public ElevatorManager(int number)
        {
            elevators = new List<Elevator>();
            for (int i = 0; i < number; i++)
            {
                elevators.Add(new Elevator());
            }
            floorUp = new List<int>();
            floorDown = new List<int>();
            isEmpty = true;
        }

        public async Task UpdateElevetorQueue()
        {
            for (int i = 0; i < elevators.Count; i++)
            {
                if (elevators[i].isRunning == true && elevators[i].direction == "up")
                {
                    while (floorUp.Count > 0)
                    {
                        if (!elevators[i].floorQueue.Contains(floorUp.First()))
                        {
                            elevators[i].floorQueue.Add(floorUp.First());
                        }
                        floorUp.Remove(floorUp.First());
                    }
                }
                else if (elevators[i].isRunning == true && elevators[i].direction == "down")
                {
                    while (floorDown.Count > 0)
                    {
                        if (!elevators[i].floorQueue.Contains(floorDown.First()))
                        {
                            elevators[i].floorQueue.Add(floorDown.First());
                        }
                        floorDown.Remove(floorDown.First());
                    }
                }
                else if (elevators[i].floorQueue.Count == 0)
                {
                    if (floorUp.Count > floorDown.Count)
                    {
                        while (floorUp.Count > 0)
                        {
                            if (!elevators[i].floorQueue.Contains(floorUp.First()))
                            {
                                elevators[i].floorQueue.Add(floorUp.First());
                            }
                            floorUp.Remove(floorUp.First());
                        }
                        elevators[i].direction = "up";
                    }
                    else
                    {
                        while (floorDown.Count > 0)
                        {
                            if (!elevators[i].floorQueue.Contains(floorDown.First()))
                            {
                                elevators[i].floorQueue.Add(floorDown.First());
                            }
                            floorDown.Remove(floorDown.First());
                        }
                        elevators[i].direction = "down";
                    }
                    elevators[i].isRunning = true;
                }
            }
        }

        public void AddFloor(PersonFloorRequest pfr)
        {
            if (pfr.direction == "up")
            {
                floorUp.Add(pfr.destinationFloor);
                floorUp.Add(pfr.currentFloor);
                floorUp.Sort();
            }
            else
            {
                floorDown.Add(pfr.destinationFloor);
                floorDown.Add(pfr.currentFloor);
                floorDown.Sort();
                floorDown.Reverse();
            }
            isEmpty = false;
        }
        public void AddRequestFromButton(int current, int destination)
        {
            PersonFloorRequest pfr = new PersonFloorRequest(current, destination);
            AddFloor(pfr);
        }
        public void MakeStep()
        {
            Thread.Sleep(500);
            UpdateElevetorQueue();
            elevators[0].NewRun();
        }
    }
}