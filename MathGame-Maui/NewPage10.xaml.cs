using System.Data;

namespace MathGameMobile;

public partial class NewPage10 : ContentPage
{
    class clsItems
    {
        public string Name { get; set; }

        public int ID { get; set; }
    }
	public NewPage10()
	{
		InitializeComponent();

        

        collecation1.ItemsSource = getall();

    }



    private List<clsItems> getall()
    {
        return dt = new List<clsItems>
        {
            new clsItems {Name = "Abdullah" , ID = 1},
            new clsItems {Name = "Abdullah" , ID = 1},
            new clsItems {Name = "Abdullah" , ID = 1},
            new clsItems {Name = "Abdullah" , ID = 1},
            new clsItems {Name = "Abdullah" , ID = 1},
        };
    }

    List<clsItems> dt;




}