/**
 * Author: Tim Cottrell
 * Project: Caselle Interview - Coding Problem
 */

namespace Triangle
{
    /**
     * Class to represent a triangle and its properties
     */
	public partial class Triangle
	{
        //Properties to represent triangle sides
		public double sideA { get; private set;}
        public double sideB { get; private set; }
        public double sideC { get; private set; }

        //Properties to represent triangle angles
        public double angleA { get; private set; }
        public double angleB { get; private set; }
        public double angleC { get; private set; }

        //Properties to represent triangle points in a coordinate system for drawing
        public Point pointA = new Point(0,0);
        public Point pointB = new Point(0, 0);
        public Point pointC = new Point(0, 0);

        //Properties to help classify triangle
        public string typeBySides { get; private set; }
        public string typeByAngles { get; private set; }

        // Triangle constructor, takes doubles representing the triangle sides
        public Triangle(double sideA,double sideB, double sideC)
		{
			this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            // Calculate angles
            angleC = (180/Math.PI) * Math.Acos((Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) / (2 * sideA * sideB));
            angleB = (180 / Math.PI) * Math.Acos((Math.Pow(sideC, 2) + Math.Pow(sideA, 2) - Math.Pow(sideB, 2)) / (2 * sideC * sideA));
            angleA = 180 - angleC - angleB;

            IdentifyTriangleBySides();
            IdentifyTriangleByAngles();
            GetCoordinatesForDrawing();
        }

        /**
         * Method to classify the triangle using the sides
         */
        private void IdentifyTriangleBySides()
        {
            // All sides are equal in length
            if(sideA == sideB && sideA == sideC)
            {
                typeBySides = "equilateral";
            }
            // Two sides are equal in length
            else if ((sideA == sideB && sideA != sideC) || sideB == sideC && sideB != sideA || sideA == sideC && sideA != sideB)
            {
                typeBySides = "isoceles";
            }
            // None of the sides are equal in length
            else
            {
                typeBySides = "scalene";
            }
        }

        /**
         * Method to classify the triangle using the angles
         */
        private void IdentifyTriangleByAngles()
        {
            // Any angle is 90 degrees
            if (angleA == 90 || angleB == 90 || angleC == 90)
            {
                typeByAngles = "right";
            }
            // Any angle is greater than 90 degrees
            else if (angleA > 90 || angleB > 90 || angleC > 90)
            {
                typeByAngles = "obtuse";
            }
            // All angles are less than 90 degrees
            else if (angleA < 90 && angleB < 90 && angleC < 90)
            {
                typeByAngles = "acute";
            }
        }

        /**
         * Method to get coordinates for vertices of triangle for drawing
         * TODO: implement in XAML and cs files
         */
        private void GetCoordinatesForDrawing()
        {
            double angleD = 90 - angleA;
            double sideD = sideB * Math.Sin(angleD);
            double sideE = Math.Sqrt(Math.Pow(sideB, 2) - Math.Pow(sideD, 2));

            pointA = new Point(0, sideE);
            pointB = new Point(sideC, sideE);
            pointC = new Point(sideD, 0);
        }
	}
}

