using System;

namespace LotoClassNS
{
    // Clase que almacena una combinación de la lotería
    //
    public class loto
    {
        // definición de constantes
        public const int MAX_NUMEROS = 6;
        public const int NUMERO_MENOR = 1;
        public const int NUMERO_MAYOR = 49;
        
        private int[] listanumeros = new int[MAX_NUMEROS];   // numeros de la combinación
        public bool ok = false;      // combinación válida (si es aleatoria, siempre es válida, si no, no tiene porqué)

        public int[] Nums
        { 
            get => listanumeros; 
            set => listanumeros = value; 
        }

        
        /// <summary>
        /// Metodo que genera un array aleatorio  de numeros
        /// <remarks>En el caso de que el constructor sea vacío, se genera una combinación aleatoria correcta </remarks>
        /// </summary>
        public loto()
        {
            Random r = new Random();    // clase generadora de números aleatorios

            int i= 0, j, num;

            do             // generamos la combinación
            {                       
                num = r.Next(NUMERO_MENOR, NUMERO_MAYOR + 1);     // generamos un número aleatorio del 1 al 49
                for (j= 0; j<i; j++)    // comprobamos que el número no está
                    if (Nums[j]==num)
                        break;
                if (i==j)               // Si i==j, el número no se ha encontrado en la lista, lo añadimos
                {
                    Nums[i]= num;
                    i++;
                }
            } while (i< MAX_NUMEROS);

            ok = true;
        }

        
        /// <summary>
        /// metodo donde generamos los numeros de usuario
        /// </summary>
        /// <param name="misnums">parametro de entrada  array de enteros con la combinación  que genera el usuario</param>

        public loto(int[] misnums)  
        {
            for (int i=0; i<MAX_NUMEROS; i++)
                if (misnums[i]>=NUMERO_MENOR && misnums[i]<=NUMERO_MAYOR) {
                    int j;
                    for (j=0; j<i; j++) 
                        if (misnums[i]==Nums[j])
                            break;
                    if (i==j)
                        Nums[i]=misnums[i]; // validamos la combinación
                    else
                    {
                        ok=false;
                        return;
                    }
                }
                else
                {
                    ok=false;     // La combinación no es válida, terminamos
                    return;
                }
	          ok=true;
        }


       

        /// <summary>
        /// Método que comprueba el número de aciertos
        /// </summary>
        /// <param name="premi">array con la combinación ganadora</param>
        /// <returns>se devuelve el número de aciertos</returns>
        public int Comprobar(int[] premi)
        {
            int a=0;                    // número de aciertos
            for (int i=0; i<MAX_NUMEROS; i++)
                for (int j=0; j<MAX_NUMEROS; j++)
                    if (premi[i]==Nums[j]) a++;
            return a;
        }
    }

}
