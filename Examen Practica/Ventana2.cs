/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/04/2014
 * Time: 03:45 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_Practica
{
	/// <summary>
	/// Description of Ventana2.
	/// </summary>
	public partial class Ventana2 : Form
	{
		int puntos =0;	
		public Ventana2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Lab1PClick(object sender, EventArgs e)
		{
			
		}
		
		
		void But2_Click(object sender, EventArgs e)
		{
			puntos = 0;
			 if( this.Inciso1P4.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
			 	
				puntos += 1;
				
			}
			//MessageBox.Show( puntos.ToString() );
			 
			 if( this.Inciso1P3.Text == "31"){
			 	
				puntos += 1;
				
			}
			//MessageBox.Show( puntos.ToString() );
		
			if( this.Inciso2P2.Checked){
				
				puntos += 1;
				
			}
			//MessageBox.Show( puntos.ToString() );
			if( this.Inciso4P1.Checked){
				
				puntos += 1;
				
			}
			//MessageBox.Show( puntos.ToString() );
			if( this.Inciso1P1.Checked ){
				
				puntos += 1;
				
			}
			 //MessageBox.Show( puntos.ToString() );
			 if(this.puntos ==5){
				MessageBox.Show( " "+this.puntos +" de 5 " + "Felicidades Calificacion Perfecta");
			 }else 
			 	MessageBox.Show( " "+this.puntos +" de 5 " );
		}
	}
}
