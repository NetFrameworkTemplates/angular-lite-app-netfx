using ServiceStack;

namespace MyApp
{
    public class ConfigureUi : IAfterInitAppHost
    {
        public void AfterInit(IAppHost appHost)
        {
            // if wwwroot/ is empty, build Client App with 'npm run build'
            var svgDir = appHost.RootDirectory.GetDirectory("/assets/svg") ?? appHost.ContentRootDirectory.GetDirectory("/src/assets/svg");
            if (svgDir != null)
            {
                Svg.Load(svgDir);
            }
            Svg.CssFillColor["svg-icons"] = "#2f495e";
        }
    }
}
