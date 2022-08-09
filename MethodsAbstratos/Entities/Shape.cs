using MethodsAbstratos.Entities.Enum;

namespace MethodsAbstratos.Entities
{
    /**
     * 
     *O method abstrato tem que estar dentro
     *em uma class abstrato, senão da erro
     *
     **/
    abstract class Shape
    {
        //atributos (autoProp)
        public Color Color { get; set; }

        //Construtor aqui estou obrigando ter o atributo cor
        public Shape(Color color) 
        {
            Color = color;
        }

        //method abstract
        /**
         * 
         * É assim que faz um method abstrato
         * 
         **/
        public abstract double Area();
    }
}
