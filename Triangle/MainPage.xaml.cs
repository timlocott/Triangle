using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Microsoft.Maui.Controls.Shapes;

namespace Triangle;

public partial class MainPage : ContentPage
{
    double entryA = 0;
    double entryB = 0;
    double entryC = 0;

    public string someString = "";

    public MainPage()
	{
        AppShell.SetNavBarIsVisible(this, false);
        InitializeComponent();
    }

    private void EntryA_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        //Get side as int if populated
        entryA = EntryA.Text != null && Double.TryParse(EntryA.Text, out _) ? Double.Parse(EntryA.Text) : 0;
        _ = AttemptTriangleAsync();
    }

    private void EntryB_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        //Get side as int if populated
        entryB = EntryB.Text != null && Double.TryParse(EntryB.Text, out _) ? Double.Parse(EntryB.Text) : 0;
        _ = AttemptTriangleAsync();
    }

    private void EntryC_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        //Get side as int if populated
        entryC = EntryC.Text != null && Double.TryParse(EntryC.Text, out _) ? Double.Parse(EntryC.Text) : 0;
        _ = AttemptTriangleAsync();
    }

    private async Task AttemptTriangleAsync()
    {
        ValidationMessage.Text = "";
        AngleAType.Text = "";
        AngleBType.Text = "";
        AngleCType.Text = "";

        // All entries are populated
        if (EntryA.Text != null && EntryB.Text != null && EntryC.Text != null)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            ToastDuration duration = ToastDuration.Short;
            double fontSize = 14;

            // Checks for positive numbers
            if ((entryA == 0 && EntryA.IsFocused == false) || (entryB == 0 && EntryB.IsFocused == false) || (entryC == 0 && EntryC.IsFocused == false))
            {
                //ValidationMessage.Text = "";
                string toastText = "Please add a positive number for each side of the triangle";
                var toast = Toast.Make(toastText, duration, fontSize);
                await toast.Show(cancellationTokenSource.Token);
            }
            // Checks to see if it is a valid triangle
            else if (entryA + entryB < entryC || entryA + entryC < entryB || entryB + entryC < entryA)
            {
                string toastText = "This is not a valid triangle, please use appropriate lengths";
                var toast = Toast.Make(toastText, duration, fontSize);
                await toast.Show(cancellationTokenSource.Token);
                //ValidationMessage.Text = "";
            }
            else
            {
                Triangle triangle = new Triangle(entryA,entryB,entryC);
                ValidationMessage.Text = $"This is a valid {triangle.typeByAngles} {triangle.typeBySides} triangle";

                AngleAType.Text = $"{String.Format("{0:0.##}",triangle.angleA)}°";
                AngleBType.Text = $"{String.Format("{0:0.##}", triangle.angleB)}°";
                AngleCType.Text = $"{String.Format("{0:0.##}", triangle.angleC)}°";

                Binding pointABinding = new Binding();
                pointABinding.Source = triangle;
                pointABinding.Path = "pointA";
                pointA.SetBinding(PathFigure.StartPointProperty, pointABinding);

                Binding pointBBinding = new Binding();
                pointBBinding.Source = triangle;
                pointBBinding.Path = "pointB";
                pointB.SetBinding(LineSegment.PointProperty, pointBBinding);

                Binding pointCBinding = new Binding();
                pointCBinding.Source = triangle;
                pointCBinding.Path = "pointC";
                pointC.SetBinding(LineSegment.PointProperty, pointCBinding);

                pointA.StartPoint = triangle.pointA;
                pointB.Point = triangle.pointB;
                pointC.Point = triangle.pointC;
            }
        }
    }
}


