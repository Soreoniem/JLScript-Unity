// Versión 3.1.0
/* Info versiones
	1.0.0	: Enorme modificación que afecta a todo el código.
	0.1.0	: Modificar, Eliminar o Añadir una función.
	0.0.1	: Correcciones menores o de errores.

	(Info añadida en la versión 3.1.0)
*/
using System;
using System.Collections.Generic;	// Arrays
using System.Linq;                  // Array.Where
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JLScript{
	static public class JL{
		// Creo recordar que había un problema de precisión de datos si sumaba
		// un int a un boleano y no hera preciso,
		// por lo que por precaución uso 2 variables para el random.
		static private int		aleatorioActual_int		= UnityEngine.Random.Range(0, 11);
		static private float	aleatorioActual_float	= UnityEngine.Random.Range(0f, 11f);

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				▼ Actual: Vacío
			</summary>
		*/
		static public void Log(){
			Debug.Log("\n");
		}

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				<em>Nota: Mismo que Log pero usando Warning</em><br/>
				▼ Actual: Vacío
			</summary>
		*/
		static public void LogWarning(){
			Debug.LogWarning("\n");
		}

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				▼ Actual: 1 Parámetro
			</summary>

			<param name="mensaje">Texto.</param>
		*/
		static public void Log(object mensaje){
			Debug.Log(mensaje +"\n");
		}

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				<em>Nota: Mismo que Log pero usando Warning</em><br/>
				▼ Actual: 1 Parámetro
			</summary>

			<param name="mensaje">Texto.</param>
		*/
		static public void LogWarning(object mensaje){
			Debug.LogWarning(mensaje +"\n");
		}

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				▼ Actual: Lista
			</summary>

			<param name="mensaje">Lista de datos.</param>
		*/
		static public void Log(List<object> mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Count ; i++ ){
				mensajeFormateado += "\n"+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.Log(mensajeFormateado.Substring(1) +"\n");
		}

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				<em>Nota: Mismo que Log pero usando Warning</em><br/>
				▼ Actual: Lista
			</summary>

			<param name="mensaje">Lista de datos.</param>
		*/
		static public void LogWarning(List<object> mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Count ; i++ ){
				mensajeFormateado += "\n"+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.LogWarning(mensajeFormateado.Substring(1) +"\n");
		}

		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				▼ Actual: Array o Parámetros (del mismo tipo)
			</summary>

			<param name="mensaje">Array o Parámetros infinitos</param>
		*/
		static public void Log(params object[] mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Length ; i++ ){
				mensajeFormateado += "\n"+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.Log(mensajeFormateado.Substring(1) +"\n");
		}
		
		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título para imprimir (titulo, datos)<br/>
				<em>Nota: Mismo que Log pero usando Warning</em><br/>
				▼ Actual: Array o Parámetros (del mismo tipo)
			</summary>

			<param name="mensaje">Array o Parámetros infinitos</param>
		*/
		static public void LogWarning(params object[] mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Length ; i++ ){
				mensajeFormateado += "\n"+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.LogWarning(mensajeFormateado.Substring(1) +"\n");
		}
		
		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título al visualizar la Lista.<br/>
				▼ Actual: Titulo + Lista
			</summary>

			<param name="titulo">Titulo para imprimir</param>
			<param name="mensaje">Lista de datos.</param>
		*/
		static public void Log(string titulo, List<object> mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Count ; i++ ){
				mensajeFormateado += "\n["+ i +"] "+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.Log("---[ "+ titulo +" ]---"+ mensajeFormateado +"\n");
		}
		
		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título al visualizar la Lista.<br/>
				<em>Nota: Mismo que Log pero usando Warning</em><br/>
				▼ Actual: Titulo + Lista
			</summary>

			<param name="titulo">Titulo para imprimir</param>
			<param name="mensaje">Lista de datos.</param>
		*/
		static public void LogWarning(string titulo, List<object> mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Count ; i++ ){
				mensajeFormateado += "\n["+ i +"] "+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.LogWarning("---[ "+ titulo +" ]---"+ mensajeFormateado +"\n");
		}
		
		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título al visualizar el Array.<br/>
				▼ Actual: Titulo + Array
			</summary>

			<param name="titulo">Titulo para imprimir</param>
			<param name="mensaje">Array o Parámetros infinitos</param>
		*/
		static public void Log(string titulo, object[] mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Length ; i++ ){
				mensajeFormateado += "\n["+ i +"] "+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.Log("---[ "+ titulo +" ]---"+ mensajeFormateado +"\n");
		}
		
		/** <summary>
				Escribe por consola o cada parámetro que le pongas.<br/>
				Imprime cada elemento del Array o Lista.<br/>
				Permite poner un título al visualizar el Array.<br/>
				<em>Nota: Mismo que Log pero usando Warning</em><br/>
				▼ Actual: Titulo + Array
			</summary>

			<param name="titulo">Titulo para imprimir</param>
			<param name="mensaje">Array o Parámetros infinitos</param>
		*/
		static public void LogWarning(string titulo, object[] mensaje){
			string mensajeFormateado = "";
			for( int i=0 ; i<mensaje.Length ; i++ ){
				mensajeFormateado += "\n["+ i +"] "+ mensaje[i];
			}

			// Quita el salto de línea inicial e imprime el resultado
			Debug.LogWarning("---[ "+ titulo +" ]---"+ mensajeFormateado +"\n");
		}

		/**	<summary>
			Reorganiza las variables solo si no cuadran con el mayor o menor.<br/>
			<em>Nota: No hace nara si mayor ya es el mayor de los 2 números.</em>
		</summary>
		
		<param name="menor">Se modificará si no es el menor de los 2 números.</param>
	   	<param name="mayor">Se modificará si no es el menor de los 2 números.</param>
	    */
		static public void OrdenarMinMax(ref int menor, ref int mayor){
			if(menor > mayor){
				int min_backup = menor;
				menor = mayor;
				mayor = min_backup;
			}
		}

		/**	<summary>
			Reorganiza las variables solo si no cuadran con el mayor o menor.<br/>
			<em>Nota: No hace nara si mayor ya es el mayor de los 2 números.</em>
		</summary>
		
		<param name="menor">Se modificará si no es el menor de los 2 números.</param>
		<param name="mayor">Se modificará si no es el menor de los 2 números.</param>
	    */
		static public void OrdenarMinMax(ref float menor, ref float mayor){
			if(menor > mayor){
				float min_backup = menor;
				menor = mayor;
				mayor = min_backup;
			}
		}

		/**	<summary>
				Obtiene la distancia entre los 2 números.
			</summary>
		
			<param name="num1">Primer número</param>
			<param name="num2">2º número</param>
		
			<returns>Distancia entre los números.</returns>
	    */
		static public int Distancia2Numeros(int num1, int num2){
			OrdenarMinMax(ref num1, ref num2);
			
			// Tienen signos diferentes
			if(num1 < 0 && 0 < num2){
				return (int)(Mathf.Abs(num1) + Mathf.Abs(num2));
			}
			// Signos iguales
			else {
				// Max - Min + 1
				return num2 - num1;
			}
		}

		/**	<summary>
				Obtiene un punto medio entre el vector Inicio y Final.<br/>
				Se especifica con un porcentaje el vector objetivo (50% es en medio de los 2 vectores)
			</summary>
			
			<param name="inicio">Punto de origen.</param>
			<param name="final">Punto final.</param>
			<param name="porcentaje">50f (50%) sería en medio de los 2 puntos</param>
			
			<returns>Vector entre Inicio y Final.</returns>
	    */
		static public Vector3 Entre2Vectores(Vector3 inicio, Vector3 final, float porcentaje = 50f){
			// Almacenar la distancia entre el Vector de inicio y final según el porcentaje.
			Vector3 resultado = new Vector3(
				porcentaje * JL.Distancia2Numeros(inicio.x, final.x) / 100f,
				porcentaje * JL.Distancia2Numeros(inicio.y, final.y) / 100f,
				porcentaje * JL.Distancia2Numeros(inicio.z, final.z) / 100f
			);

			// Sumar o restar dependiendo de cada coordenada.
			// (Si inicio es más grande, hay que restar, de lo contrario hay que sumar)
			resultado.x = (inicio.x < final.x)
				? inicio.x + resultado.x
				: inicio.x - resultado.x
			;
			resultado.y = (inicio.y < final.y)
				? inicio.y + resultado.y
				: inicio.y - resultado.y
			;
			resultado.z = (inicio.z < final.z)
				? inicio.z + resultado.z
				: inicio.z - resultado.z
			;
			
			return resultado;
		}

		/**	<summary>
			Obtiene la distancia entre los 2 números.
		</summary>
		
		<param name="num1">Primer número</param>
		<param name="num2">2º número</param>
		
		<returns>Distancia entre los números.</returns>
	    */
		static public float Distancia2Numeros(float num1, float num2){
			OrdenarMinMax(ref num1, ref num2);
			
			// Tienen signos diferentes
			if(num1 < 0 && 0 < num2){
				return (Mathf.Abs(num1) + Mathf.Abs(num2));
			}
			// Signos iguales
			else {
				// Max - Min
				return num2 - num1;
			}
		}

		/**	<summary>
			Se pueden obtener aleatorios dependiendo de los parametros obtenidos.<br/>
			Parámetros:
			<list type="bullet">
				<item>
					<description>[ Bool ]: 0 Parámetros.</description>
				</item>
				<item>
					<description>String: Palabra.</description>
				</item>
				<item>
					<description>Float.</description>
				</item>
				<item>
					<description>Int.</description>
				</item>
				<item>
					<description>Lista: 1 Dato.</description>
				</item>
				<item>
					<description>Array o Parámetros: 1 Dato.</description>
				</item>
			</list>
			</summary>
			
			<returns>Boleano.</returns>
		*/
		static public bool Aleatorio(){
			return Aleatorio(0, 1) == 1;
		}

		/**	<summary>
			Se pueden obtener aleatorios dependiendo de los parametros obtenidos.<br/>
			Parámetros:
			<list type="bullet">
				<item>
					<description>Bool: 0 Parámetros.</description>
				</item>
				<item>
					<description>[ String ]: Palabra.</description>
				</item>
				<item>
					<description>Float.</description>
				</item>
				<item>
					<description>Int.</description>
				</item>
				<item>
					<description>Lista: 1 Dato.</description>
				</item>
				<item>
					<description>Array o Parámetros: 1 Dato.</description>
				</item>
			</list>
			▼ Frase de la que obtendrás una palabra.
			</summary>

			<param name="texto">Frase.</param>
			
			<returns>Palabra de la frase.</returns>
		*/
		static public string Aleatorio(string texto){
			// Quitar espacios extra
			// Convertir a array para separar las palabras
			string[] texto_array = QuitarEspacios(texto).Split(' ');

			return texto_array[Aleatorio(0, (texto_array.Length -1))];
		}

		/**	<summary>
			Se pueden obtener aleatorios dependiendo de los parametros obtenidos.<br/>
			Parámetros:
			<list type="bullet">
				<item>
					<description>Bool: 0 Parámetros.</description>
				</item>
				<item>
					<description>String: Palabra.</description>
				</item>
				<item>
					<description>[ Float ].</description>
				</item>
				<item>
					<description>Int.</description>
				</item>
				<item>
					<description>Lista: 1 Dato.</description>
				</item>
				<item>
					<description>Array o Parámetros: 1 Dato.</description>
				</item>
			</list>
			▼ Número minimo y máximo del aleatorio.
			</summary>

			<param name="min">Mínimo.</param>
			<param name="max">Máximo.</param>
			
			<returns>Float.</returns>
		*/
		static public float Aleatorio(float min, float max=100f){
			// Si son iguales, devolver el único valor posible
			if(min == max){
				return min;
			}

			//return UnityEngine.Random.Range(minimo, maximo);

			// Ordenar mínimo y máximo por si acaso.
			OrdenarMinMax(ref min, ref max);

			// Cambiar aleatorio
			aleatorioActual_float += UnityEngine.Random.Range(min, max);
			
			float distRango = Distancia2Numeros(min, max);

			// Variables
			int numMulti;
			float distancia;

			if(max < aleatorioActual_float){
				// Obtener la distancia entre el máximo y el número guardado.
				distancia = Distancia2Numeros(max, aleatorioActual_float);

				// Calcular el número de multiplicaciones necesarias.
				numMulti = Mathf.FloorToInt(distancia / distRango);

				// Si no es una reducción exacta hay que aumentar un poco más.
				if(distancia % distRango != 0){
					numMulti++;
				}
					
				return aleatorioActual_float -= numMulti * distRango;
			}
			// Si el aleatorio es inferior al rango
			else if(aleatorioActual_float < min){
				// Obtener distancia entre el mínimo y el número guardado.
				distancia = Distancia2Numeros(min, aleatorioActual_float);

				// Calcular el número de multiplicaciones necesarias
				numMulti = Mathf.FloorToInt(distancia /distRango);
				
				// Si no es una reducción exacta hay que aumentar un poco más.
				if(distancia % distRango != 0){
					numMulti++;
				}

				return aleatorioActual_float += numMulti * distRango;
			}
			// Si por un casual el aleatorio guardado se queda justo en el rango.
			else {
				return aleatorioActual_float;
			}
		}

		/**	<summary>
			Se pueden obtener aleatorios dependiendo de los parametros obtenidos.<br/>
			Parámetros:
			<list type="bullet">
				<item>
					<description>Bool: 0 Parámetros.</description>
				</item>
				<item>
					<description>String: Palabra.</description>
				</item>
				<item>
					<description>Float.</description>
				</item>
				<item>
					<description>[ Int ].</description>
				</item>
				<item>
					<description>Lista: 1 Dato.</description>
				</item>
				<item>
					<description>Array o Parámetros: 1 Dato.</description>
				</item>
			</list>
			▼ Número minimo y máximo del aleatorio.
			</summary>

			<param name="min">Mínimo.</param>
			<param name="max">Máximo.</param>
			
			<returns>Int.</returns>
		*/
		// Aleatorio de enteros
		static public int Aleatorio(int min, int max=100){
			// Si son iguales, devolver el único valor posible
			if(min == max){
				return min;
			}

			// Ordenar mínimo y máximo por si acaso
			OrdenarMinMax(ref min, ref max);

			// +1 por que no coge un número menos del máximo.
			aleatorioActual_int += UnityEngine.Random.Range(min, (max +1));
			
			int cantNumeros = Distancia2Numeros(min, max) +1;
			
			// Variables
			int distancia, numMulti;
			
			// Si el aleatorio es superior al rango
			if(max < aleatorioActual_int){
				// Obtener distancia entre el máximo y el número guardado.
				distancia = Distancia2Numeros(max, aleatorioActual_int);
				
				// Calcular el número de multiplicaciones necesarias
				numMulti = Mathf.FloorToInt(distancia /(float)cantNumeros);
				
				// Si no es una reducción exacta hay que aumentar un poco más.
				if(distancia % (float)cantNumeros != 0){
					numMulti++;
				}

				
				return aleatorioActual_int -= numMulti * cantNumeros;
			}
			// Si el aleatorio es inferior al rango
			else if(aleatorioActual_int < min){
				// Obtener distancia entre el mínimo y el número guardado.
				distancia = Distancia2Numeros(min, aleatorioActual_int);

				// Calcular el número de multiplicaciones necesarias
				numMulti = Mathf.FloorToInt(distancia /(float)cantNumeros);
				
				// Si no es una reducción exacta hay que aumentar un poco más.
				if(distancia % (float)cantNumeros != 0){
					numMulti++;
				}

				return aleatorioActual_int += numMulti * cantNumeros;
			}
			// Si por un casual el aleatorio guardado se queda justo en el rango.
			else {
				return aleatorioActual_int;
			}
		}

		/**	<summary>
			Se pueden obtener aleatorios dependiendo de los parametros obtenidos.<br/>
			Parámetros:
			<list type="bullet">
				<item>
					<description>Bool: 0 Parámetros.</description>
				</item>
				<item>
					<description>String: Palabra.</description>
				</item>
				<item>
					<description>Float.</description>
				</item>
				<item>
					<description>Int.</description>
				</item>
				<item>
					<description>[ List ]: 1 Dato.</description>
				</item>
				<item>
					<description>Array o Parámetros: 1 Dato.</description>
				</item>
			</list>
			▼ Cualquier tipo de Lista.
			</summary>

			<param name="datos">Lista de datos.</param>
			
			<returns>1 Dato de la Lista.</returns>
		*/
		static public T Aleatorio<T>(List<T> datos){
			return datos[Aleatorio(0, (datos.Count - 1))];
		}

		/**	<summary>
			Se pueden obtener aleatorios dependiendo de los parametros obtenidos.<br/>
			Parámetros:
			<list type="bullet">
				<item>
					<description>Bool: 0 Parámetros.</description>
				</item>
				<item>
					<description>String: Palabra.</description>
				</item>
				<item>
					<description>Float.</description>
				</item>
				<item>
					<description>Int.</description>
				</item>
				<item>
					<description>Lista: 1 Dato.</description>
				</item>
				<item>
					<description>[ Array o Parámetros ]: 1 Dato.</description>
				</item>
			</list>
			▼ Puedes poner parámetros sueltos (del mismo tipo) o un Array.
			</summary>

			<param name="datos">Array o Parámetros.</param>
			
			<returns>1 Dato de los aportados.</returns>
		*/
		static public T Aleatorio<T>(params T[] datos){
			return datos[Aleatorio(0, (datos.Length -1))];
		}

		/**	<summary>
				Obtén un Color aleatorio.<br/>
				Permite activar si se quiere el color Alfa aleatorio.<br/>·<br/>
				▼ Actual: Color o Color con Alfa
			</summary>

			<param name="alfa">Activa el color con alfa aleatorio.</param>
	
			<returns>Color aleatorio.</returns>
		*/
		static public Color Aleatorio_Color(bool alfa=false){
			return (!alfa)
				? new Color(
					((float)(Aleatorio(0, 100))/100),	// R
					((float)(Aleatorio(0, 100))/100),	// G
					((float)(Aleatorio(0, 100))/100)	// B
				): new Color(
					((float)(Aleatorio(0, 100))/100),	// R
					((float)(Aleatorio(0, 100))/100),	// G
					((float)(Aleatorio(0, 100))/100),	// B
					((float)(Aleatorio(0, 100))/100)	// A
			);
		}
		
		/**	<summary>
				Obtén un Color aleatorio.<br/>
				Permite activar si se quiere el color Alfa aleatorio.<br/>
				También puedes especificar un color Alfa fijo.<br/>·<br/>
				▼ Actual: Color con Alfa Fijo
			</summary>

			<param name="alfa">Numéro de 0 a 255.</param>
	
			<returns>Color aleatorio con Alfa Fijo.</returns>
		*/
		static public Color Aleatorio_Color(float alfa){
			return new Color(
				((float)(Aleatorio(0, 100))/100),	// R
				((float)(Aleatorio(0, 100))/100),	// G
				((float)(Aleatorio(0, 100))/100),	// B
				alfa								// A
			);
		}

		/**	<summary>
				Convierte un texto en flotante sin importar el tipo de separación decimal (Punto o Coma).
			</summary>
		
			<param name="numTexto">Texto a convertir en Float.</param>
			<param name="numPredeterminado">Número que devolverá si falla la conversión.</param>
		
			<returns>Texto convertido a float.</returns>
		*/
		static public float Parse(string numTexto, float numPredeterminado = 0f){
			// Primer intento
			if(! float.TryParse(numTexto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out numPredeterminado)){
				// Puede fallar si viene con un punto o coma (No se por que ya que tiene el "InvariantCulture" que se la pasa por el forro)
				float.TryParse(numTexto, out numPredeterminado);
			}
			
			// Devolver el número convertido o el predeterminado si no consigue conmertir en número.
			return numPredeterminado;
		}

		/**	<summary>
				Convierte un texto en decimal sin importar el tipo de separación decimal (Punto o Coma).
			</summary>
		
			<param name="numTexto">Texto a convertir en Decimal.</param>
			<param name="numPredeterminado">Número que devolverá si falla la conversión.</param>
		
			<returns>Texto convertido a decimal.</returns>
		*/
		static public decimal Parse(string numTexto, decimal numPredeterminado){
			// Primer intento
			if(! decimal.TryParse(numTexto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out numPredeterminado)){
				// Puede fallar si viene con un punto o coma (No se por que ya que tiene el "InvariantCulture" que se la pasa por el forro)
				decimal.TryParse(numTexto, out numPredeterminado);
			}
			
			// Devolver el número convertido o el predeterminado si no consigue conmertir en número.
			return numPredeterminado;
		}

		/**	<summary>
				Convierte un texto en double sin importar el tipo de separación decimal (Punto o Coma).
			</summary>
		
			<param name="numTexto">Texto a convertir en Double.</param>
			<param name="numPredeterminado">Número que devolverá si falla la conversión.</param>
		
			<returns>Texto convertido a Double.</returns>
		*/
		static public double Parse(string numTexto, double numPredeterminado){
			// Primer intento
			if(! double.TryParse(numTexto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out numPredeterminado)){
				// Puede fallar si viene con un punto o coma (No se por que ya que tiene el "InvariantCulture" que se la pasa por el forro)
				double.TryParse(numTexto, out numPredeterminado);
			}
			
			// Devolver el número convertido o el predeterminado si no consigue conmertir en número.
			return numPredeterminado;
		}

		/**	<summary>
				Obtiene un color para el texto según el fondo obtenido.<br/>
				Con esto el texto siempre será legible.
			</summary>

			<param name="colorFondo">Color que estará detrás del texto.</param>
	
			<returns>Color Blanco o Negro dependiendo del fondo.</returns>
		*/
		static public Color ColorTexto_BoN(Color colorFondo){
			float media = (colorFondo.r + colorFondo.g + colorFondo.b) /3;

			return ( media>=0.5 )
				? Color.black
				: Color.white
			;
		}

		/**	<summary>
				Quita los espacios extra entre palabras de un String.
			</summary>

			<param name="texto">Info del parámetro</param>
	
			<returns>String separado por 1 espacio entre palabras.</returns>
		*/
		static public string QuitarEspacios(string texto){
			// Convierte en array según encuentre espacios.
			string[] frase_array = texto.Split(' ');

			// Se almacenará el resultado aqui
			string frase_final = "";

			// Itera por las palabras.
			// Si se introducen espacios extra los ignora con el IF
			for( int i=0 ; i<frase_array.Length ; i++ ){
				// Si contiene una palabra
				if( frase_array[i]!="" ){
					frase_final += " "+ frase_array[i];
				}
			}

			// Devuelve y quita el espacio inicial al concatenar.
			return frase_final.Substring(1);
		}

		/** <summary>
				Capitaliza el texto (minimiza el resto del texto).<br/>·<br/>
				▼ Texto a Capitalizar.
			</summary>

			<param name="texto">Texto</param>
	
			<returns>String capitalizado.</returns>
		*/
		static public string Capitalizar(string texto){
			return (texto[0]+"").ToUpper() + texto.Substring(1).ToLower();
		}

		/**	<summary>
				Elimina el primer elemento del Array de 1 o 2 Dimensiones
			</summary>

			<param name="array">Array de 1 Dimensión.</param>
		*/
		static public void Array_eliminarPrimerElemento<T>(ref T[] array){
			// Invertir array (array invertida)
			Array.Reverse(array);

			// Cambiar tamaño
			Array.Resize(ref array, array.Length -1);

			// Invertir de nuevo el array (array con orden normal)
			Array.Reverse(array);
		}

		/**	<summary>
				Elimina un dato del array en una posición específica.
			</summary>

			<param name="array">Array objetivo.</param>
			<param name="indice">Indice a eliminar del array.</param>
		*/
		static public void Array_eliminarPorIndice<T>( ref T[] array, int indice ){
			array = array.Where<T>((source, index) => index != indice).ToArray<T>();
		}

		/**	<summary>
				Elimina el primer elemento del Array de 1 o 2 Dimensiones
			</summary>

			<param name="array">Array de 2 Dimensiones.</param>
		*/
		static public void Array_eliminarPrimerElemento<T>(ref T[][] array){
			// Invertir array (array invertida)
			Array.Reverse(array);

			// Cambiar tamaño
			Array.Resize(ref array, array.Length -1);

			// Invertir de nuevo el array (array con orden normal)
			Array.Reverse(array);
		}

		/**	<summary>
				Desordena los datos del array.
			</summary>
		
			<param name="array">Array.</param>
		
			<returns>Array aleatoria según sus datos.</returns>
		*/
		static public object[] Array_Shuffle(object[] array){
			Log("array len: "+ array.Length);
			if(array.Length <= 1){
				return array;
			}

			object[] nuevaArray = new object[array.Length];
			int contador = 0;
			int idAleatorio;

			while(array.Length > 0){
				Log("Contador: "+ contador);
				// Obtener un ID aleatorio.
				idAleatorio = Aleatorio(0, array.Length -1);

				// Añadir dato al nuevo Array
				nuevaArray[contador] = array[idAleatorio];

				// eliminar elemento del array anterior
				Array_eliminarPorIndice(ref array, idAleatorio);

				// Aumentar contador para el nuevo array
				contador++;
			}

			Log("New Array", nuevaArray);
			return nuevaArray;
		}

		/* CortarDecimales: Se ha sustituido por .ToString("#00.00")
			<summary>
				Quita los decimales del numero sin redondear.<br/>
				Admite: Flotantes, Dobles y Decimales·
			</summary>

			<param name="numero">Numero de tipo flotante.</param>
			<param name="decimales">Cantidad de decimales que quiere dejar.</param>
	
			<returns>Float</returns>
		static public float CortarDecimales(float numero, int decimales){
			// Separar numero del decimal
			string[] numeroArr = (numero+"").Replace(".", ",").Split(',');

			// Si la longitud del array es 1, es que le han pasado un número sin decimales
			// Si los decimales son menos que los decimales que se piden el Substring puede dar error de fuera de rango
				// Solución dar solo los decimales restantes si son menos
			return (numeroArr.Length==1)
				? numero
				: float.Parse(numeroArr[0] +","+ numeroArr[1].Substring(0, ((numeroArr[1].Length<decimales)?numeroArr[1].Length:decimales)))
			;
		}

			<summary>
				Quita los decimales del numero sin redondear.<br/>
				Admite: Flotantes, Dobles y Decimales·
			</summary>

			<param name="numero">Numero de tipo doble.</param>
			<param name="decimales">Cantidad de decimales que quiere dejar.</param>
	
			<returns>Double</returns>
		static public double CortarDecimales(double numero, int decimales){
			// Separar numero del decimal
			string[] numeroArr = (numero+"").Replace(".", ",").Split(',');

			// Si la longitud del array es 1, es que le han pasado un número sin decimales
			return (numeroArr.Length==1)
				? numero
				: double.Parse(numeroArr[0] +","+ numeroArr[1].Substring(0, ((numeroArr[1].Length<decimales)?numeroArr[1].Length:decimales)))
			;

		}
		
		No será necesario debido a que .ToString("#00.00") ya lo hace
			<summary>
				Quita los decimales del numero sin redondear.<br/>
				Admite: Flotantes, Dobles y Decimales·
			</summary>

			<param name="numero">Numero de tipo Decimal.</param>
			<param name="decimales">Cantidad de decimales que quiere dejar.</param>
	
			<returns>Decimal</returns>
		static public decimal CortarDecimales(decimal numero, int decimales){
			// Separar numero del decimal
			string[] numeroArr = (numero+"").Replace(".", ",").Split(',');

			// Si la longitud del array es 1, es que le han pasado un número sin decimales
			return (numeroArr.Length==1)
				? numero
				: decimal.Parse(numeroArr[0] +","+ numeroArr[1].Substring(0, ((numeroArr[1].Length<decimales)?numeroArr[1].Length:decimales)))
			;
		}
		*/

		/**	<summary>
				Cambia byte a float de 0 a 1.<br/>
				Útil para color y color32.
			</summary>
		
			<param name="num">Numero de 0 a 255</param>
		*/
		static public float ByteToScale1(byte num){
			return (num==255)?1f:(num/256f);
		}

		/**	<summary>
				Fija el valor entre los valores mínimo y máximo obtenidos. Devuelve el valor dado si está dentro del rango mínimo y máximo.
			</summary>
		
			<param name="valor">Valor que será restringido por mínimo y máximo.</param>
			<param name="min">Valor mínimo (incluido).</param>
			<param name="max">Valor máximo (incluido).</param>
		
			<returns>Valor entre mínimo y máximo (incluidos).</returns>
		*/
		static public int ClampInt(int valor, int min, int max){
			return (valor < min) ? min
				: (valor > max) ? max
				: valor
			;
		}

		/**	<summary>
			Transforma Color a Color32
		</summary>
		
		<param name="color">Color (0 a 1)</param>
		
		<returns>Color32 (0 a 255)</returns>
	    */
		static public Color32 ColorToColor32(Color color){
			/* Alfa
				Solo es preciso si lo divides entre 256
				pero ese número puede exceder del 255
				por lo que si es el máximo (1f de 0 a 1) se le asigna 255
			*/
			return new Color32(
				(byte)(color.r * 255f),
				(byte)(color.g * 255f),
				(byte)(color.b * 255f),
				(byte)((color.a != 1f)
					? color.a * 256f
					: 255f
				)
			);
		}

		/**	<summary>
				Transformar Color32 en ColorHSV.
			</summary>
		
			<param name="col32">Color32 (0 a 255)</param>
		
			<returns>ColorHSV de JLScript</returns>
		*/
		static public ColorHSV Color32ToHSV(Color32 col32){
			// Color32 a Color
			Color col;
			col.r = ByteToScale1(col32.r);
			col.g = ByteToScale1(col32.g);
			col.b = ByteToScale1(col32.b);
			col.a = ByteToScale1(col32.a);

			// Variables para el out HSV
			float h = 0f,
				s = 0f,
				v = 0f
			;

			// Color a HSV
			Color.RGBToHSV(col, out h, out s, out v);

			// Devolver HSV
			return new ColorHSV(h * 360f, s * 100f, v * 100f, col.a * 100f);
		}

		/**	<summary>
				Transformar Color en ColorHSV.
			</summary>
		
			<param name="col">Color (0 a 1)</param>
		
			<returns>ColorHSV de JLScript</returns>
		*/
		static public ColorHSV ColorToHSV(Color col){
			// Variables para el out HSV
			float h = 0f,
				s = 0f,
				v = 0f
			;

			// Color a HSV
			Color.RGBToHSV(col, out h, out s, out v);

			// Devolver HSV
			return new ColorHSV(h * 360f, s * 100f, v * 100f, col.a * 100f);
		}

		[Serializable]
		public struct ColorHSV{
			[Range(0, 360)]	public float h;
			[Range(0, 100)]	public float s;
			[Range(0, 100)]	public float v;
			[Range(0, 100)]	public float a;
			
			/**	<summary>
					Crea un HSV personalizado.
				</summary>
		
				<param name="h">(H) Matíz (Color).</param>
				<param name="s">(S) Saturación.</param>
				<param name="v">(V) Valor (Brillo).</param>
				<param name="a">Color Alfa</param>
			*/
			public ColorHSV(float h, float s, float v, float a = 100f){
				this.h = h;
				this.s = s;
				this.v = v;
				this.a = a;
			}

			/**	<summary>
					Obtiene el Color32 de este HSV.
				</summary>
		
				<returns>Color32 (RGBA)</returns>
			*/
			public Color32 ToColor32(){
				// HSV to RGB (0 a 1)
				Color col = Color.HSVToRGB(
					(this.h / 360f),
					(this.s / 100f),
					(this.v / 100f)
				);

				// Transformar color Alfa
				col.a = this.a / 100f;

				return JL.ColorToColor32(col);
			}

			/**	<summary>
					Obtiene el Color de este HSV.
				</summary>
		
				<returns>Color (RGBA)</returns>
			*/
			public Color ToColor(){
				Color col = Color.HSVToRGB(
					(this.h / 360f),
					(this.s / 100f),
					(this.v / 100f)
				);

				// Transformar color Alfa
				col.a = this.a / 100f;
				return col;
			}

			/**	<summary>
					HSV en formato string.
				</summary>
		
				<returns>ColorHSV String</returns>
			*/
			public override string ToString() {
				return "HSV("+ this.h +", "+ this.s +", "+ this.v +", "+ this.a +")";
			}
		}
	}
}
/* Lógica random
	Ejemplo de un aleatorio entre 50 y 100.
	Se crean los números aleatorios 56 y 52
	56 + 52 = 108
	108 sobrepasa al máximo (100)

	Entre el 50 y el 100 hay 51 posibilidades, por eso el maximo +1
	Si 108 es más grande que 100
		ale = 108 - ((100 + 1) - 50)
			: 108 - (101 - 50)
			: 108 - 51
			: 57 como resultado final

	Nota: 108 sobrepasa 8 de 100...
		del 50 al 57 hay 8 números incluyendo el 50
*/
	/**	<summary>
			Información de la función.<br/>·<br/>
			▼ Actual: Información del parámetro
		</summary>
		
		<param name="nompreParametro">Info del parámetro</param>
		
		<returns>Info que devuelve</returns>
	*/

/* Datos de Versiones
►	Versión: 3.1.0
	• Métodos añadidos
		· Parse
			- Convierte un texto a número con decimales sin importar si la separación decimal es con Punto o Coma.
		
		· Entre2Vectores
			- Te da un vector entre el punto inicio y final.
	
	• Métodos eliminados
		· CortarDecimales
			Se ha eliminado la función debido a que ToString funciona de igualforma (Excepto String.ToString())

►	Versión: 3.0.1
	• Métodos modificados
		· Aleatorio(int)
		· Aleatorio (float)
			Corregido el problema que fallaba si el mínimo y máximo eran iguales.

►	Versión: 3.0
	• Métodos modificados:
		¡Todos los Aleatorios perfectos incluyendo el float! :D

		· Escribir() y sus sobrecargas
			- Se ha cambiado el nombre a Log para una mejor inmersión con el programa.
			- Los parámetros multiples solo los interpreta por separado.
			- Ahora al insertar varios parámetros los interpreta por separado
				evitando usar el primero como título.
			- Ahora añade un salto de línea extra al final para separar el código de Unity y obtener una mejor lectura.
			- Solo mostrará los números del array si se elige ponerle un título.

	• Métodos creados:
		· LogWarning()
			Identico a Log pero usando el LogWarning.


►	Versión: 2.0
	• Variables creadas:
		· ColorHSV
			Nueva variable para transformar HSV, Color y Color32.

	• Métodos creados:
		· ColorToColor32()
			Transforma Color (0 a 1) a Color32 (0 a 255)
			Color32		-> Color

		· Color32ToHSV()
			Transforma Color32 (0 a 255) a ColorHSV
			Color32		-> ColorHSV

		· ColorToHSV()
			Transforma Color (0 a 1) a ColorHSV
			Color		-> ColorHSV

		· ColorHSV.ToColor32()
			Obtiene el Color32 (0 a 255) a partir de una variable ColorHSV
			ColorHSV	-> Color32

		· ColorHSV.ToColor()
			Obtiene el Color (0 a 1) a partir de una variable ColorHSV
			ColorHSV	-> Color

		· ColorHSV.ToString()
			Obtiene un string con la información de la variable ColorHSV
			ColorHSV	-> String

►	Versión: 1.1 Correcciones menores
	Aún requiere de la corrección del Aleatorio Flotante.

►	Versión: 1.0
	• Metodos creados:
		· Escribir()
			Escribe por consola.
			Admite de 0 a Infinitos parámetros.
			Admite 1 Array.
			Admite 1 Lista.
			Admite cualquier tipo de dato siempre que sean del mismo tipo.

		· Aleatorio()
			Devuelve un aleatorio dependiendo de lo que le pasemos.
			Vacío				-> Boleano
			String				-> Palabra
			Float				-> Float.
			Int					-> Int.
			List				-> 1 Dato de la Lista
			Array				-> 1 Dato del Array.
			1 o más Argumentos	-> 1 Argumento aleatorio.

		· Aleatorio_Color()
			Devuelve un color aleatorio.
			Se le puede indicar si se quiere un color alfa también aleatorio.
			Se puede pedir un color con el alfa fijo si se le pasa el color alfa (float).

		· ColorTexto_BoN()
			Obtiene el color Blanco o Negro dependiendo del fondo.
				Útil para cambiar el fondo y que el texto sea legible.

		· QuitarEspacios()
			Quita los espacios sobrantes de un String.

		· Capitalizar()
			Minimiza el texto y pone la primera letra en Mayúsculas.

		· Array_eliminarPrimerElemento()
			Permite eliminar el primer elemento de un array de 1 Dimensión o 2 Dimensiones.

		· CortarDecimales()
			Te permite decidir hasta donde quieres los decimales sin importar el resto
			Este método no redondea.
			Se puede cortar decimales de: Float, Double y Decimal
*/
/* Info Subtitulo:
	Subtitulo
		Esperar		: Titulo - 15
		Lentitud	: 60			: (60 /letras)

	Guiones
		Esperar		: SubTitulo
		Lentitud	: 60			: (60 / (guiones +1))
*/
