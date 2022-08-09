using MethodsAbstratos.Entities.Enum;
using System;

namespace MethodsAbstratos.Entities
{
    internal class Circle : Shape
    {
        //atributo (autoProp)
        public double Radius { get; set; }

        //Construtor obrigatorio
        public Circle(double radius, Color color) 
            :base(color)        
        {

            Radius = radius;
        
        }

        //method(abstrato)
        public override double Area()
        {
            return Math.PI * Math.Sqrt(Radius); //Ou poderia ser 3.14 * Radius * Radius
        }

    }
}
