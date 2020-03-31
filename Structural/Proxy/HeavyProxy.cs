using System.Threading.Tasks;

namespace Proxy
{
    internal class HeavyProxy : IHeavy
    {
        private readonly IHeavy _heavy;
        private int _magicNumberCached;

        public HeavyProxy(IHeavy heavy)
            => _heavy = heavy;
        public async Task<int> GetMagicNumber()
        {
            if (_magicNumberCached == 0)
                _magicNumberCached = await _heavy.GetMagicNumber();
            return _magicNumberCached;
        }
    }
}
