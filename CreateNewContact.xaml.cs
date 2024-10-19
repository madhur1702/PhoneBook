using PhoneBook.Models;
using SQLite;


namespace PhoneBook;

public partial class CreateNewContact : ContentPage
{
	public CreateNewContact()
	{
		InitializeComponent();
		

    }

    private void Save_Button_Clicked(object sender, EventArgs e)
    {
		SQLiteConnection con = new SQLiteConnection(App.DatabasePath);

		con.Table<MyContacts>();

		MyContacts mc = new MyContacts();
		mc.EMAIL = Email_Entry.Text.ToLower();
		mc.UNAME = FullName_Enter.Text.ToUpper();
		mc.PH1 = Ph1_Entry.Text;
		mc.PH2 = Ph2_Entry.Text;

		var result =  con.Insert(mc);
		if (result == 1) { DisplayAlert("","Data Inserted Successfully","Ok"); }


		
		con.Close();


		
    }
}