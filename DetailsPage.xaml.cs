using MauiCRUD_App.ViewModels;


namespace MauiCRUD_App
{
    public partial class DetailsPage : ContentPage
    {
        private readonly ProductsViewModel _productsViewModel;

        public DetailsPage(ProductsViewModel productsViewModel)
        {
            InitializeComponent();
            BindingContext = productsViewModel;
            _productsViewModel = productsViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _productsViewModel.LoadProductsAsync();
        }
    }
}