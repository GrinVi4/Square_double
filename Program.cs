using System;
using System.Collections.Generic;
using static System.Math;
 
namespace Project
{
    
 
    class Polygon
    {
        private double[,] points;
 
        public Polygon(double[,] points)
        {
            
 
            this.points = new double[points.GetLength(0), 2];
 
            for (int amountOfPoints = 0; amountOfPoints < points.GetLength(0); amountOfPoints++)
            {
                for (int amountOfArgs = 0; amountOfArgs < points.GetLength(1); amountOfArgs++)
                {
                    this.points[amountOfPoints, amountOfArgs] = points[amountOfPoints, amountOfArgs];
                }
            }
        }
 
        private double GetXOfPointNumbK(int k)
        {
            return points [k, 0];
        }
 
        private double GetYOfPointNumbK(int k)
        {
            return points[k, 1];
        }
 
        public override string ToString()
        {
            string output = "";
            for (int amountOfPoints = 0; amountOfPoints < points.GetLength(0); amountOfPoints++) 
            {
                for (int amountOfArgs = 0; amountOfArgs < points.GetLength(1); amountOfArgs++)
                {
                    output += string.Format("{0:0.00} ", points[amountOfPoints, amountOfArgs]);
                }
                output += ";    ";
            }
            return string.Format("Polygon: \n{0}", output);
        }
 
        public double Area()
        {
            int numPoints = points.GetLength(0);
            double area = 0;
            int j = numPoints - 1;
            for (int i = 0; i < numPoints; i++)
            {
                area +=(GetXOfPointNumbK(j)+GetXOfPointNumbK(i)) * (GetYOfPointNumbK(j) - GetYOfPointNumbK(i));
                j = i;
            }
            return Math.Abs(area / 2);
        }
    }
 
    class Program
    {
        public static void Main(string[] args)
        {
 
            try
            {
                
                double[,] arrayOfpoints = { { 2.14, 3.25 }, { 5.36, 3.14 }, { 7.25, 2.36 }, { 7.47, 5.58 }, { 4, 6 } };
                Polygon p1 = new Polygon(arrayOfpoints);
                Console.WriteLine(p1);
                Console.WriteLine("Area of this polygon: {0}", p1.Area());
            }
            catch (Exception e)
            {    
               Console.WriteLine(e.Message);
            }
 
        }
    } 
}