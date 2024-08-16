
using System.ComponentModel.Design;

namespace PAMNotes
{
    public partial class MainPage : ContentPage
    {
        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                NoteEdt.Text = File.ReadAllText(filePath);
            }
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            string Notes = NoteEdt.Text;
            File.WriteAllText(filePath, Notes);
            DisplayAlert("Sucesso!", "Operação concluida com sucesso!", "Ok");
        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(filePath)) {

                File.Delete(filePath);
                DisplayAlert("Operação concluida!", "Arquivo apagado com sucesso!", "Ok");
                NoteEdt.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Alerta!", "Arquivo não encontrado", "Ok");


            }
        }
            
        

    }

}
