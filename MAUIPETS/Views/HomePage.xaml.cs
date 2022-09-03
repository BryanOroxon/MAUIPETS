using MAUIPETS.ViewModels;
using MAUIPETS.Views;

namespace MAUIPETS.Views;

public partial class HomePage : ContentPage
{
    public HomePageViewModel viewModel;

	public HomePage()
	{
        BindingContext = viewModel = new HomePageViewModel();
        InitializeComponent();

       PetsList.ItemsSource = viewModel.Pets;
    }

    private async void Donate_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DonatePage());
    }
}
