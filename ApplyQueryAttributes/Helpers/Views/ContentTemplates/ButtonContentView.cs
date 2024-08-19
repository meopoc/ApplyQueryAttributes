namespace ApplyQueryAttributes.Helpers.Views.ContentTemplates;

public class ButtonContentView : BaseContentView
{
    public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(ButtonContentView));

    public string ButtonText
    {
        get => (string)GetValue(ButtonTextProperty);
        set => SetValue(ButtonTextProperty, value);
    }
}