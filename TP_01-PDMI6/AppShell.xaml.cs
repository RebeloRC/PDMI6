//Author: Rodrigo Rebelo & Luiz Gustavo

using TP_01_PDMI6.Pages;

namespace TP_01_PDMI6;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CreditsPage), typeof(CreditsPage));
	}
}
