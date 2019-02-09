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
            Elevator e = new Elevator();
            e.setup();
            e.TraverseList();
        }
    }
    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorup;
        public string floorNumber;

    }
    class Department
    {
        public Department(string dept_name)
        {
            DepartmentDescription = dept_name
        }
        public Department aDepartment;
        string DepartmentDescription;
    }
    
    class DepartmentStore
    {
        public void InitializeDeparments()
        {
            Department kitchenware = new Department("Kitchenware");
            Department Books = new Department("Books");
        }
    }

    class Elevator
    {
        Node Head;
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void setup()
        {
            FirstFloor = new Node();
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();
            Head = FirstFloor;
            FirstFloor.floorNumber = "First Floor";
            Console.WriteLine("Floor number is {0}", FirstFloor.floorNumber);

            FirstFloor.elevatorup = SecondFloor;
            SecondFloor.floorNumber = "Second Floor";
            Console.WriteLine("floor Number is {0}", SecondFloor.floorNumber);

            SecondFloor.elevatorup = ThirdFloor;
            ThirdFloor.floorNumber = "ThirdFloor";
            Console.WriteLine("floor number is {0}", ThirdFloor.floorNumber);


            ThirdFloor.elevatorup = FourthFloor;
            FourthFloor.floorNumber = "FourthFloor";
            Console.WriteLine("floor number is {0}", FourthFloor.floorNumber);

            FourthFloor.elevatorup = null;
        }

        public void TraverseList()
        {
            Node temp;
            Console.WriteLine("The first floor is " + Head.floorNumber);
            while (true)
            {

            }
        }
    }
}