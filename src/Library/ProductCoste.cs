using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost
    {
        public static double GetProductionCost(Recipe recipe)
        {
            double CostoTotal = 0;
            double CostoInsumos = 0;
            double CostoEquipamiento=0;
            foreach (Step step in recipe.steps)
            {
                CostoInsumos+=Convert.ToDouble(step.Quantity);
                CostoEquipamiento+=(Convert.ToDouble(step.Time)/3600)*Convert.ToDouble(step.Equipment.HourlyCost);
            }
            CostoTotal = CostoEquipamiento+CostoInsumos;
            return CostoTotal;
        }
    }
}
