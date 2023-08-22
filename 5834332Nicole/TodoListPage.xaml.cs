using System.Collections.ObjectModel;
using _5834332Nicole.Data;
using _5834332Nicole.models;
using _5834332Nicole.Views;

namespace _5834332Nicole;

public partial class TodoListPage : ContentPage
{
    TodoItemDatabase database;
    public ObservableCollection<TodoItem> Items { get; set; } = new();
	public TodoListPage(TodoItemDatabase todoItemsDatabase)
	{
		InitializeComponent();
        database = todoItemsDatabase;
        BindingContext = this;
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var items = await database.GetItemsAsync();
        MainThread.BeginInvokeOnMainThread(() =>
        {

            Items.Clear();
            foreach (var item in items)
                Items.Add(item);

        });

    }

         private async void CollectionView_SelectionChangend(object sender, SelectionChangedEventArgs e)
    {
         if  (e.CurrentSelection.FirstOrDefault() is not TodoItem item)
                return;

            await Shell.Current.GoToAsync(nameof(TodoItemPage), true, new Dictionary<string, object>
            {
                ["Item"] = item
            });
    }
}