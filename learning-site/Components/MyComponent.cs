using learning_site.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace learning_site.Components
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class MyComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<MyComponent>();
        }
    }

    public class MyComponent : IComponent
    {
        public MyComponent()
        {

        }

        public void Initialize()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void Terminate()
        {
        }
    }
}