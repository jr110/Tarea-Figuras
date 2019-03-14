using System;
using System.Collections.Generic;

namespace Figura2
{
    class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    class Color
    {
        public enum name{rojo,azul,verde}
         public int R,G,B,I;
        public Color.name colores;
        public Color (int R,int G,int B,int I)
        {
            this.R=R;
            this.G=G;
            this.B=B;
            this.I=I;
            this.colores=Color.name.azul;
        
            
        }
        
    }
    abstract class Figura
    {
    protected Vector2d position;
       protected Color fill,border;
        //public Color fill ,border;

          //Constructor por defecto 
          public Figura(Vector2d position,Color fill){
            this.position=position;
            this.fill=fill;
        }
       public Figura():this(new Vector2d(100,100),new Color(255,255,255,1))
        {
        
        }
        //constructor de figura
        public Figura(Vector2d pos,Color fill)
        {
            this.position= pos;
            this.fill=fill;
            //this.fill=fill
            //Color.fill=Color.name.azul;
            //border= "black";
        }

        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos,Color fill, int radio):base(pos,fill)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position,fill);
     }
    }

    class Triangulo: Figura
    {
        public Triangulo(Vector2d pos,Color fill):base(pos,fill)
        {

        }
        public Triangulo():base()
        {

        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Triangulo en {0} de color {1}", position, fill);
        }

        
    }
    class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2d pos,Color fill):base(pos,fill)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
     }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(new Vector2d(342,500),new Color(Color.name.azul)));
            figuras.Add(new Rectangulo(new Vector2d(200,200),new Color(Color.name.rojo)));
            figuras.Add(new Triangulo(new Vector2d(350,233),new Color(Color.name.verde)));
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}