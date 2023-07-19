namespace Triangle
{
	public class Triangle
	{
		public double sideA { get; private set;}
        public double sideB { get; private set; }
        public double sideC { get; private set; }

        public double angleA { get; private set; }
        public double angleB { get; private set; }
        public double angleC { get; private set; }

        public Point pointA { get; private set; }
        public Point pointB { get; private set; }
        public Point pointC { get; private set; }

        public string typeBySides { get; private set; }
        public string typeByAngles { get; private set; }

        public Triangle(double sideA,double sideB, double sideC)
		{
			this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            angleC = (180/Math.PI) * Math.Acos((Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) / (2 * sideA * sideB));
            angleB = (180 / Math.PI) * Math.Acos((Math.Pow(sideC, 2) + Math.Pow(sideA, 2) - Math.Pow(sideB, 2)) / (2 * sideC * sideA));
            angleA = 180 - angleC - angleB;

            IdentifyTriangleBySides();
            IdentifyTriangleByAngles();
        }

        private void IdentifyTriangleBySides()
        {
            if(sideA == sideB && sideA == sideC)
            {
                typeBySides = "equilateral";
            }
            else if((sideA == sideB && sideA != sideC) || sideB == sideC && sideB != sideA || sideA == sideC && sideA != sideB)
            {
                typeBySides = "isoceles";
            }
            else
            {
                typeBySides = "scalene";
            }
        }

        private void IdentifyTriangleByAngles()
        {
            if (angleA == 90 || angleB == 90 || angleC == 90)
            {
                typeByAngles = "right";
            }
            else if (angleA > 90 || angleB > 90 || angleC > 90)
            {
                typeByAngles = "obtuse";
            }
            else if (angleA < 90 && angleB < 90 && angleC < 90)
            {
                typeByAngles = "acute";
            }
        }

        private void GetCoordinatesForDrawing()
        {
            double angleD = 90 - angleA;
            double sideD = sideB * Math.Sin(90 - angleA);
            double sideE = Math.Sqrt(Math.Pow(sideB, 2) - Math.Pow(sideD, 2));

            pointA = new Point(0, sideE);
            pointB = new Point(sideC, sideE);
            pointC = new Point(sideD, 0);
        }
	}
}

