namespace MauiApp4;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        AgeLabel.Text = $"Ile lat ? 1";
    }


    private void EntryButton_Clicked(object sender, EventArgs e)
    {
        string name = EntryName.Text;
        string animal = PickerEntry.SelectedItem?.ToString();
        int age = (int)SliderEntry.Value;
        string reason = EntryReason.Text;


        DisplayAlert("test", $"{name},{animal},{age},{reason}", "ok");
        ResultLabel.Text = $"{name},{animal},{age},{reason}";
    }

    private void PickerEntry_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selected = PickerEntry.SelectedItem?.ToString();

        switch (selected)
        {
            case "Pies":
                SliderEntry.Maximum = 18;
                break;

            case "Kot":
                SliderEntry.Maximum = 20;
                break;

            case "Œwinka morska":
                SliderEntry.Maximum = 9;
                break;
        }
    }

    private void SliderEntry_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int age = (int)e.NewValue;
        AgeLabel.Text = $"Ile lat ? {age}";
    }
}