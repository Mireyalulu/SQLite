using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        SQLiteConnection database;
        public InsertPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("p7.db");
            database = new SQLiteConnection(db);
        }

        private void Button_Insertar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                Matricula = Entry_Matricula.Text,
                Nombre = Entry_Nombre.Text,
                Apellido = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Entry_Telefono.Text,
                Carrera = Entry_Carrera.Text,
                Semestre = Entry_Semestre.Text,
                Correo = Entry_Correo.Text,
                Github = Entry_Github.Text
            };

            database.Insert(datos);
            Navigation.PushModalAsync(new DataPage());
        }
    }
}