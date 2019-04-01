using SQLiteXF.Pages.Financeiro;
using SQLiteXF.Pages.Home;
using Xamarin.Forms;

namespace SQLiteXF.Pages
{
    /// <summary>
    /// base: https://github.com/HoussemDellai/EFCore-SQLite-XamarinForms
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new DespesaPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
