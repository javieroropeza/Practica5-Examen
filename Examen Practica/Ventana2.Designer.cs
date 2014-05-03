/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/04/2014
 * Time: 03:45 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Examen_Practica
{
	partial class Ventana2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.lab1P = new System.Windows.Forms.Label();
			this.Inciso1P1 = new System.Windows.Forms.CheckBox();
			this.Inciso2P1 = new System.Windows.Forms.CheckBox();
			this.Inciso3P1 = new System.Windows.Forms.CheckBox();
			this.Inciso4P1 = new System.Windows.Forms.CheckBox();
			this.lab2P = new System.Windows.Forms.Label();
			this.Inciso1P2 = new System.Windows.Forms.RadioButton();
			this.Inciso2P2 = new System.Windows.Forms.RadioButton();
			this.Inciso3P2 = new System.Windows.Forms.RadioButton();
			this.lab3P = new System.Windows.Forms.Label();
			this.Inciso1P3 = new System.Windows.Forms.ComboBox();
			this.label4p = new System.Windows.Forms.Label();
			this.Inciso1P4 = new System.Windows.Forms.MonthCalendar();
			this.but2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lab1P
			// 
			this.lab1P.Location = new System.Drawing.Point(30, 29);
			this.lab1P.Name = "lab1P";
			this.lab1P.Size = new System.Drawing.Size(311, 23);
			this.lab1P.TabIndex = 0;
			this.lab1P.Text = "1. Seleccione los paises aliados en la 2 Guerra Mundial";
			this.lab1P.Click += new System.EventHandler(this.Lab1PClick);
			// 
			// Inciso1P1
			// 
			this.Inciso1P1.Location = new System.Drawing.Point(30, 56);
			this.Inciso1P1.Name = "Inciso1P1";
			this.Inciso1P1.Size = new System.Drawing.Size(104, 24);
			this.Inciso1P1.TabIndex = 1;
			this.Inciso1P1.Text = "Reino Unido";
			this.Inciso1P1.UseVisualStyleBackColor = true;
			// 
			// Inciso2P1
			// 
			this.Inciso2P1.Location = new System.Drawing.Point(141, 56);
			this.Inciso2P1.Name = "Inciso2P1";
			this.Inciso2P1.Size = new System.Drawing.Size(104, 24);
			this.Inciso2P1.TabIndex = 2;
			this.Inciso2P1.Text = "Japon";
			this.Inciso2P1.UseVisualStyleBackColor = true;
			// 
			// Inciso3P1
			// 
			this.Inciso3P1.Location = new System.Drawing.Point(228, 55);
			this.Inciso3P1.Name = "Inciso3P1";
			this.Inciso3P1.Size = new System.Drawing.Size(104, 24);
			this.Inciso3P1.TabIndex = 3;
			this.Inciso3P1.Text = "Alemania";
			this.Inciso3P1.UseVisualStyleBackColor = true;
			// 
			// Inciso4P1
			// 
			this.Inciso4P1.Location = new System.Drawing.Point(339, 56);
			this.Inciso4P1.Name = "Inciso4P1";
			this.Inciso4P1.Size = new System.Drawing.Size(104, 24);
			this.Inciso4P1.TabIndex = 4;
			this.Inciso4P1.Text = "Rusia";
			this.Inciso4P1.UseVisualStyleBackColor = true;
			// 
			// lab2P
			// 
			this.lab2P.Location = new System.Drawing.Point(30, 87);
			this.lab2P.Name = "lab2P";
			this.lab2P.Size = new System.Drawing.Size(349, 23);
			this.lab2P.TabIndex = 5;
			this.lab2P.Text = "2. Seleccione el gobernante de Italia durante la 2 Guerra Mundial";
			// 
			// Inciso1P2
			// 
			this.Inciso1P2.Location = new System.Drawing.Point(30, 114);
			this.Inciso1P2.Name = "Inciso1P2";
			this.Inciso1P2.Size = new System.Drawing.Size(104, 24);
			this.Inciso1P2.TabIndex = 6;
			this.Inciso1P2.TabStop = true;
			this.Inciso1P2.Text = "Hittler";
			this.Inciso1P2.UseVisualStyleBackColor = true;
			// 
			// Inciso2P2
			// 
			this.Inciso2P2.Location = new System.Drawing.Point(101, 113);
			this.Inciso2P2.Name = "Inciso2P2";
			this.Inciso2P2.Size = new System.Drawing.Size(104, 24);
			this.Inciso2P2.TabIndex = 7;
			this.Inciso2P2.TabStop = true;
			this.Inciso2P2.Text = "Mussolini";
			this.Inciso2P2.UseVisualStyleBackColor = true;
			// 
			// Inciso3P2
			// 
			this.Inciso3P2.Location = new System.Drawing.Point(212, 114);
			this.Inciso3P2.Name = "Inciso3P2";
			this.Inciso3P2.Size = new System.Drawing.Size(104, 24);
			this.Inciso3P2.TabIndex = 8;
			this.Inciso3P2.TabStop = true;
			this.Inciso3P2.Text = "Berluseomi";
			this.Inciso3P2.UseVisualStyleBackColor = true;
			// 
			// lab3P
			// 
			this.lab3P.Location = new System.Drawing.Point(30, 145);
			this.lab3P.Name = "lab3P";
			this.lab3P.Size = new System.Drawing.Size(311, 23);
			this.lab3P.TabIndex = 9;
			this.lab3P.Text = "3. Numero de estados  de la Republica Mexicana";
			// 
			// Inciso1P3
			// 
			this.Inciso1P3.FormattingEnabled = true;
			this.Inciso1P3.Items.AddRange(new object[] {
									"15",
									"22",
									"38",
									"31"});
			this.Inciso1P3.Location = new System.Drawing.Point(30, 172);
			this.Inciso1P3.Name = "Inciso1P3";
			this.Inciso1P3.Size = new System.Drawing.Size(121, 21);
			this.Inciso1P3.TabIndex = 10;
			this.Inciso1P3.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label4p
			// 
			this.label4p.Location = new System.Drawing.Point(30, 200);
			this.label4p.Name = "label4p";
			this.label4p.Size = new System.Drawing.Size(311, 23);
			this.label4p.TabIndex = 11;
			this.label4p.Text = "4. Fecha de la Independencia de Mexico";
			// 
			// Inciso1P4
			// 
			this.Inciso1P4.Location = new System.Drawing.Point(30, 227);
			this.Inciso1P4.Name = "Inciso1P4";
			this.Inciso1P4.TabIndex = 12;
			// 
			// but2
			// 
			this.but2.Location = new System.Drawing.Point(376, 376);
			this.but2.Name = "but2";
			this.but2.Size = new System.Drawing.Size(75, 23);
			this.but2.TabIndex = 13;
			this.but2.Text = "Contestar";
			this.but2.UseVisualStyleBackColor = true;
			this.but2.Click += new System.EventHandler(this.But2_Click);
			// 
			// Ventana2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 427);
			this.Controls.Add(this.but2);
			this.Controls.Add(this.Inciso1P4);
			this.Controls.Add(this.label4p);
			this.Controls.Add(this.Inciso1P3);
			this.Controls.Add(this.lab3P);
			this.Controls.Add(this.Inciso3P2);
			this.Controls.Add(this.Inciso2P2);
			this.Controls.Add(this.Inciso1P2);
			this.Controls.Add(this.lab2P);
			this.Controls.Add(this.Inciso4P1);
			this.Controls.Add(this.Inciso3P1);
			this.Controls.Add(this.Inciso2P1);
			this.Controls.Add(this.Inciso1P1);
			this.Controls.Add(this.lab1P);
			this.Name = "Ventana2";
			this.Text = "Ventana2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button but2;
		private System.Windows.Forms.MonthCalendar Inciso1P4;
		private System.Windows.Forms.Label label4p;
		private System.Windows.Forms.ComboBox Inciso1P3;
		private System.Windows.Forms.Label lab3P;
		private System.Windows.Forms.RadioButton Inciso3P2;
		private System.Windows.Forms.RadioButton Inciso2P2;
		private System.Windows.Forms.RadioButton Inciso1P2;
		private System.Windows.Forms.Label lab2P;
		private System.Windows.Forms.CheckBox Inciso4P1;
		private System.Windows.Forms.CheckBox Inciso3P1;
		private System.Windows.Forms.CheckBox Inciso2P1;
		private System.Windows.Forms.CheckBox Inciso1P1;
		private System.Windows.Forms.Label lab1P;
	}
}
