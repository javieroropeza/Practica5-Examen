/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/04/2014
 * Time: 04:26 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Examen_Practica
{
	partial class MainForm
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
			this.labNom = new System.Windows.Forms.Label();
			this.texNombre = new System.Windows.Forms.TextBox();
			this.labCod = new System.Windows.Forms.Label();
			this.butEntar = new System.Windows.Forms.Button();
			this.texCodigo = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// labNom
			// 
			this.labNom.Location = new System.Drawing.Point(60, 9);
			this.labNom.Name = "labNom";
			this.labNom.Size = new System.Drawing.Size(100, 24);
			this.labNom.TabIndex = 0;
			this.labNom.Text = "Nombre";
			// 
			// texNombre
			// 
			this.texNombre.Location = new System.Drawing.Point(60, 37);
			this.texNombre.Name = "texNombre";
			this.texNombre.Size = new System.Drawing.Size(174, 20);
			this.texNombre.TabIndex = 1;
			this.texNombre.TextChanged += new System.EventHandler(this.TexNombreTextChanged);
			// 
			// labCod
			// 
			this.labCod.Location = new System.Drawing.Point(60, 73);
			this.labCod.Name = "labCod";
			this.labCod.Size = new System.Drawing.Size(100, 23);
			this.labCod.TabIndex = 2;
			this.labCod.Text = "Codigo";
			// 
			// butEntar
			// 
			this.butEntar.Location = new System.Drawing.Point(158, 141);
			this.butEntar.Name = "butEntar";
			this.butEntar.Size = new System.Drawing.Size(75, 23);
			this.butEntar.TabIndex = 4;
			this.butEntar.Text = "Entrar";
			this.butEntar.UseVisualStyleBackColor = true;
			this.butEntar.Click += new System.EventHandler(this.ButEntarClick);
			// 
			// texCodigo
			// 
			this.texCodigo.Location = new System.Drawing.Point(60, 100);
			this.texCodigo.Name = "texCodigo";
			this.texCodigo.PasswordChar = '*';
			this.texCodigo.Size = new System.Drawing.Size(174, 20);
			this.texCodigo.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.texCodigo);
			this.Controls.Add(this.butEntar);
			this.Controls.Add(this.labCod);
			this.Controls.Add(this.texNombre);
			this.Controls.Add(this.labNom);
			this.Name = "MainForm";
			this.Text = "Examen Practica";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button butEntar;
		private System.Windows.Forms.MaskedTextBox texCodigo;
		private System.Windows.Forms.Label labCod;
		private System.Windows.Forms.TextBox texNombre;
		private System.Windows.Forms.Label labNom;
	}
}
