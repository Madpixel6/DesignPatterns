using System;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Heavy : IHeavy
    {
        public async Task<int> GetMagicNumber()
        {
            var random = new Random();
            await Task.Delay(random.Next(1000, 2500));
            return random.Next(10, 50000);
        }
    }
}
