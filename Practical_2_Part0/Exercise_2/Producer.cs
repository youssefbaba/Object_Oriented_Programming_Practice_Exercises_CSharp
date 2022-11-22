﻿namespace Exercise_2
{
    public class Producer : Employee
    {
        // Fields
        int _numberUnits;       // by default is private

        // Constructors
        public Producer(string firstName, string lastName, int age, int yearRecruitment, int numberUnits) : base(firstName, lastName, age, yearRecruitment)
        {
            _numberUnits = numberUnits;
        }

        // Methods
        public override double CalculateSalary()  // Emplementation wich is mantadory
        {
            return _numberUnits * 5;
        }
        public override string Display() // Re-Implementaion wich is optional
        {
            return $"{GetType().Name} : FirstName = {FirstName} , LastName = {LastName} , Age = {Age} , YearRecruitment = {YearRecruitment} , Number Of Units = {_numberUnits} ";
        }
    }
}
