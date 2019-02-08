using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732169_1_WEEK05
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorup;
        public string floorNumber;
        
    }
    class Elevator
    {
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void run()
        {
            FirstFloor = new Node();
            FirstFloor.floorNumber = "First Floor";
            Console.WriteLine("Floor number is {0}", FirstFloor.floorNumber);
            FirstFloor.elevatorup = SecondFloor;
            SecondFloor.floorNumber = "Second Floor";

        }
    }
}