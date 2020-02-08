using System;

namespace Lab2_point_class
{
    class Point2D
    {
        protected double x, y;

        public Point2D()
        {
            this.X = 0.0;
            this.Y = 0.0;
        }
        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }


        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if (obj == null)
            {
                return false;
            }
            else
            {
                Point2D p = (Point2D)obj;
                return (x == p.x) && (y == p.y);
            }
        }

        public static double distanceTo(Point2D p1, Point2D p2)
        {
            return Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
        }

        public static double computeArea(Point2D p1, Point2D p2, Point2D p3)
        {
            double a = distanceTo(p1, p2);
            double b = distanceTo(p2, p3);
            double c = distanceTo(p3, p1);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }


    class Point3D: Point2D
    {
        private double  z;

        public Point3D()
        {
            this.X = 0.0;
            this.Y = 0.0;
            this.Z = 0.0;
        }
        public Point3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double Z { get => z; set => z = value; }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if (obj == null)
            {
                return false;
            }
            else
            {
                Point3D p = (Point3D)obj;
                return (x == p.x) && (y == p.y) && (z == p.z);
            }
        }

        public static double distanceTo(Point3D p1, Point3D p2)
        {
            return Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y) + (p2.z - p1.z) * (p2.z - p1.z));
        }

        public static double computeArea(Point3D p1, Point3D p2, Point3D p3)
        {
            double a = distanceTo(p1, p2);
            double b = distanceTo(p2, p3);
            double c = distanceTo(p3, p1);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D();
            Point3D p2 = new Point3D();
            Point3D p3 = new Point3D();

            for(;;)
            {
                Console.WriteLine("Input 3 coord for 1st point");
                p1.X = Convert.ToDouble(Console.ReadLine());
                p1.Y = Convert.ToDouble(Console.ReadLine());
                p1.Z = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input 3 coord for 2nd point");
                p2.X = Convert.ToDouble(Console.ReadLine());
                p2.Y = Convert.ToDouble(Console.ReadLine());
                p2.Z = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input 3 coord for 3rd point");
                p3.X = Convert.ToDouble(Console.ReadLine());
                p3.Y = Convert.ToDouble(Console.ReadLine());
                p3.Z = Convert.ToDouble(Console.ReadLine());

                if (p1.Equals(p2) || p2.Equals(p3) || p1.Equals(p3))
                    Console.WriteLine("You have equal pair of points");

                Console.WriteLine("Area: ");
                Console.WriteLine(Point3D.computeArea(p1,p2,p3));

            }
            
        }
    }
}
