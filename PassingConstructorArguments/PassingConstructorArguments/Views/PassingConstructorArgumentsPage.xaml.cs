using Xamarin.Forms;

namespace PassingConstructorArguments.Views
{
	public partial class PassingConstructorArgumentsPage : ContentPage
	{
		public PassingConstructorArgumentsPage()
		{
			InitializeComponent();
			
			bw1.Color = new Color(0.9);
			bw2.Color = Color.FromRgb(192, 75, 150);
		}
	}
}
