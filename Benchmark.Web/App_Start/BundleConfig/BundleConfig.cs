using System.Web.Optimization;

namespace Benchmark.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles()
        {
            new BundleLayoutConfig().RegisterBundles();
            new BundleViewsConfig().RegisterBundles();

            BundleTable.EnableOptimizations = true;

#if DEBUG
            new OriginalStyleAndScriptBundles().ClearTransforms();
#endif
        }
    }
}