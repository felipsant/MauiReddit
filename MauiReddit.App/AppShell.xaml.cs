namespace MauiReddit.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            SetPositionNavigationBarOnAndroid();
        }

        private static void SetPositionNavigationBarOnAndroid()
        {
            #if ANDROID
            Microsoft.Maui.Handlers.ToolbarHandler.Mapper.AppendToMapping("CustomNavigationBarView", (handler, view) =>
            {
                handler.PlatformView.ContentInsetStartWithNavigation = 0;
                handler.PlatformView.SetContentInsetsAbsolute(0, 0);
            });
            #endif
        }
    }
}
