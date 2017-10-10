using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Triangle : ContentPage
    {
        public Triangle()
        {
            InitializeComponent();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.472589,-47.447445), Distance.FromMiles(0.5)));

            Mapa.ShapeCoordinates.Add(new Position(-23.472589,-47.447445));
            Mapa.ShapeCoordinates.Add(new Position(-23.470309,-47.450060));
            Mapa.ShapeCoordinates.Add(new Position(-23.467421,-47.442504));
        }
    }
}