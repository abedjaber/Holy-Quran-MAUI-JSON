﻿namespace Holy_Quran_JSON;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    /*
	 * 
	 * // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Array
    {
        public int id { get; set; }
        public string ar { get; set; }
        public string en { get; set; }
        public string filename { get; set; }
        public string path { get; set; }
        public string dir { get; set; }
        public int size { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public string name_en { get; set; }
        public string name_translation { get; set; }
        public int words { get; set; }
        public int letters { get; set; }
        public string type { get; set; }
        public string type_en { get; set; }
        public string ar { get; set; }
        public string en { get; set; }
        public List<Array> array { get; set; }
    }


	 * 
	 * 
	 * 
	 * 
	 * 
	 * */


}

