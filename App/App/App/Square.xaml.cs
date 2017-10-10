
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Square : ContentPage
    {
        public Square()
        {
            InitializeComponent();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.4862658, -47.4443345), Distance.FromMiles(0.2)));

            Mapa.ShapeCoordinates.Add(new Position(-23.486265, -47.444334));
            Mapa.ShapeCoordinates.Add(new Position(-23.486836, -47.443764));
            Mapa.ShapeCoordinates.Add(new Position(-23.487302, -47.444504));
            Mapa.ShapeCoordinates.Add(new Position(-23.486667, -47.444994));
        }
    }
}