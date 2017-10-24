using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<TESHDatos> Items { get; set; }
        SQLiteConnection database;

        public DataPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("p7.db");
            database = new SQLiteConnection(db);
            database.CreateTable<TESHDatos>();
            Items = new ObservableCollection<TESHDatos>(database.Table<TESHDatos>());
            BindingContext = this;

        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushModalAsync(new SelectPage(e.SelectedItem as TESHDatos));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InsertPage());
        }
    }

}
