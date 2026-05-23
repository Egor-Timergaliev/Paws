namespace Paws
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            count = Preferences.Get("counter_value", 0);

            CounterLabel.Text = count.ToString();
        }

        private void OnPlusClicked(object sender, EventArgs e)
        {
            count++;

            CounterLabel.Text = count.ToString();

            Preferences.Set("counter_value", count);
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            count = 0;

            CounterLabel.Text = count.ToString();

            Preferences.Set("counter_value", count);
        }
    }
}