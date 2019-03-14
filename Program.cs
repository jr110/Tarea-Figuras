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
        
        public Color(Color.name col)
    {
        colores=col;
        if(col==Color.name.rojo)
        {
            R=128;G=0;B=0;I=1;
        }
       else
        {
            R=0;G=0;B=255;I=1;
        }

    }
    
        
    }
    abstract class Figura
    {
    protected Vector2d position;
       protected Color fill;
        

          //Constructor por defecto 
          public Figura(Vector2d position,Color fill){
            this.position=position;
            this.fill=fill;
        }
       public Figura():this(new Vector2d(100,100),new Color(255,255,255,1))
        {
        
        }
        
        //constructor de figura
        public Figura(Vector2d pos)
        {
            this.position= pos;
            
        }
        
        public Figura(Color fill)
        {
           
            this.fill=fill;
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
            figuras.Add(new Circulo(new Vector2d(311,345),new Color(Color.name.azul),10));
            figuras.Add(new Rectangulo(new Vector2d(200,200),new Color(Color.name.rojo)));
            figuras.Add(new Triangulo(new Vector2d(350,233),new Color(Color.name.verde)));
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}