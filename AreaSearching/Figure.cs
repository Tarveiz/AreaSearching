namespace AreaSearching
{
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
}
