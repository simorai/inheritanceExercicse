namespace inheritanceExercicse.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;

        }


    }
}
