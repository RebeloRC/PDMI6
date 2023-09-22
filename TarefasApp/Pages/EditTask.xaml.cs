namespace TarefasApp.Pages;

public partial class editTask : ContentPage
{
    MainPage.Task globalTask;


	public editTask(List<object> lista, MainPage.Task task)
	{


		InitializeComponent();

        BindingContext = task;


        lista[0] = BindingContext;



    }

    private async void OnSaveClicked(object sender, System.EventArgs e)
    {
        await DisplayAlert("Sucesso", "Tarefa atualizada com sucesso!", "OK");

        await Navigation.PopAsync();

    }
}