using M2HW3_4.Interfaces;

namespace M2HW3_4.Models
{
    public class Dog : Mammal, IBark
    {
        public Dog(string name, int averageAge, double weight, int quantityOfTeeth, string earShape)
            : base(name, averageAge, weight, quantityOfTeeth)
        {
            EarShape = earShape;
        }

        public string EarShape { get; set; }

        public virtual void DoBark()
        {
            Console.WriteLine("I can bark");
        }
    }
}
