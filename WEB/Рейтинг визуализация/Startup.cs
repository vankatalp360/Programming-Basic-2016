using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Рейтинг_визуализация.Startup))]
namespace Рейтинг_визуализация
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
