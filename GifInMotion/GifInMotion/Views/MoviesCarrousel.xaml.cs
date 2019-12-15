using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GifInMotion.ViewModels;

namespace GifInMotion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesCarrousel : ContentPage
    {
        public MovieViewModel viewModel;
        public MoviesCarrousel()
        {
            InitializeComponent();
            BindingContext = viewModel = new MovieViewModel();
            if (viewModel.Movies.Count == 0)
            {
                viewModel.GetMoviesCommand.Execute(null);
                movieViewSource.ItemsSource = viewModel.Movies;                
            }
        }
    }
}