using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace prac7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SQLiteAsyncConnection database;
            string db;

            db = DependencyService.Get<ISQLite>().GetLocalFilePath("p7.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TESHDatos>().Wait();
        }
    }
}
