using System;
using WalletWasabi.Gui.ViewModels;

namespace WalletWasabi.Gui.Tabs
{
	public class LegalDocumentsViewModel : TextResourceViewModelBase
	{
		public LegalDocumentsViewModel() : base("Legal Documents", new Uri("avares://WalletWasabi.Gui/Assets/LegalDocuments.txt"))
		{
		}
	}
}
