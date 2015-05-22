using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace Benchmark.Web
{
    public class OriginalStyleAndScriptBundles
    {
        public void ClearTransforms()
        {
            OriginalBundles.ForEach(bundle => bundle.Transforms.Clear());
        }

        public List<Bundle> OriginalBundles
        {
            get
            {
                return BundleTable.Bundles.Where(bundle => IsOriginalBundle(bundle)).ToList();
            }
        }

        public bool IsOriginalBundle(Bundle bundle)
        {
            return bundle is StyleBundle || bundle is ScriptBundle;
        }
    }
}