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
	public partial class ApresentacaoPage : CarouselPage
    {
		public ApresentacaoPage ()
		{
			InitializeComponent ();
		}
	}
}