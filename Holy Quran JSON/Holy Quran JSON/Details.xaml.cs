using System.Collections.Generic;
namespace Holy_Quran_JSON;
public partial class Details : ContentPage
{
    public Details(List<Root> roots, int i)
    {
        InitializeComponent();
        IEnumerable<Root> roots1 = roots.Where(o => o.id == i);
        detailedList.ItemsSource = roots1.ToList();
        
    }

    private void back_Clicked(object sender, EventArgs e)
    {

    }

    private async void BackClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}