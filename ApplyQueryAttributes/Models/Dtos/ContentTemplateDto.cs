using CommunityToolkit.Mvvm.ComponentModel;

namespace ApplyQueryAttributes.Models.Dtos
{
    public class ContentTemplateDto : ObservableObject
    {
        private int type;
        public int Type
        {
            get { return type; }
            set { SetProperty(ref type, value); }
        }

        private string? display;
        public string? Display
        {
            get { return display; }
            set { SetProperty(ref display, value); }
        }

        private string? response;
        public string? Response
        {
            get { return response; }
            set { SetProperty(ref response, value); }
        }

        private string? buttonText;
        public string? ButtonText
        {
            get { return buttonText; }
            set { SetProperty(ref buttonText, value); }
        }
    }
}
