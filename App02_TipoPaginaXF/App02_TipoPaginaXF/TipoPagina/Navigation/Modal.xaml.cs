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
	public partial class Modal : ContentPage
	{
		public Modal ()
		{
			InitializeComponent ();
		}

        //Este metodo é chamado pelo evento de clique do botão 'X' criado apartir da barra virtual
        private void FecharModal(object sender, EventArgs args)
        {
            //fechamento da página utilizando os metodos POP

            //
            //PopAsync - Qdo utilizar Navigation.PushAsync na chamada da pág, o PopAsync na açõa do botão deve ser utilziado para fechar a pág atual
            //PopModalAsync - Qdo utilizado Navigation.PushModamAsync, utilizar o PopModalAsync para retorar/fechar na ação do botão para fechar a página atual
            //PopToRootAsync - Este realiza o retorno para a página inicial, de qualquer página que estiver.
            Navigation.PopModalAsync();

        }


    }
}