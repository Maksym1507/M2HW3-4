﻿namespace M2HW3_4.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, int averageAge, double weight, int quantityOfTeeth)
            : base(name, averageAge, weight)
        {
            QuantityOfTeeth = quantityOfTeeth;
        }

        public int QuantityOfTeeth { get; set; }
    }
}
