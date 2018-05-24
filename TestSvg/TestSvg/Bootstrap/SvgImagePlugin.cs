using System.Reflection;

namespace TestSvg
{
    public class SvgImagePlugin : SvgImageHandler.ISvgImagePlugin
    {
        public static void Init()
            => Xamarin.Forms.DependencyService.Register<SvgImageHandler.ISvgImagePlugin, SvgImagePlugin>();

        public Assembly Assembly
            => typeof(App).GetTypeInfo().Assembly;
    }
}
