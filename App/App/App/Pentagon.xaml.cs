using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pentagon : ContentPage
    {
        public Pentagon()
        {
            InitializeComponent();


            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.486148, -47.444184), Distance.FromMiles(0.2)));

            Mapa.ShapeCoordinates.Add(new Position(-23.486148, -47.444184));

            Mapa.ShapeCoordinates.Add(new Position(-23.486836, -47.443764));
            Mapa.ShapeCoordinates.Add(new Position(-23.487302, -47.444504));

            Mapa.ShapeCoordinates.Add(new Position(-23.486772, -47.445162));
            Mapa.ShapeCoordinates.Add(new Position(-23.486163, -47.444896));
        }
    }
}