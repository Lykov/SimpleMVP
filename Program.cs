using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMVP
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			FormView view = new FormView();
			Presenter presenter = new Presenter(view);
			Application.Run(view);
		}
	}
}
