using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVP
{
	public class Presenter
	{
		private Model _model = new Model();
		private IView _view;

		/// <summary>
		/// В конструтор передается конкретный экземпляр представления
		/// и происходит подписка на все нужные события.
		/// <summary>
		public Presenter(IView view)
		{
			_view = view;
			_view.SetCelsiusEvent += new EventHandler<EventArgs>(OnSetCelsius);
			_view.SetFarenheitEvent += new EventHandler<EventArgs>(OnSetFarenheit);
			RefreshView();
		}

		/// <summary>
		/// Обработка события, установка нового значения градусов по Фаренгейту
		/// </summary>
		private void OnSetFarenheit(object sender, EventArgs e)
		{
			_model.valueFahrenheit = _view.InputDegree;
			RefreshView();
		}

		/// <summary>
		/// Обработка события, установка нового значения градусов Цельсия
		/// </summary>
		private void OnSetCelsius(object sender, EventArgs e)
		{
			_model.valueCelsius = _view.InputDegree;
			RefreshView();
		}

		/// <summary>
		/// Обновление Представления новыми значениями модели.
		/// По сути Binding (привязка) значений модели к Представлению. 
		/// </summary>
		private void RefreshView()
		{
			_view.SetCelsius(_model.valueCelsius);
			_view.SetFarenheit(_model.valueFahrenheit);
		}
	}
}
