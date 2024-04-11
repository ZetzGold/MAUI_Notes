using System.Xml.Linq;

namespace Notes;

public partial class NotesPage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory,"notes.txt");
    //com.whatsapp.media.files
    //com.meta.instagram

    string texto = "";
    public NotesPage()
	{
        InitializeComponent();
        if (File.Exists(path))
        {
            TextEditor.Text = File.ReadAllText(path);
            DisplayAlert("Sucesso", "Arquivo criado com sucesso", "OK");
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        //Ler o que a pessoas digitou
        texto = TextEditor.Text;
        //Armazenar em uma variável
        //Salvar (Criar um arquivo que o conteúdo é o que a pessoa digitou)
        File.WriteAllText(path, texto);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            TextEditor.Text = "";
            DisplayAlert("Sucesso", "Arquivo deletado com sucesso", "OK");
        }
    }
}