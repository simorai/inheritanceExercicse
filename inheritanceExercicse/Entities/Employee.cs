namespace inheritanceExercicse.Entities
{
    /// <summary>
    /// Representa um funcionário com informações básicas e cálculo de pagamento.
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// Obtém ou define o nome do funcionário.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Obtém ou define o número de horas trabalhadas pelo funcionário.
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// Obtém ou define o valor por hora do funcionário.
        /// </summary>
        public double ValuePerHour { get; set; }
        /// <summary>
        /// Construtor padrão para a classe Employee.
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Construtor que inicializa um novo funcionário com nome, horas trabalhadas e valor por hora especificados.
        /// </summary>
        /// <param name="name">O nome do funcionário.</param>
        /// <param name="hours">O número de horas trabalhadas.</param>
        /// <param name="valuePerHour">O valor por hora do funcionário.</param>
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        /// <summary>
        /// Calcula o pagamento do funcionário com base nas horas trabalhadas e no valor por hora.
        /// </summary>
        /// <returns>O valor total do pagamento.</returns>
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
