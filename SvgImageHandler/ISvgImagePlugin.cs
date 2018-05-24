using System.Reflection;

namespace SvgImageHandler
{
    public interface ISvgImagePlugin
    {
        Assembly Assembly { get; }
    }
}
