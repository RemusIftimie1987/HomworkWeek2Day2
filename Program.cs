using System;

namespace DriverlessCarsClasses
{
    class Vehicle
    {
        private string name;
        private int year;
        private double price;
        public Vehicle()
        {

        }
        public Vehicle(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public Vehicle(string model, int yearMade, double priceOfAquisition)
        {
            this.name = model;
            this.year = yearMade;
            this.price = priceOfAquisition;
        }
        public virtual void PrintModel()
        {
            Console.WriteLine("This is a Vehicle class model");
        }
    }
    class DriverlessCar : Vehicle
    {
        public int automationLevel;
        public void SetAutomationLevel(int value)
        {
            value = automationLevel;
        }
        public int GetAutomationLevel(int automationLevel)
        {
            return automationLevel;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a DriverlessCar model");
        }
    }

    class CompleteAutomation : DriverlessCar
    {
        public bool havePedals;
        public void SetHavePedals(bool value)
        {
            value = havePedals;
        }
        public bool GetHavePedals(bool havePedals)
        {
            return havePedals;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a CompleteAutomation model");
        }
    }
    class HighAutomation : DriverlessCar
    {
        public int numberOfSensors;
        public void SetNumberOfSensors(int value)
        {
            value = numberOfSensors;
        }
        public int GetNumberOfSensors(int numberOfSensors)
        {
            return numberOfSensors;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a HighAutomation model");
        }
    }
    class ConditionalAutomation : DriverlessCar
    {
        private bool requireHumanInput;
        public void SetHumanInput(bool value)
        {
            value = requireHumanInput;
        }
        public int GetHumanInput(int requireHumanInput)
        {
            return requireHumanInput;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a ConditionalAutomation model");
        }
    }
    class ManualCar : Vehicle
    {
        public string transmissionType;
        public void SetTransmissionTypr(string value)
        {
            value = transmissionType;
        }
        public string GetTransmissionType(string transmissionType)
        {
            return transmissionType;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a ManualCar model");
        }
    }
    class NoAutomation : ManualCar
    {
        public string type;
        public void SetType(string value)
        {
            value = type;
        }
        public string GetType(string type)
        {
            return type;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a NoAutomation model");
        }
    }
    class DriverAssistance : ManualCar
    {
        public string assistFunctions;
        public void SetAssistFunctions(string value)
        {
            value = assistFunctions;
        }
        public string GetAssistFunctions(string assistFunctions)
        {
            return assistFunctions;
        }
        public override void PrintModel()
        {
            Console.WriteLine("This is a DriverAssistance model");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Based on the level of automation, driverless cars are divided in five categories.");

            // create objects for each child class of Driverlesscar and ManualCar classes.
            CompleteAutomation googleCar = new CompleteAutomation();
            googleCar.PrintModel();
            HighAutomation tesla = new HighAutomation();
            tesla.PrintModel();
            ConditionalAutomation ford = new ConditionalAutomation();
            ford.PrintModel();
            NoAutomation renault = new NoAutomation();
            renault.PrintModel();
            DriverAssistance jaguar = new DriverAssistance();
            jaguar.PrintModel();

        }
    }
}
