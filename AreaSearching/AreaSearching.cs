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
                    currentFigure.CalculateArea(null, null, radius);
                    return currentFigure.ValidateArea();
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
                    currentFigure.CalculateArea(sides, angles, null);
                    return currentFigure.ValidateArea();
                }
            }
            throw new Exception("No valid figures were found");
        }
        /// <summary>
        /// Добавить фигуру
        /// </summary>
        /// <param name="figure"></param>
        public void AppendFigure(Figure figure)
        {
            FigureCheck.Add(figure);
        }
    }
    /// <summary>
    /// Дополнительный функционал к фигурам
    /// </summary>
    public class FigureFunction
    {
        /// <summary>
        /// Проверка прямоугольный ли треугольник
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="angles"></param>
        /// <returns></returns>
        public bool CheckRightTriangle(List<int> sides, List<int> angles)
        {
            if(sides.Count == 3 && angles.Count == 3)
            {
                foreach(int angle in angles)
                {
                    if (angle == 90)
                        return true;
                }
            }
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
        internal double ValidateArea()
        {
            if (AreaValue == -1)
            {
                throw new Exception("Not valid parameters");
            }
            return AreaValue;
        }
        /// <summary>
        /// Проверка соответствия фигуры
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="angles"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public abstract bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null);
        //public abstract bool IsThat(List<int>? sides = null, List<int>? angles = null);

        /// <summary>
        /// Подсчет площади фигуры (с присвоением AreaValue)
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="angles"></param>
        /// <param name="radius"></param>
        public abstract void CalculateArea(List<int>? sides = null, List<int>? angles = null, int? radius = null);
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

        public override void CalculateArea(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            AreaValue = Math.Pow((double)radius, 2);
        }
    }

    internal class Triangle : Figure
    {
        public override bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            bool triangleIsExist()
            {
                List<int> sidesAscending = new List<int>();
                foreach (int i in sides)
                {
                    sidesAscending.Add(i);
                }
                if (sidesAscending.Min() <= sidesAscending[0])
                {
                    int temp = sidesAscending[0];
                    sidesAscending[0] = sidesAscending.Min();
                    if (temp <= sidesAscending[1])
                    {
                        sidesAscending[2] = sidesAscending[1];
                        sidesAscending[1] = temp;
                    }
                    else if(temp <= sidesAscending[2])
                    {

                    }
                }

                for (int i =0; i<sides.Count(); i++)
                {
                    if()
                }
                
                
            }
            
            if(sides?.Count == 3 && angles?.Count == 3 && radius == null && angles.Sum() == 180)
            {
                return true;
            }
            return false;
        }
        public override void CalculateArea(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if(sides != null && angles != null)
            {
                int semiPerimeter = (sides.ElementAt(0) + sides.ElementAt(1) + sides.ElementAt(2)) / 2;
                AreaValue = Math.Sqrt(semiPerimeter * (semiPerimeter - sides.ElementAt(0)) * (semiPerimeter - sides.ElementAt(1)) * (semiPerimeter - sides.ElementAt(2)));
            }
        }
    }
}