using Core.Web.Config;

namespace Testing.Config
{
    public class TestConfig : IAppConfig
    {
        public SeedSettings SeedSettings { get; set; } = new SeedSettings
        {
            ShouldResetDatabase = true
        };

        public bool RequireHttps { get; set; } = false;
    }
}