namespace AreaSearching
{
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
}
