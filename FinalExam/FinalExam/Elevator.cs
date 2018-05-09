using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Elevator
    {
        double CurrentWeight = 0;

        private double MaxWeight;

        private Passenger[] Occupants;



        public Elevator(int maxOccupants, double maxWeight)

        {

            Occupants = new Passenger[maxOccupants];

            MaxWeight = maxWeight;

        }



        public void AddOccupant(Passenger passenger, int index)

        {

            Occupants[index] = passenger;

        }



        public double GetCurrentWeight()

        {

            for (int i = 0; i < Occupants.Length; i++)

            { CurrentWeight += Occupants[i].GetWeight(); }

            return CurrentWeight;

        }



        public bool IsOverMaxCapacity()

        {

            if (MaxWeight < GetCurrentWeight())

            { return true; }

            else

            { return false; }

        }



    }

}

