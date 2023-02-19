namespace AreaSearching
{
    internal class Triangle : Figure
    {
        public override bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if (sides?.Count == 3 && angles?.Count == 3 && radius == null && angles.Sum() == 180 && triangleIsExist())
            {
                return true;
            }
            return false;

            bool triangleIsExist()
            {
                List<int> sidesAscending = new List<int>();
                sidesAscending.Add(sides.Min());
                foreach (int side in sides)
                {
                    if (side != sides.Min() && side != sides.Max())
                    {
                        sidesAscending.Add(side);
                    }
                }
                sidesAscending.Add(sides.Max());
                if (sidesAscending[0] + sidesAscending[1] > sidesAscending[2])
                    return true;
                else
                    return false;
                throw new Exception("Not valid parameters");
            }
        }
        public override void CalculateArea(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if (sides != null && angles != null)
            {
                int semiPerimeter = (sides.ElementAt(0) + sides.ElementAt(1) + sides.ElementAt(2)) / 2;
                AreaValue = Math.Sqrt(semiPerimeter * (semiPerimeter - sides.ElementAt(0)) * (semiPerimeter - sides.ElementAt(1)) * (semiPerimeter - sides.ElementAt(2)));
            }
        }

    }
}
