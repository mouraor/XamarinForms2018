using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        //Este metodo apresenta uma segunda forma de naveração entre páginas existentes no projeto.
        //Apartir do evento clicked xaml (que chama MudarParaPAgina2)

        //Nota:
        //O metodo Navigation só funciona se definido que a página pertence ao NavigationPage (ver Carrocel.TipoPagina3())
        private void MudarParaPagina2 (object sender, EventArgs args)
        {
            //O metodo 'PushAsync" adiciona uma nova página na pilha de memória, o que permite 
            //a navegação na sequencia de abertura, para página seguinte. O botão de voltar é adicionado automaticamente
            Navigation.PushAsync(new Pagina2());
        }

        //Este metodo permite navegar para determinadas páginas que estão fora de uma sequencia determinada pelo 
        //metodo PushAsync (Acima)
        private void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

        
        private void ChamarMaster(object sender, EventArgs args)
        {
            //Para chamadas de páginas do tipo MasterDelailPage, TabbedPage e CarousePage utilizar deve ser... 
            App.Current.MainPage = new Master.MasterPage();
        }


        //Este metodo é chamado pelo evento de clicked do icone do menu exisnte na página
        private void MostraJanelaAviso(object sender, EventArgs args)
        {
            DisplayAlert("BOTÃO TIPO", "Você apertou o botão Tipo na toolbar", "OK");
        }

    }
}