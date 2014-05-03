/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/04/2014
 * Time: 04:26 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_Practica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: Implement MainForm_Load
		}
		
		void ButEntarClick(object sender, EventArgs e)
		{
			Validacion validacion = new Validacion(this.texNombre.Text,this.texCodigo.Text);
			if( validacion.Accesar()){
				Ventana2 ventana = new Ventana2();
				ventana.Show();
				this.Hide();
			}else{
				MessageBox.Show("Datos incorrectos contraseña o nombre incorrecto "  +this.texNombre.Text);
			}			
		}
		
		void TexNombreTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
