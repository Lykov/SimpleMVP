using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMVP
{
	public partial class FormView : Form, IView
	{
		public event EventHandler<EventArgs> SetFarenheitEvent;
		public event EventHandler<EventArgs> SetCelsiusEvent;
		public FormView()
		{
			InitializeComponent();
		}
		#region Реализация IView

		/// <summary>
		/// Вывод градусов Фаренгейта
		/// </summary>
		public void SetFarenheit(double value)
		{
			_fahrenheitBox.Text = "F " + value.ToString("N2");
		}

		/// <summary>
		/// Вывод градусов Цельсия
		/// </summary>
		public void SetCelsius(double value)
		{
			_celsiusBox.Text = "C " + value.ToString("N2");
		}

		/// <summary>
		/// Ввод нового значения градусов
		/// </summary>
		public double InputDegree
		{
			get { return Convert.ToDouble(_inputBox.Text); }
		}

		#endregion

		/// <summary>
		/// Обработка событий тоже примитивна, они просто пробрасываются
		/// в соответствующие события Presenter-а
		/// </summary>
		private void _celsiusButton_Click(object sender, EventArgs e)
		{
			if (SetCelsiusEvent != null)
				SetCelsiusEvent(this, EventArgs.Empty);
		}

		private void _farenheitButton_Click(object sender, EventArgs e)
		{
			if (SetFarenheitEvent != null)
				SetFarenheitEvent(this, EventArgs.Empty);
		}
	}
}
