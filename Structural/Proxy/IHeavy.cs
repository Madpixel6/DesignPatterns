using System.Threading.Tasks;

namespace Proxy
{
    internal interface IHeavy
    {
        Task<int> GetMagicNumber();
    }
}
