using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using SQLiteXF.Core.Configuracoes;

namespace SQLiteXF.Droid
{
    [Activity(Label = "SQLiteXF", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            //TODO: Caminho da base de dados
            var dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "sqlitecrud.db");
            ApplicationSettings.DbPath = dbPath;

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new SQLiteXF.Pages.App());
        }
    }
}