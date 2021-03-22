using System.Threading.Tasks;

namespace IoCNavigation
{
    public interface INavigator
    {
        Task NavigateTo<T>();
    }
}
