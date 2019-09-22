using DACFW.Entities;
using DACFW.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClientFW
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(true)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void BtnPostRelevamiento_Clicked(object sender, EventArgs e)
		{
			try
			{
				string urlPost = "http://iserver.itris.com.ar:7101/DACServicesTest/api/Relevamiento";

				ItrisRelevamientoRepository repo = new ItrisRelevamientoRepository();
				ItrisPlanillaEntity planilla = this.CargarDatosPrueba();
				var response = repo.Post(urlPost, planilla);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private ItrisPlanillaEntity CargarDatosPrueba()
		{
			ItrisPlanillaEntity planillaEntity = new ItrisPlanillaEntity();
			planillaEntity.CodigoRequest = "123456789-12";

			//CARGO DATOS DE LA PLANILLA
			planillaEntity.Relevamiento = new ItrisRelevamientoEntity()
			{
				FK_ERP_EMPRESAS = "2",
				FK_ERP_ASESORES = 9,
				FECHA = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
				CODIGO = "ASDASD",
				ENVIADO_POR_MAIL = false
			};

			//CARGO DATOS DE LOS COMERCIOS
			planillaEntity.Comercios = new List<ItrisComercioArticulo>();

			//GENERO LOS DATOS DE UN COMERCIO
			ItrisComercioArticulo itrisComercioArticulo = new ItrisComercioArticulo();
			itrisComercioArticulo.Comercio = new ItrisComercioEntity()
			{
				FK_TIP_COM = 1,
				NOMBRE = "Kioskin",
				CALLE ="falsa",
				NUMERO = "123",
				FK_ERP_LOCALIDADES = 3,
				FK_ERP_PROVINCIAS = 1,
				LATITUD = "111.22222",
				LONGITUD = "99999.44444"
			};

			itrisComercioArticulo.RelevamientoArticulo = new List<ItrisRelevamientoArticuloEntity>();
			ItrisRelevamientoArticuloEntity relArt;

			for(int i=1; i<11; i++)
			{
				relArt = new ItrisRelevamientoArticuloEntity();
				relArt.FK_ARTICULOS = i;
				relArt.EXISTE = true;
				relArt.PRECIO = 0.1d + i;

				itrisComercioArticulo.RelevamientoArticulo.Add(relArt);
			}

			planillaEntity.Comercios.Add(itrisComercioArticulo);
			return planillaEntity;
		}
	}
}
