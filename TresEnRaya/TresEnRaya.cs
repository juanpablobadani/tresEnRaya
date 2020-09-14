using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class TresEnRaya
    {

        private int[,] matriz = new int[3, 3];
        private int ganador = -1;
        
        private int[] ultimoMovimientoMaquina = new int[3];

        public int[,] Matriz { get => matriz; set => matriz = value; }
        public int Ganador { get => ganador; set => ganador = value; }
        public int[] UltimoMovimientoMaquina { get => ultimoMovimientoMaquina; set => ultimoMovimientoMaquina = value; }

        public void inicializarPartida()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    matriz[i,j] = -1;
            Ganador = -1;
        }

        public void seleccionarPosicion(int x, int y)
        {
            if (x >= 0 && x < 3 && y >= 0 && y < 3 && matriz[x, y] == -1 && Ganador == -1)
            {
                matriz[x, y] = 0;
                Ganador = ganaPartida();
                mueveMaquina();
            }
        }

        public int ganaPartida()
        {
            int aux = -1;

            if (matriz[0, 0] != -1 && matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2])
                aux = matriz[0, 0];

            if (matriz[0, 2] != -1 && matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0])
                aux = matriz[0, 2];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 0] != -1 && matriz[i, 0] == matriz[i, 1] && matriz[i, 0] == matriz[i, 2])
                    aux = matriz[i, 0];

                if (matriz[0, i] != -1 && matriz[0, i] == matriz[1, i] && matriz[0, i] == matriz[2, i])
                    aux = matriz[0, i];
            }


            return aux;
        }

        public bool tableroLleno()
        {
            bool tableroCompleto = true;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] == -1)
                        tableroCompleto = false;


            return tableroCompleto;
        }

        public bool finJuego()
        {
            bool fin = false;
            if (tableroLleno() || ganaPartida() != -1)
                fin = true;

            return fin;

        }

        public void mueveMaquina()
        {

            if (!finJuego())
            {
                int f = 0;
                int c = 0;
                int v = -99999999;
                int aux;

                for (int i = 0; i < matriz.GetLength(0); i++)
                    for (int j = 0; j < matriz.GetLength(1); j++)
                        if (matriz[i, j] == -1)
                        {
                            matriz[i, j] = 1;
                            aux = minimo();
                            if (aux > v)
                            {
                                v = aux;
                                f = i;
                                c = j;
                            }

                            matriz[i, j] = -1;
                        }
                matriz[f, c] = 1;
                ultimoMovimientoMaquina[0] = f;
                ultimoMovimientoMaquina[1] = c;
            }


        }


        private int maximo()
        {
            if (finJuego())
            {
                if (ganaPartida() != -1)
                    return -1;
                else
                    return 0;
            }

            int v = -99999999;
            int aux;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] == -1)
                    {
                        matriz[i, j] = 1;
                        aux = minimo();
                        if (aux > v)
                            v = aux;

                        matriz[i, j] = -1;
                    }

            return v;
        }

        private int minimo()
        {
            if (finJuego())
            {
                if (ganaPartida() != -1)
                    return 1;
                else
                    return 0;
            }

            int v = 99999999;
            int aux;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] == -1)
                    {
                        matriz[i, j] = 0;
                        aux = maximo();
                        if (aux < v)
                            v = aux;

                        matriz[i, j] = -1;
                    }

            return v;
        }
    }
}
