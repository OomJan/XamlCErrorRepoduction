namespace Test;

// Adding Compile causes: "XamlC error : We only support xmlns aggregation in http://schemas.microsoft.com/dotnet/maui/global" when "xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"" is included in the control.
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class NewContent2 : ContentView
{
    public static readonly BindableProperty NormalNotationProperty = BindableProperty.Create(nameof(NormalNotation), typeof(string), typeof(NewContent2), string.Empty);
    public static readonly BindableProperty SomeBoolProperty = BindableProperty.Create(nameof(SomeBool), typeof(bool), typeof(NewContent2), false);

    public NewContent2()
	{
		InitializeComponent();

        MauiCommunityTookitUnlinkProtection();

    }

    public void MauiCommunityTookitUnlinkProtection()
    {
        // Forciert das die Toolkit Bibliothek nicht weg optimiert wird selbst wenn auf diese in XAML drauf zugegriffen wird!
        var tInitToolkit = new CommunityToolkit.Maui.Core.SnackbarOptions();
        tInitToolkit.BackgroundColor = null;
    }

    public string NormalNotation
    {
        get => (string)GetValue(NormalNotationProperty);
        set => SetValue(NormalNotationProperty, value);
    }

    public string SomeBool
    {
        get => (string)GetValue(SomeBoolProperty);
        set => SetValue(SomeBoolProperty, value);
    }
}