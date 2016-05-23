namespace SimpleMVP
{
	partial class FormView
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this._inputBox = new System.Windows.Forms.TextBox();
			this._celsiusButton = new System.Windows.Forms.Button();
			this._farenheitButton = new System.Windows.Forms.Button();
			this._fahrenheitBox = new System.Windows.Forms.Label();
			this._celsiusBox = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _inputBox
			// 
			this._inputBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._inputBox.Location = new System.Drawing.Point(110, 6);
			this._inputBox.Name = "_inputBox";
			this._inputBox.Size = new System.Drawing.Size(120, 20);
			this._inputBox.TabIndex = 2;
			// 
			// _celsiusButton
			// 
			this._celsiusButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._celsiusButton.Location = new System.Drawing.Point(77, 42);
			this._celsiusButton.Name = "_celsiusButton";
			this._celsiusButton.Size = new System.Drawing.Size(75, 23);
			this._celsiusButton.TabIndex = 3;
			this._celsiusButton.Text = "C";
			this._celsiusButton.UseVisualStyleBackColor = true;
			this._celsiusButton.Click += new System.EventHandler(this._celsiusButton_Click);
			// 
			// _farenheitButton
			// 
			this._farenheitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._farenheitButton.Location = new System.Drawing.Point(172, 42);
			this._farenheitButton.Name = "_farenheitButton";
			this._farenheitButton.Size = new System.Drawing.Size(75, 23);
			this._farenheitButton.TabIndex = 4;
			this._farenheitButton.Text = "F";
			this._farenheitButton.UseVisualStyleBackColor = true;
			this._farenheitButton.Click += new System.EventHandler(this._farenheitButton_Click);
			// 
			// _fahrenheitBox
			// 
			this._fahrenheitBox.AutoSize = true;
			this._fahrenheitBox.Location = new System.Drawing.Point(12, 39);
			this._fahrenheitBox.Name = "_fahrenheitBox";
			this._fahrenheitBox.Size = new System.Drawing.Size(13, 13);
			this._fahrenheitBox.TabIndex = 5;
			this._fahrenheitBox.Text = "F";
			// 
			// _celsiusBox
			// 
			this._celsiusBox.AutoSize = true;
			this._celsiusBox.Location = new System.Drawing.Point(12, 9);
			this._celsiusBox.Name = "_celsiusBox";
			this._celsiusBox.Size = new System.Drawing.Size(14, 13);
			this._celsiusBox.TabIndex = 6;
			this._celsiusBox.Text = "C";
			// 
			// FormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 73);
			this.Controls.Add(this._celsiusBox);
			this.Controls.Add(this._fahrenheitBox);
			this.Controls.Add(this._farenheitButton);
			this.Controls.Add(this._celsiusButton);
			this.Controls.Add(this._inputBox);
			this.Name = "FormView";
			this.Text = "Конвертируем градусы";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _inputBox;
		private System.Windows.Forms.Button _celsiusButton;
		private System.Windows.Forms.Button _farenheitButton;
		private System.Windows.Forms.Label _fahrenheitBox;
		private System.Windows.Forms.Label _celsiusBox;
	}
}

