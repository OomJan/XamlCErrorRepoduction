namespace Test;

// Adding Compile causes: "XamlC error : We only support xmlns aggregation in http://schemas.microsoft.com/dotnet/maui/global" when "xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"" is included in the control.
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class NewContent2 : ContentView
{
    public static readonly BindableProperty NormalNotationProperty = BindableProperty.Create(nameof(NormalNotation), typeof(string), typeof(NewContent2), string.Empty);

    public NewContent2()
	{
		InitializeComponent();
	}

    public string NormalNotation
    {
        get => (string)GetValue(NormalNotationProperty);
        set => SetValue(NormalNotationProperty, value);
    }
}