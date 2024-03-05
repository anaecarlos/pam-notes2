namespace nodes;

public partial class NotePage : ContentPage
{
    string _filepath = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
	public NotePage()
	{
		InitializeComponent();
	}

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_filepath, TextEditor.Text);
        await DisplayAlert("Sucesso", "arquivo salvo com sucesso", "ok");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

    }
}