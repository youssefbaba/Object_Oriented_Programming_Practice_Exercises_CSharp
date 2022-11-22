﻿namespace Exercise_1
{
    public abstract class Commercial : Employee
    {
        // Fields
        protected double Income;

        // Constructors
        public Commercial(string firstName, string lastName, int age, int yearRecruitment, double income) : base(firstName, lastName, age, yearRecruitment)
        {
            Income = income;
        }

        // Methods
        public abstract override double CalculateSalary(); // Implementation wich is mandatory
        public sealed override void Display() // Re-Implementation wich is optional , keyword sealed prevents overriding from derived class
        {
            Console.WriteLine($"{GetType().Name} : FirstName = {FirstName} , LastName = {LastName} , Age = {Age} , YearRecruitment = {YearRecruitment} , Income = {Income}");
        }
    }
}
