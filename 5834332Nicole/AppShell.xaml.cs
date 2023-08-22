using _5834332Nicole.models;
using _5834332Nicole.Views;

namespace _5834332Nicole;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
	}
}
