using TarefasApp.Pages;

namespace TarefasApp;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();



        // Crie uma lista de tarefas de exemplo
        List<Task> tasks = new List<Task>
            {
                new Task { Title = "Comprar mantimentos", Description = "Leite, ovos, pão, etc." },
                new Task { Title = "Reunião com cliente", Description = "Discutir os requisitos do projeto." },
                new Task { Title = "Academia", Description = "Treino de 30 minutos." },
                new Task { Title = "Ler livro", Description = "Capítulo 3 do livro XYZ." },
                new Task { Title = "Limpar o escritório", Description = "Organizar documentos e limpar a mesa." },
            };

        // Defina a fonte de dados do CollectionView
        taskCollectionView.ItemsSource = tasks;
    }

    private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
        {

            var listaTask= e.CurrentSelection;
            var selectedTask = e.CurrentSelection[0] as Task;
            await Navigation.PushAsync(new editTask(listaTask.ToList(), selectedTask));
            ((CollectionView)sender).SelectedItem = null; // Deselecionar o item


        }
    }

    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}

