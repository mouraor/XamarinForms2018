using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carrocel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        //Este metodo é chamado pelo evento de clique definido do botão definido no xaml desta página
        //Este metodo realiza a transição da mainPage atual (current), que é a carrocel para a nova página instanciada
        //no caso a Navigation

        private void MudarPagina(Object sender, EventArgs args)
        {
            //NOTA: Este metodo não permite que haja retorno após a transição.

            //App.Current.MainPage = new Navigation.Pagina1();

            //********************************************************************************************************
            //NOTA: Este metodo permite que haja retorno às transições de páginas. 
            //A introdução da página encontra-se em Navigation.Pagia1().

            //Para este metodo entende-se que ao clicar o botão (evento clicked xaml MudarPagina), 
            //será instanciado uma nova página 'NavigationPage' que possui uma 'Página1()'.

            //Desta forma, permite-se realizar navegações entre as páginas (Avança/Retorna)
            // A propriedade descrita dentro das '{}' possibilitam a edição das propriedades da NavigatonPage
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor = Color.BlueViolet };

            //***********************************************************************************************************
            //Incusão de abas na página 1 do Navigation
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}