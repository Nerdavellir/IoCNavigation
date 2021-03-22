using Nancy.TinyIoc;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IoCNavigation
{
    public class Navigator : INavigator
    {
        private string TargetAssemblyName    { get; }
        private TinyIoCContainer Container          { get; }
        private INavigation Navigation              { get; }
        

        public Navigator(Assembly pageAssembly, TinyIoCContainer container, INavigation navigation)
        {
            TargetAssemblyName = pageAssembly.GetName().Name;
            Container = container;
            Navigation = navigation;
        }

        public async Task NavigateTo<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}
