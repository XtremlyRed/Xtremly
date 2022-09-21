using System.Threading.Tasks;
namespace Xtremly.Core
{
    public interface IAccountManager
    {
        Task<object> LoginInAsync(params object[] loginInfos);

        Task<object> LoginOutAsync(params object[] loginInfos);
    }
}
