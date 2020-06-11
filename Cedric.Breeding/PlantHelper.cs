﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cedric.Breeding
{
    public  static class PlantHelper
    {
        public static double ComputeCost(IList<Plant>? parents, double probability)
        {
            if (parents != null)
            {
                var cost = parents.Select(p => p.Cost).Sum() + 1;
                return cost / probability;
            }
            else
            {
                return 0;
            }
        }

        private static bool IsRecessiveUntilLevel(Plant plant, int level)
        {
            for (int i = 0; i < level; i++)
            {
                if (Parameters.Dominants.Contains(plant.Genome[i]))
                    return false;
            }
            return true;
        }
    }
}
