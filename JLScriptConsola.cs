// Versión 1.0.0
/* Info versiones
	1.0.0	: Enorme modificación que afecta a todo el código.
	0.1.0	: Modificar, Eliminar o Añadir una función.
	0.0.1	: Correcciones menores o de errores.

	(Info añadida en la versión 3.1.0)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;			// Sleep
using System.Threading.Tasks;

namespace JLScriptConsola{
	static public class JLC{
		// Variables de clase
		private static readonly Random	ran				= new Random();
		private static int		aleatorioActual_int		= Aleatorio(0);

		/**	<summary>
				Obtiene la distancia entre los 2 números.
			</summary>
		
			<param name="num1">Primer número</param>
			<param name="num2">2º número</param>
		
			<return>Distancia entre los números.</return>
	    */
		public static int Distancia2Numeros(int num1, int num2){
			OrdenarMinMax(ref num1, ref num2);
			
			// Tienen signos diferentes
			if(num1 < 0 && 0 < num2){
				return Math.Abs(num1) + Math.Abs(num2);
			}
			// Signos iguales
			else {
				// Max - Min + 1
				return num2 - num1;
			}
		}
		
		/**	<summary>
			[JLScript] Aleatorio de enteros.<br/>
			<em>Nota: Ha sido modificado debido a que JLScript tiene diversas opciones.</em>
			</summary>

			<param name="minNum">Primer número (no es necesario que sea el mínimo).</param>
			<param name="maxNum">Segundo número (no es necesario que sea el máximo).</param>
			
			<return>Int.</return>
		*/
		public static int Aleatorio(int minNum, int maxNum=100){
			// Si son iguales, devolver el único valor posible
			if(minNum == maxNum){
				return minNum;
			}

			// Ordenar mínimo y máximo por si acaso
			OrdenarMinMax(ref minNum, ref maxNum);

			// +1 por que no coge un número menos del máximo especificado.
			aleatorioActual_int	+= ran.Next(minNum, maxNum +1);
			
			// Obtener la cantidad de números del rango.
			int cantNumeros = Distancia2Numeros(minNum, maxNum) +1;
			
			// Variables
			int distancia, numMulti;
			
			// Si el aleatorio es superior al rango
			if(maxNum < aleatorioActual_int){
				// Obtener distancia entre el máximo y el número guardado.
				distancia = Distancia2Numeros(maxNum, aleatorioActual_int);
				
				// Calcular el número de multiplicaciones necesarias
				numMulti = (int)Math.Floor(distancia / (float)cantNumeros);
				
				// Si no es una reducción exacta hay que aumentar un poco más.
				if(distancia % (float)cantNumeros != 0){
					numMulti++;
				}

				
				return aleatorioActual_int -= numMulti * cantNumeros;
			}
			// Si el aleatorio es inferior al rango
			else if(aleatorioActual_int < minNum){
				// Obtener distancia entre el mínimo y el número guardado.
				distancia = Distancia2Numeros(minNum, aleatorioActual_int);

				// Calcular el número de multiplicaciones necesarias
				numMulti = (int)Math.Floor(distancia / (float)cantNumeros);
				
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

		/*
			╔═══════════════════════════════════════════════╗
			║   F U N C I O N E S   P R I N C I P A L E S   ║
			╚═══════════════════════════════════════════════╝
		*/

		/**	<summary>
				Elimina el primer elemento del Array de 1 o 2 Dimensiones
			</summary>

			<param name="array">Array de 1 Dimensión.</param>
		*/
		public static void Array_eliminarPrimerElemento<T>(ref T[] array){
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
		public static void Array_eliminarPorIndice<T>( ref T[] array, int indice ){
			array = array.Where<T>((source, index) => index != indice).ToArray<T>();
		}

		/**	<summary>
				Elimina el primer elemento del Array de 1 o 2 Dimensiones
			</summary>

			<param name="array">Array de 2 Dimensiones.</param>
		*/
		public static void Array_eliminarPrimerElemento<T>(ref T[][] array){
			// Invertir array (array invertida)
			Array.Reverse(array);

			// Cambiar tamaño
			Array.Resize(ref array, array.Length -1);

			// Invertir de nuevo el array (array con orden normal)
			Array.Reverse(array);
		}

		/**	<summary>
				Cambiar el color de la consola (Fondo y Texto).<br/>
				Limpia la consola debido a que el color se adapte bien (bug si no se hace).
				<em>Nota: Sin parámetros: Color aleatorio</em>
			</summary>

			<param name="color">Colo a elegir.</param>
		*/
		public static void CambiarColorConsola(ConsoleColor color){
			// Foreground
			switch(color){
				// Ordenados por color y de Claro a Oscuro
				// Excepto Black como predeterminado
				
				case ConsoleColor.White			: Console.BackgroundColor = ConsoleColor.White;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.Gray			: Console.BackgroundColor = ConsoleColor.Gray;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.DarkGray		: Console.BackgroundColor = ConsoleColor.DarkGray;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				// Black here
				case ConsoleColor.Red			: Console.BackgroundColor = ConsoleColor.Red;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.DarkRed		: Console.BackgroundColor = ConsoleColor.DarkRed;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				case ConsoleColor.Yellow		: Console.BackgroundColor = ConsoleColor.Yellow;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.DarkYellow	: Console.BackgroundColor = ConsoleColor.DarkYellow;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.Green			: Console.BackgroundColor = ConsoleColor.Green;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.DarkGreen		: Console.BackgroundColor = ConsoleColor.DarkGreen;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				case ConsoleColor.Cyan			: Console.BackgroundColor = ConsoleColor.Cyan;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.DarkCyan		: Console.BackgroundColor = ConsoleColor.DarkCyan;
													Console.ForegroundColor = ConsoleColor.Black;		break;
				
				case ConsoleColor.Blue			: Console.BackgroundColor = ConsoleColor.Blue;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				case ConsoleColor.DarkBlue		: Console.BackgroundColor = ConsoleColor.DarkBlue;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				case ConsoleColor.Magenta		: Console.BackgroundColor = ConsoleColor.Magenta;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				case ConsoleColor.DarkMagenta	: Console.BackgroundColor = ConsoleColor.DarkMagenta;
													Console.ForegroundColor = ConsoleColor.White;		break;
				
				
				default							: Console.BackgroundColor = ConsoleColor.Black;			break;
			}

			Limpiar();
		}

		/**	<summary>
				Cambiar el color de la consola (Fondo y Texto) de forma aleatoria.
			</summary>
		*/
		public static void CambiarColorConsola(){
			// Obtener los todos los ConsoleColor en formato array
			Array valores = Enum.GetValues(typeof(ConsoleColor));

			// Obtener un ConsoleColor aleatorio
			ConsoleColor colorAlea = (ConsoleColor)valores.GetValue(new Random().Next(valores.Length));
			
			// Cambiar color aleatorio
			CambiarColorConsola(colorAlea);
		}

		/**	<summary>
				Saber si la letra existe dentro de la palabra.
			</summary>

			<param name="palabra">Palabra a comprobar.</param>
			<param name="letra">Letra a buscar.</param>
	
			<return>Bool: String contiene la letra.</return>
		*/
		public static bool LetraExisteEnPalabra(string palabra, char letra){
			// Recorrer cada carácter de la palabra
			foreach(char letra_f in palabra){
				// observar si la letra existe
				if(LetrasIguales(letra_f, letra)){
					return true;
				}
			}

			return false;
		}

		/**	<summary>
				Comparar letras evitando acentos y mayúsculas.
			</summary>
	
			<return>Palabra.</return>
		*/
		public static bool LetrasIguales(char letra1, char letra2){
			// Convertir en string y minúscula
			string letra1_str = letra1.ToString().ToLower();
			string letra2_str = letra2.ToString().ToLower();

			// Letra 1: Eliminar acentos
			switch(letra1_str){
				case "á":
				case "à": letra1_str = "a";break;

				case "é":
				case "è": letra1_str = "e";break;
				
				case "í":
				case "ì": letra1_str = "i";break;
				
				case "ó":
				case "ò": letra1_str = "o";break;
				
				case "ú":
				case "ù": letra1_str = "u";break;
			}

			// Letra 2: Eliminar acentos
			switch(letra2_str){
				case "á":
				case "à": letra2_str = "a";break;

				case "é":
				case "è": letra2_str = "e";break;
				
				case "í":
				case "ì": letra2_str = "i";break;
				
				case "ó":
				case "ò": letra2_str = "o";break;
				
				case "ú":
				case "ù": letra2_str = "u";break;
			}

			return letra1_str == letra2_str;
		}

		/**	<summary>
				[JLScript] Reorganiza las variables solo si no cuadran con el mayor o menor.<br/>
				<em>Nota: No hace nara si mayor ya es el mayor de los 2 números.</em>
			</summary>
		
			<param name="menor">Se modificará si no es el menor de los 2 números.</param>
			<param name="mayor">Se modificará si no es el menor de los 2 números.</param>
	    */
		public static void OrdenarMinMax(ref int menor, ref int mayor){
			if(menor > mayor){
				int min_backup = menor;
				menor = mayor;
				mayor = min_backup;
			}
		}
		
		/**	<summary>
				Cambina 2 Arrays en 1.
			</summary>

			<param name="array1">Primera Array.</param>
			<param name="array2">Segunda Array.</param>
	
			<return>Nueva Array combinada.</return>
		*/
		public static T[] Array_Join<T>(T[] array1, T[] array2){
			T[] pasteArray = new T[array1.Length + array2.Length];
			array1.CopyTo(pasteArray, 0);
			array2.CopyTo(pasteArray, array1.Length);

			return pasteArray;
		}

		// Función sacada de JLScript v3.0.1
		/**	<summary>
				Quita los decimales del numero sin redondear.<br/>
				Admite: Flotantes, Dobles y Decimales·
			</summary>

			<param name="numero">Numero de tipo flotante.</param>
			<param name="decimales">Cantidad de decimales que quiere dejar.</param>
	
			<return>Float</return>
		*/
		public static float CortarDecimales(float numero, int decimales){
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

		/**	<summary>
				Obtiene una barra en formato String.<br/>
				La barra tendrá una longitud de 10 + esquinas (2).
			</summary>
		
			<param name="valorActual">Valor actual de la barra.</param>
			<param name="valorMaximo">Valor máximo de la barra.</param>
			<param name="longitud">Longitud de la barra.</param>
		*/
		public static string BarraToString(int valorActual, int valorMaximo = 10, int longitud = 10){
			/* (Regla 3)
				100 - 10
				vida - 
			*/
			string barraVida = "[";

			// Vida
			valorActual = (int)Math.Ceiling(valorActual * longitud / (float)valorMaximo);
			barraVida += RepetirCaracter("═", valorActual);

			// Espacio
			barraVida += RepetirCaracter(" ", longitud - valorActual);
			
			// Final
			barraVida += "]";

			return barraVida;
		}

		/**	<summary>
				(JLScript) Convierte la primera letra en mayuscula y el resto en minusula.

				<param name="texto">texto a capitalizar.</param>
			</summary>
		*/
		public static string Capitalizar(string texto){
			if( texto.Length > 1 ){
				return texto[0].ToString().ToUpper() + texto.Substring(1).ToLower();
			} else {
				return texto.ToUpper();
			}
		}

		/**	<summary>
				Esperar X segundos.<br/>
				Permite usar segundos en lugar de milisegundos.<br/>
				<em>Nota: Simplemente me es más fácil escribir e identificar el nombre de la funcion.</em>

				<param name="segundos">Tiempo en Segundos.</param>
			</summary>
		*/
		public static void Esperar(float segundos){
			// Poner en milisegundos
			segundos *= 1000;
			
			// Limpiar consola
			Thread.Sleep((int)segundos);
		}

		/**	<summary>
				Limpia la Consola y reestablece el su tamaño predeterminado.
			</summary>
		*/
		public static void Limpiar(){
			// Limpiar consola
			Console.Clear();

			// Reestablecer el tamaño predeterminado de la ventana de la consola.
			Ventana();
		}

		/**	<summary>
				Cambia el tamaño de la ventana de la Consola.
			</summary>
		
			<param name="anchura">Anchura de la Ventana. (-1 para el tamaño predeterminado)</param>
			<param name="altura">Altura de la Ventana. (-1 para el tamaño predeterminado)</param>
		*/
		public static void Ventana(int anchura = -1, int altura = -1){
			// No cambiar anchura
			// Suele ser utilizado cuando se limpia la ventana y poder calcular el tamaño de la siguiente ventana
			if(anchura == -1){
				anchura = 100;
				venAnchura = 0;
			
			// Cambiar anchura. Solo si es más grande de la actual
			// Nota: El tamaño de ventana se calcula según las funciones (lo que necesiten para su estilo)
			} else if(anchura > venAnchura){
				venAnchura = anchura;
			
			// Cuando la ventana es más grande que el tamaño que quieren.
			// Es para evitar que después de una frase larga luego venga una pequeña y se reduzca la ventana cortando la frase larga
			} else if(venAnchura > anchura){
				anchura = venAnchura;
			
			// Escribir "" al inicio del programa
			// No se puede asignar una anchura de 0 inicialmente a la ventana
			} else if(anchura == 0 && anchura == venAnchura){
				anchura = 1;
			}
			
			// Altura predeterminada
			if(altura == -1){
				altura = venAltura;
			}

			// Establecer anchura y altura.
			// +1 para evitar un pequeño bug de la ventana al redimensionar manualmente en vertical.
			Console.SetWindowSize(anchura +1, altura);
		}

		/**	<summary>
				Cambia el título de la Consola
			</summary>
		
			<param name="texto">JLConsol - texto</param>
		*/
		public static void CambioTitulo(string texto){
			if(texto != "" && texto != " "){
				Console.Title = texto;
			} else {
				Console.Title = "JLConsol";
			}
		}

		/**	<summary>
				Como Console.WriteLine, pero que además permite varias lineas y redimensiona la ventana de consola para que quepa el texto.
			</summary>
		
			<param name="lineas">Nueva línea de texto.</param>
		*/
		public static void EscribirLineas(params string[] lineas){
			for( int i=0 ; i<lineas.Length ; i++ ){
				// Redimensionar si es necesario
				Ventana(lineas[i].Length +1);

				// Escribir
				Console.WriteLine(lineas[i]);
			}
		}

		/**	<summary>
				Introduce las líneas de texto en una caja.<br/>
				Puedes indicar que es una pregunta para que la caja acabe con una flecha.<br/>
				Indica que alineación tendrá el texto.
			</summary>
		
			<param name="pregunta">¿Quieres que termine como pregunta? (estilo).</param>
			<param name="alineacion">Alinear el texto.</param>
			<param name="lineas">Nueva línea de texto.</param>
		*/
		public static void Encajonar(bool pregunta, Alineacion alineacion = Alineacion.Izquierda, params string[] lineas){
			// Saber la longitud máxima de línea
			int maxLineLength = 0;
			for( int i=0 ; i<lineas.Length ; i++ ){
				if(lineas[i].Length > maxLineLength){
					maxLineLength = lineas[i].Length;
				}
			}

			
			EscribirLineas("╔═"+ RepetirCaracter("═", maxLineLength) +"═╗");

			// Texto con alineación normal
			if(alineacion != Alineacion.Centrado){
				string espacios;
				for( int i=0 ; i<lineas.Length ; i++ ){
					espacios = RepetirCaracter(" ", maxLineLength - lineas[i].Length);
					
					switch(alineacion){
						case Alineacion.Izquierda	: EscribirLineas("║ "+ lineas[i] + espacios +" ║"); break;
						case Alineacion.Derecha		: EscribirLineas("║ "+ espacios + lineas[i] +" ║"); break;
					}
				}
			
			// Centrar texto
			} else {
				for( int i=0, calculo, espaciosI, espaciosD ; i<lineas.Length ; i++ ){
					/* Calcular los espacios
						Nº de espacios
						La mitad a la Izquierda
						El resto a la Derecha
						
					*/
					calculo = maxLineLength - lineas[i].Length;
					espaciosI = calculo /2;
					espaciosD = calculo - espaciosI;

					EscribirLineas("║ "+ RepetirCaracter(" ", espaciosI) + lineas[i] + RepetirCaracter(" ", espaciosD) +" ║");
				}
			}

			// Pregunta - Terminar con la flecha
			if(pregunta){
				EscribirLineas(
					"╠═"+ RepetirCaracter("═", maxLineLength) +"═╝"
				);
				Console.Write("└─► ");
			
			// No es pregunta: Encajonar
			} else {
				EscribirLineas("╚═"+ RepetirCaracter("═", maxLineLength) +"═╝");
			}
		}

		/**	<summary>
				Introduce las líneas de texto en una caja añadiendo arriba un apartado especial para el título.<br/>
				Puedes indicar que es una pregunta para que la caja acabe con una flecha.<br/>
				Indica que alineación tendrá el texto.
			</summary>
		
			<param name="pregunta">¿Quieres que termine como pregunta? (estilo).</param>
			<param name="alineacion">Alinear el texto.</param>
			<param name="titulo">Texto centrado en la parte superior con una sección própia (sring de 1 línea).</param>
			<param name="lineas">Nueva línea de texto.</param>
		*/
		public static void EncajonarConTitulo(bool pregunta, Alineacion alineacion, string titulo, params string[] lineas){
			// Saber el máximo
			int maxLineLength = titulo.Length;
			for( int i=0 ; i<lineas.Length ; i++ ){
				if(lineas[i].Length > maxLineLength){
					maxLineLength = lineas[i].Length;
				}
			}

			int		calculo		= maxLineLength - titulo.Length;
			string	espaciosI	= RepetirCaracter(" ", calculo /2);
			string	espaciosD	= RepetirCaracter(" ", calculo - espaciosI.Length);

			// Escribir el título
			// Nota: El título siempre estará centrado (por gusto)
			EscribirLineas(
				"╔═"+ RepetirCaracter("═", maxLineLength) +"═╗",
				"║ "+ espaciosI + titulo + espaciosD +" ║",
				"╠─"+ RepetirCaracter("─", maxLineLength) +"─╣"
			);
			
			// Alineación Izquierda o Derecha
			if(alineacion != Alineacion.Centrado){
				string espacios;

				// Escribir las líneas
				for( int i=0 ; i<lineas.Length ; i++ ){
					espacios = RepetirCaracter(" ", maxLineLength - lineas[i].Length);
					
					switch(alineacion){
						case Alineacion.Izquierda	: EscribirLineas("║ "+ lineas[i] + espacios +" ║"); break;
						case Alineacion.Derecha		: EscribirLineas("║ "+ espacios + lineas[i] +" ║"); break;
					}
				}
			
			// Texto centrado
			} else if(alineacion == Alineacion.Centrado){
				for( int i=0 ; i<lineas.Length ; i++ ){
					calculo		= maxLineLength - lineas[i].Length;
					espaciosI	= RepetirCaracter(" ", calculo /2);
					espaciosD	= RepetirCaracter(" ", calculo - espaciosI.Length);

					EscribirLineas("║ "+ espaciosI + lineas[i] + espaciosD +" ║");
				}
			}
			
			// Pregunta - Terminar con la flecha
			if(pregunta){
				EscribirLineas(
					"╠═"+ RepetirCaracter("═", maxLineLength) +"═╝"
				);
				Console.Write("└─► ");
			
			// No es pregunta: Encajonar
			} else {
				EscribirLineas("╚═"+ RepetirCaracter("═", maxLineLength) +"═╝");
			}
		}

		/**	<summary>
				Devuelve un string con el caracter repetido indicando la cantidad.
			</summary>
		
			<param name="caracter">Caracter que será repetido.</param>
			<param name="cantidad">Cantidad requerida.</param>
		
			<return>Cadena con solo el caracter de longitud indicada.</return>
		*/
		public static string RepetirCaracter(string caracter, int cantidad = 2){
			string cadena = "";
			for( int i=0 ; i<cantidad ; i++ ){
				cadena += caracter;
			}

			return cadena;
		}

		/**	<summary>
				Final del script.
			</summary>
		*/
		public static void Final(bool clear = false){
			if(clear) Console.Clear();

			// Mostrar finalización del programa
			EscribirLineas(
				"   ┌────────────────────────────────┐",
				"───┘ Pulse una tecla para finalizar └───"
			);
			Console.ReadKey();
			Environment.Exit(0);	// 0 Para indicar al Sistema que ha salido correctamente.
		}

		/**	<summary>
				Pausa la consola. Nota: Me resulta más fácil escribir Pausar que Console.ReadKey.
				Además de poder escalar la función si me es necesario.
			</summary>
		*/
		public static void Pausar(string texto = ""){
			if(texto == ""){
				texto = "Pulse una tecla para Continuar";
			}

			EscribirLineas(
				"",
				"   ┌ "+ texto +" ┐",
				"───┘─"+ RepetirCaracter("─", texto.Length) +"─└───"
			);

			Console.ReadKey();
		}
	}
}
	/**	<summary>
			Información de la función.<para/>·<para/>
			▼ Actual: Información del parámetro
		</summary>
		
		<param name="nompreParametro">Info del parámetro</param>
		
		<returns>Info que devuelve</returns>
	*/

/* Datos de Versiones
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