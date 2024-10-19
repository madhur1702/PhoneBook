namespace PhoneBook
{
    public partial class App : Application
    {
        public static string DatabasePath => 
            Path.Combine(FileSystem.AppDataDirectory, "PhoneBook.db3");
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PhoneBook());
        }
    }
}
