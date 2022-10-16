using System;
using System.Collections.Generic;

namespace Algorithm.DietPlanStrategy
{
    public interface IDietStrategy 
    {
        DietStrategy Name { get; }

        List<Dish> CheckSet(double allowedValue, List<Dish> items, List<Dish> bestItems, ref double bestCarboValue,
            ref double bestFatValue);
    }
}
