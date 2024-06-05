namespace MauiCRUD_App;
using MauiCRUD_App.Data;
using MauiCRUD_App.ViewModels;

public partial class MainPage : ContentPage
{

    private readonly ProductsViewModel _productsViewModel;
    public MainPage()
	{
        InitializeComponent();
        var databaseContext = new DatabaseContext();
        _productsViewModel = new ProductsViewModel(databaseContext);
    }

    async void OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DetailsPage(_productsViewModel));
    }
}