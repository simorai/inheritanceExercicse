namespace inheritanceExercicse.Entities
{
    /// <summary>
    /// Representa um funcionário terceirizado, herdando da classe Employee.
    /// </summary>
    internal class OutsourcedEmployee : Employee
    {
        /// <summary>
        /// Obtém ou define a cobrança adicional para o funcionário terceirizado.
        /// </summary>
        public double AditionalCharge { get; set; }

        /// <summary>
        /// Construtor padrão para a classe OutsourcedEmployee.
        /// </summary>
        public OutsourcedEmployee() { }

        /// <summary>
        /// Construtor que inicializa um novo funcionário terceirizado com nome, horas trabalhadas, valor por hora e cobrança adicional especificados.
        /// </summary>
        /// <param name="name">O nome do funcionário.</param>
        /// <param name="hours">O número de horas trabalhadas.</param>
        /// <param name="valuePerHour">O valor por hora do funcionário.</param>
        /// <param name="aditionalCharge">A cobrança adicional para o funcionário terceirizado.</param>
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        /// <summary>
        /// Calcula o pagamento do funcionário terceirizado, incluindo a cobrança adicional com um bônus de 10%.
        /// </summary>
        /// <returns>O valor total do pagamento, incluindo o bônus sobre a cobrança adicional.</returns>
        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;

        }


    }
}
