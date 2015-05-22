using System.Web.Optimization;

namespace Benchmark.Web
{
    public class BundleConfigBase
    {
        public void AddStyleBundle(string cssStyleName, params string[] virtualPaths)
        {
            AddBundle(new StyleBundle(cssStyleName), virtualPaths);
        }

        public void AddScriptBundle(string jsScriptName, params string[] virtualPaths)
        {
            AddBundle(new ScriptBundle(jsScriptName), virtualPaths);
        }

        private void AddBundle(Bundle bundle, params string[] virtualPaths)
        {
            BundleTable.Bundles.Add(bundle.Include(virtualPaths));
        }
    }
}