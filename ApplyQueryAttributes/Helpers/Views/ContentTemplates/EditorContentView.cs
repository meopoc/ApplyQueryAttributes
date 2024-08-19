namespace ApplyQueryAttributes.Helpers.Views.ContentTemplates;

public class EditorContentView : BaseContentView
{
    public static readonly BindableProperty EditorUnfocusedCommandProperty = BindableProperty.Create(nameof(EditorUnfocusedCommand), typeof(Command), typeof(EditorContentView));

    public Command EditorUnfocusedCommand
    {
        get => (Command)GetValue(EditorUnfocusedCommandProperty);
        set => SetValue(EditorUnfocusedCommandProperty, value);
    }
}