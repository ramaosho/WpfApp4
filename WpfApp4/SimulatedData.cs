using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class SimulatedData
    {

        private readonly Random _random = new Random();

        public ObservableCollection<float> GenerateTemperatures(int count)
        {
            ObservableCollection<float> temperatures = new ObservableCollection<float>();

            for (int i = 0; i < count; i++)
            {
                float randomValue = (float)(_random.NextDouble() * (231.00 - 229.00) + 229.00);
                temperatures.Add(randomValue);
            }

            return temperatures;
        }

    }
}
