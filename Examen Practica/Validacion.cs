/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/04/2014
 * Time: 03:38 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Examen_Practica
{
	/// <summary>
	/// Description of Validacion.
	/// </summary>
	public class Validacion
	{
		private String Nombre;
		private String Codigo;
		
		
		public Validacion( String Nombre, String Codigo)
		{
			this.Nombre = Nombre;
			this.Codigo = Codigo;
		}
		public bool Accesar (){
			return(this.Nombre=="Javier" && this.Codigo=="2132");
		}
			
	}
}
