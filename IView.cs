using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVP
{
	public interface IView
	{
		/// <summary>
		/// Вывод градусов Фаренгейта
		/// </summary>
		void SetFarenheit(double value);

		/// <summary>
		/// Вывод градусов Цельсия
		/// </summary>
		void SetCelsius(double value);

		/// <summary>
		/// Ввод нового значения градусов
		/// </summary>
		double InputDegree { get; }

		/// <summary>
		/// Событие ввода значения по Фаренгейту
		/// </summary>
		event EventHandler<EventArgs> SetFarenheitEvent;

		/// <summary>
		/// Событие ввода значения по цельсию
		/// </summary>
		event EventHandler<EventArgs> SetCelsiusEvent;
	}
}
