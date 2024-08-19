using CommunityToolkit.Mvvm.ComponentModel;

namespace ApplyQueryAttributes.ViewModels
{
    public class ViewModelBase : ObservableObject, IQueryAttributable
    {
        protected ViewModelBase()
        {

        }

        #region Lifecycle

        public virtual async Task Initialise()
        {
            
        }

        public virtual void OnAppearing()
        {
            
        }

        public virtual void OnNavigatedTo(NavigatedToEventArgs args)
        {
            
        }

        public virtual void OnNavigatingFrom(NavigatingFromEventArgs args)
        {
            
        }

        public virtual void OnNavigatedFrom(NavigatedFromEventArgs args)
        {
            
        }

        public virtual void OnDisappearing()
        {
            
        }

        public virtual void Destroy()
        {
            
        }

        public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
        {

        }

        #endregion
    }
}
