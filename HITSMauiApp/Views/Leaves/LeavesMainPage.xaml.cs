using GalaSoft.MvvmLight.Helpers;
using HITSMauiApp.Models;
using HITSMauiApp.Services;
using HITSMauiApp.ViewModels;
using Microsoft.Maui.Controls;

namespace HITSMauiApp.Views.Leaves;

public partial class LeavesMainPage : ContentPage
{
	public LeavesMainPage()
	{
		InitializeComponent();

		BindingContext = new VacationViewModel();

    }

 

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddPage());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BalancePage());

    }

    private async void  Button_Clicked_3(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Vacation Filtter", "Select Date ");
    }
}