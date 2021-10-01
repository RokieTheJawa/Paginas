using Paginas.Modelo;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paginas
{
    public partial class App : Application
    {
        public static List<Persona> Personas { get; set; }

        public App()
        {
            InitializeComponent();

            Personas = new List<Persona>();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
