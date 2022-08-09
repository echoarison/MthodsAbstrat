using MethodsAbstratos.Entities.Enum;

namespace MethodsAbstratos.Entities
{
    /**
     * 
     * Quando faz um construtor com parametro 
     * estamos obrigando que ele precisa
     * ser instanciado, senão da erro.
     * 
     * Ele vai continuar dando erro, pois você
     * tem duas escolhas, ou faz o objeto rantangulo
     * virar abstrato ou cria o method Area() abstrata
     * do objeto Shape.
     * 
     **/
    internal class Rectangle : Shape
    {
        //atributo (autoProp)
        public double Width { get; set; }
        public double Height { get; set; }

        //Construtor obrigando a instancia esse atributos
        public Rectangle(double width, double height, Color color) : base(color) 
        {
            Width = width;
            Height = height;

        }

        //method (abstrato)
        /**
         * 
         * Quando vc usa um method abstrato na
         * subclass ele já usa o "override" para
         * rescreve o method
         * 
         **/
        public override double Area()
        {
            return Width * Height;
        }
    }
}
