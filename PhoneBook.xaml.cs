using PhoneBook.Models;
using SQLite;

namespace PhoneBook;

public partial class PhoneBook : ContentPage
{
	public PhoneBook()
	{
		InitializeComponent();
        try
        {
            SQLiteConnection con = new SQLiteConnection(App.DatabasePath);

            var data = con.Query<MyContacts>("SELECT * FROM MyContacts");
            mYlISTvIEW.ItemsSource = data;
            con.Close();
        }
        catch (Exception E) { }
    }

    protected override void OnAppearing()
    {
        try
        {
            SQLiteConnection con = new SQLiteConnection(App.DatabasePath);

            var data = con.Query<MyContacts>("SELECT * FROM MyContacts");
            mYlISTvIEW.ItemsSource = data;
            con.Close();
        }
        catch (Exception E) { }
    }

    private void AddContact_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CreateNewContact());
    }
}