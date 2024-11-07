/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP4
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno : Comparable
	{
		string getNombre();
		
		int getLegajo();

        int getPromedio();

        void setCalificacion(int calificacion);

        int getCalificacion();

        int responderPregunta(int pregunta);

        string mostrarCalificacion();

    }
		
	
}
