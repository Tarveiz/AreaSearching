namespace AreaSearching
{
    public class AreaSearching
    {
        public static AreaSearching Shared = new AreaSearching();
        private AreaSearching() { }
        private List<Figure> _figureCheck = new List<Figure>{new Circle(), new Triangle()};
        public double GetArea(int radius)
        {
            foreach (Figure currentFigure in _figureCheck)
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
            foreach (Figure currentFigure in _figureCheck)
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
            _figureCheck.Add(figure);
        }
    }
}