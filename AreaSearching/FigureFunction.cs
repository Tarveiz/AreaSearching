namespace AreaSearching
{
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
            Triangle triangle = new Triangle();
            if (triangle.IsThat(sides, angles))
            {
                foreach (int angle in angles)
                {
                    if (angle == 90)
                        return true;
                }
                return false;
            }
            throw new Exception("No valid figures were found");
        }
    }
}
