namespace MauiApp3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
#if IOS
            var config = new MicrosoftClarityiOS.ClarityConfig(
                "n7n8qkf2p7",
                null, // Default user id
                MicrosoftClarityiOS.LogLevel.None,
                false, // Allow metered network usage
                true, // Enable web view capturing
                false, // Disable on low-end devices
                MicrosoftClarityiOS.ApplicationFramework.Native
            );

            MicrosoftClarityiOS.ClaritySDK.InitializeWithConfig(config);
#endif

            base.OnStart();
        }
    }
}
