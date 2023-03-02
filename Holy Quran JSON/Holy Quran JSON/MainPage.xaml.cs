using Newtonsoft.Json;
using System.Diagnostics;
namespace Holy_Quran_JSON;
public partial class MainPage : ContentPage
{
    List<Root> roots = new List<Root>();
    public MainPage()
    {
        InitializeComponent();
        deserialize();
    }
    public async void deserialize()
    {
        //using var stream = await FileSystem.OpenAppPackageFileAsync("Quran.json");
        string txt;
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        string mainDir = FileSystem.Current.AppDataDirectory;
        var fullpath = Path.Combine(mainDir, "Quran.json");
        Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("Quran.json");
        StreamReader reader = new StreamReader(fileStream);
        txt = reader.ReadToEnd();
        roots = JsonConvert.DeserializeObject<List<Root>>(txt);
        watch.Stop();
        dataList.ItemsSource = roots;
        int i = 0;
    }
    private void Exit(object sender, EventArgs e)
    {
    }
}
