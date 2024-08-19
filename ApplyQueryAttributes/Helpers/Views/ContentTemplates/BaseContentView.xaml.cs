namespace ApplyQueryAttributes.Helpers.Views.ContentTemplates;

public partial class BaseContentView : ContentView
{
    public static readonly BindableProperty CountProperty = BindableProperty.Create(nameof(Count), typeof(int), typeof(BaseContentView));

    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    public BaseContentView()
	{
		InitializeComponent();
	}
}