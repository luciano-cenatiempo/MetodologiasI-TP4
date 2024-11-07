/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP4
{
	/// <summary>
	/// Description of AlumnoDecoratorLetras.
	/// </summary>
	public class AlumnoDecoratorLetras: AlumnoDecorator
	{
		public AlumnoDecoratorLetras(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			return this.getNombre() + " " + this.getNotaConLetras();
		}
		
		public string getNotaConLetras(){
			switch (getCalificacion()) {
					case 0: return ("0 (CERO)");break;
					case 1: return ("1 (UNO)");break;
					case 2: return ("2 (DOS)");break;
					case 3: return ("3 (TRES)");break;
					case 4: return ("4 (CUATRO)");break;
					case 5: return ("5 (CINCO)");break;
					case 6: return ("6 (SEIS)");break;
					case 7: return ("7 (SIETE)");break;
					case 8: return ("8 (OCHO)");break;
					case 9: return ("9 (NUEVE)");break;
					case 10: return ("10 (DIEZ)");break;
					default: return("0 (CERO)"); break;
					
			}
		}
	}
}
