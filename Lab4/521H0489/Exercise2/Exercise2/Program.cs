namespace Exercise2
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var homeScreenForm = new HomeForm();

            var updateTextBoxDelegate = new UpdateTextBoxDelegate(homeScreenForm.UpdateTextBox);
            homeScreenForm.SetUpdateTextBoxDelegate(updateTextBoxDelegate);

            Application.Run(homeScreenForm);
        }
    }
}