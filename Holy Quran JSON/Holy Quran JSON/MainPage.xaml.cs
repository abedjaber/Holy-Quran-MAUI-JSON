using Newtonsoft.Json;

namespace Holy_Quran_JSON;
public partial class MainPage : ContentPage
{
    List<Root> roots= new List<Root>();
    public MainPage()
    {
        InitializeComponent();
        deserialize();
    }
    public async void deserialize()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("Quran.json");
        int i = 0;

    }
}
