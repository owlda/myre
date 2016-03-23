using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace funwithconstractors
{
    class point
    {
        private int Xcor;
        private int Ycor;
        private static string Color;
        private double time = 0;
        private double Vbegin = 0;
        
       

        public point() { }
        public point(int X, int Y) 
        {
            Xcor = X;
            Ycor = Y;
        }
        public void ChangeColor(string PointColor)
    {
        Color = PointColor;
    }
        public void ChangeCor(int deltaX, int deltaY) 
        {
            Xcor += deltaX;
            Ycor += deltaY;
        }
        public void ShowCor() 
        {
            Console.WriteLine("Current X = {0}, Y = {1}, Color = {2}", Xcor, Ycor, Color);
            Console.ReadKey();
        }
        public void MoveCorX(double Vbegin, double time) 
        {
            Xcor = (int)Xcor + (int)Vbegin * (int)time;

        }
        public void MoveCorY(double Vbegin, double time)
        {
            Ycor = (int)Ycor + (int)Vbegin * (int)time;

        }
        public void MoveEvaluation(double Vbegin, double time)
        {
            for (int i = 0; i <= time; i++)
            {
                Xcor = (int)Xcor + (int)Vbegin * (int)time;
                Ycor = (int)Ycor + (int)Vbegin * (int)time;
                Console.WriteLine("Current X = {0}, Y = {1}, Color = {2}", Xcor, Ycor, Color);
            }
        }

     }
    
}
