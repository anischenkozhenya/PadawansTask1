using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (currentPopulation <= initialPopulation || initialPopulation <=0 || percent <= 0 || visitors < 0 || currentPopulation <= 0)
            {
                throw new NotImplementedException();
            }
            int years = 0;
            double population = initialPopulation;
            do
            {
                population = population * (1 + (percent / 100)) + visitors;
                years++;
            }
            while (population <= currentPopulation);
            return years;
        }
    }
}