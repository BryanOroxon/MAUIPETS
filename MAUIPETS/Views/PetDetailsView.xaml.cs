using MAUIPETS.ViewModels;

namespace MAUIPETS.Views;

public partial class PetDetailsView : ContentPage
{
    PetDetailsViewModel viewModel;
    public PetDetailsView(PetDetailsViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = this.viewModel = viewModel;
    }
}
