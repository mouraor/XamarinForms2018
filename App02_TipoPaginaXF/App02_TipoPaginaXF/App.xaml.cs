using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App02_TipoPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //Para instanciar/testar uma determinada página criada em Xamarin, faça a instancia da pág desejada:
            //Comentar a linha acima antes
            //MainPage = new TipoPagina.Carrocel.TipoPagina3();
            MainPage = new TipoPagina.Carrocel.ApresentacaoPage();
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
