using MAUIPETS.Models;

namespace MAUIPETS.Views;

public partial class DonatePage : ContentPage
{
	public DonatePage()
	{
		InitializeComponent();
	}

    private async void donate25_Clicked(object sender, EventArgs e)
    {
        donate25.BackgroundColor = Color.FromHex("#f0690c");
        labelDonate.Text = " $25 can pay a comfy bed.";
        donate50.BackgroundColor = Color.FromHex("#FFC300");
        donate100.BackgroundColor = Color.FromHex("#FFC300");
        Donate.Text = "Donate $25";
        await Imagedog.ScaleTo(1.3, 1000, Easing.Linear);
    }

    private async void donate50_Clicked(object sender, EventArgs e)
    {
        donate50.BackgroundColor = Color.FromHex("#f0690c");
        labelDonate.Text = "$50 can feed a large dog for a month.";
        donate25.BackgroundColor = Color.FromHex("#FFC300");
        donate100.BackgroundColor = Color.FromHex("#FFC300");
        Donate.Text = "Donate $50";
        await Imagedog.ScaleTo(1.5, 1000, Easing.Linear);
    }

    private async void donate100_Clicked(object sender, EventArgs e)
    {
        donate100.BackgroundColor = Color.FromHex("#f0690c");
        labelDonate.Text = "$100 can help to pay a medication for injured pet.";
        donate25.BackgroundColor = Color.FromHex("#FFC300");
        donate50.BackgroundColor = Color.FromHex("#FFC300");
        Donate.Text = "Donate $100";
        await Imagedog.ScaleTo(1.9, 1000, Easing.Linear);
    }

    private async void Donate_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Donation());
    }
}
