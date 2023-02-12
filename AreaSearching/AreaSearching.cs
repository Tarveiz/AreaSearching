namespace AreaSearching
{
    public class AreaSearching
    {
        public static AreaSearching Shared = new AreaSearching();
        private AreaSearching() { }
        private List<Figure> FigureCheck = new List<Figure>{new Circle(), new Triangle()};
        public double GetArea(int radius)
        {
            foreach (Figure currentFigure in FigureCheck)
            {
                if (currentFigure.IsThat(null, null, radius))
                {
                    currentFigure.SetAreaValue(null, null, radius);
                    return currentFigure.CalculateArea();
                }
            }
            throw new Exception("No valid figures were found");
        }
        public double GetArea(List<int> sides, List<int> angles)
        {
            foreach (Figure currentFigure in FigureCheck)
            {
                if (currentFigure.IsThat(sides, angles, null))
                {
                    currentFigure.SetAreaValue(sides, angles, null);
                    return currentFigure.CalculateArea();
                }
            }
            throw new Exception("No valid figures were found");
        }

        public void AppendFigure(Figure figure)
        {
            FigureCheck.Add(figure);
        }


    }
    /// <summary>
    /// Абстрактный тип фигуры
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Значение площади фигуры
        /// </summary>
        public double AreaValue { get; protected set; } = -1;
        public double CalculateArea()
        {
            if (AreaValue == -1)
            {
                throw new Exception("Not valid parameters");
            }
            return AreaValue;
        }
        public abstract bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null);
        public abstract void SetAreaValue(List<int>? sides = null, List<int>? angles = null, int? radius = null);
    }

    internal class Circle : Figure
    {
        public override bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if (radius == null)
            {
                return false;
            }
            return true;
        }

        public override void SetAreaValue(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if (radius.HasValue)
            {
                AreaValue = Math.Pow((double)radius, 2);
            }
            
        }
    }

    internal class Triangle : Figure
    {
        public override bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if(sides?.Count == 3 && angles?.Count == 3 && radius == null)
            {
                return true;
            }
            return false;
        }

        public override void SetAreaValue(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if(sides != null && angles != null)
            {
                int semiPerimeter = (sides.ElementAt(0) + sides.ElementAt(1) + sides.ElementAt(2)) / 2;
                AreaValue = Math.Sqrt(semiPerimeter * (semiPerimeter - sides.ElementAt(0)) * (semiPerimeter - sides.ElementAt(1)) * (semiPerimeter - sides.ElementAt(2)));
            }
        }
    }
}