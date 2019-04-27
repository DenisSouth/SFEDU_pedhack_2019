/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 26.04.2019
 * Время: 14:43
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace KLAV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button yes;
		private System.Windows.Forms.Button no;
		private System.Windows.Forms.CheckBox vFlag;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.vFlag = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(456, 432);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(96, 36);
            this.yes.TabIndex = 0;
            this.yes.Text = "Да";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(564, 432);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(87, 36);
            this.no.TabIndex = 1;
            this.no.Text = "Нет";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // vFlag
            // 
            this.vFlag.Location = new System.Drawing.Point(0, 444);
            this.vFlag.Name = "vFlag";
            this.vFlag.Size = new System.Drawing.Size(84, 24);
            this.vFlag.TabIndex = 2;
            this.vFlag.Text = "Голос OFF";
            this.vFlag.UseVisualStyleBackColor = true;
            this.vFlag.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 468);
            this.Controls.Add(this.vFlag);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "KLAV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Timer timer1;
    }
}
