using Paginas.Modelo;
using Paginas.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paginas
{
    public partial class MainPage : ContentPage
    {

        public int indice;
        public MainPage()
        {
            InitializeComponent();

            App.Personas.Add(new Persona() { Nombre = "Persona 1", Correo = "correo1@ucol.mx", Telefono = "1234224232" });
            App.Personas.Add(new Persona() { Nombre = "Persona 2", Correo = "correo2@ucol.mx", Telefono = "1234224232" });
            App.Personas.Add(new Persona() { Nombre = "Persona 3", Correo = "correo3@ucol.mx", Telefono = "1234224232" });
            App.Personas.Add(new Persona() { Nombre = "Persona 4", Correo = "correo4@ucol.mx", Telefono = "1234224232" });
            App.Personas.Add(new Persona() { Nombre = "Persona 5", Correo = "correo5@ucol.mx", Telefono = "1234224232" });


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstPersonas.ItemsSource = null;
            lstPersonas.ItemsSource = App.Personas;
        }

        private void Boton_Agregar(object sender, EventArgs e)
        {

            Navigation.PushAsync(new NuevoPage());

            //if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            //{
            //    DisplayAlert("Error", "Los campos no deben estar vacíos", "Aceptar");
            //}
            //else
            //{
            //    App.Personas.Add(new Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = txtTelefono.Text });
            //    lstPersonas.ItemsSource = null;
            //    lstPersonas.ItemsSource = App.Personas;
            //    seleccionado = false;
            //}
        }

        private void Boton_Modificar(object sender, EventArgs e)
        {
            if (App.seleccionado == true)
            {
                Navigation.PushAsync(new NuevoPage() { BindingContext = App.Personas[App.indice] });
            }
            else
            {
                DisplayAlert("Error", "Seleccione un elemento", "Aceptar");
            }

            //if (seleccionado == false)
            //{
            //    DisplayAlert("Error", "No hay ningún elemento seleccionado", "Aceptar");
            //}
            //else
            //{
            //    App.Personas.RemoveAt(App.indice);
            //    App.Personas.Insert(App.indice, new Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text, Telefono = txtTelefono.Text });

            //    lstPersonas.ItemsSource = null;
            //    lstPersonas.ItemsSource = App.Personas;
            //    seleccionado = false;
        }

        //}

        private void Boton_Borrar(object sender, EventArgs e)
        {
            if (App.seleccionado == false)
            {
                DisplayAlert("Error", "Seleccione un elemento", "Aceptar");
            }
            else
            {
                //txtNombre.Text = "";
                //txtCorreo.Text = "";
                //txtTelefono.Text = "";

                App.Personas.RemoveAt(indice);

                lstPersonas.ItemsSource = null;
                lstPersonas.ItemsSource = App.Personas;

                App.seleccionado = false;
            }
        }

        private void lstPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Persona persona = (Persona)e.SelectedItem;
            App.indice = e.SelectedItemIndex;
            //Console.WriteLine(persona);
            //Console.WriteLine(App.Personas[4]);
            //Console.WriteLine(App.Personas[indice]);
            //txtNombre.Text = persona.Nombre;
            //txtCorreo.Text = persona.Correo;
            //txtTelefono.Text = persona.Telefono;
            App.seleccionado = true;
        }

        private void tlbNuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoPage());
        }
    }
}
