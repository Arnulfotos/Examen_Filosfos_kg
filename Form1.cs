using System;
using System.Drawing;
using System.Threading; //para usar threads
using System.Windows.Forms;

namespace Examen_Filosfos_kg
{
    public partial class Form1 : Form
    {
        //arreglo de 5 hilos, uno por filosofos
        private Thread[] hilosFilosofos = new Thread[5];
        //arreglo de 5 objetos que representan los palillos, se usan para el bloqueo (lock)
        private object[] palillos = new object[5];
        //arreglo que almacena cuantas veces ha comido cada filosofo
        private int[] comidas = new int[5];
        //generador de numeros random, se usa para simular tiempos de espera
        private Random rand = new Random();
        //arreglo de labels para mostrar los estados de cad filosofo
        private Label[] estadosFilosofos;

        public Form1()
        {
            InitializeComponent();

            //crea 5 objetos para representar los palillos
            //usar object en lugar de bool porque se necesita bloquear el acceso a los recursos
            for (int i = 0; i < 5; i++)
            {
                palillos[i] = new object();
            }
            //guarda los 5 label en un arreglo para actualizar el estado de cada filosofo
            estadosFilosofos = new Label[] { lblEstado1, lblEstado2, lblEstado3, lblEstado4, lblEstado5 };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //anadir 5 filos al datagridview
            for (int i = 0; i < 5; i++)
            {
                tablaEstados.Rows.Add();
            }
            tablaEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaEstados.RowTemplate.Height = tablaEstados.Height / tablaEstados.RowCount;
            tablaEstados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //desactiva el boton para que no pueda activarse mas de una vez
            btnIniciar.Enabled = false;

            for (int i = 0; i < 5; i++)
            {
                int id = i;
                //crea 5 hilos(c/u por filosofo)
                //cada hilo ejecuta el metodo pensando 
                hilosFilosofos[i] = new Thread(() => Pensando(id));
                hilosFilosofos[i].Start();
            }

        }

        private double DisplayRand(int num)
        {
            double result = (double)num/1000;
            return Math.Round(result,2);
        }

        private void Pensando(int id)
        {
            //cada filosofo repite el proceso 5 veces
            for (int i = 0;i < 5;i++)
            {
                //tiempo que estara en espera *
                int waitingTime = rand.Next(1000, 3000);
                

                //se cambia el estado a en espera
                UpdateEstado(id, i, $"En Espera +{DisplayRand(waitingTime)}s", Color.LemonChiffon);


                Thread.Sleep(waitingTime);
                //Thread.Sleep(10);
                //se bloquean los palillos derecho e izquierdo
                //lock evita que dos filosofos tomen el mismo palillo al mismo tiempo
                lock (palillos[id])
                {
                    lock(palillos[(id+1) % 5])
                    {
                        //tiempo que va a durar comiendo *
                        var eatingTime = rand.Next(1000, 3000);
                        //si toma los palillos el estado se cambia
                        UpdateEstado(id, i, $"Comiendo +{DisplayRand(eatingTime)}s", Color.LightSkyBlue);
                        //se espera un tiempo
                        Thread.Sleep(eatingTime);
                        //Thread.Sleep(10);
                        comidas[id]++;
                    }
                }
                /*MessageBox.Show("Que esta pasando Dr.Garcia");
                lock (palillos[(id + 1) % 5])
                {
                    lock (palillos[id])
                    {
                        //si toma los palillos el estado se cambia
                        UpdateEstado(id, i, $"Comiendo {RandTime}", Color.LightSkyBlue);
                        //se espera un tiempo
                        //var RandTime2 = rand.Next(1000, 3000);
                        Thread.Sleep(rand.Next(1000, 3000));
                        //Thread.Sleep(10);
                        comidas[id]++;
                    }
                }*/
                //despues de comer, se cambia estado a finalizado
                UpdateEstado(id, i, $"Finalizado", Color.PaleGreen);
            }

            //si ha comido 5 veces, se actualiza label a finalizado
            if (comidas[id]==5)
            {
                this.Invoke((MethodInvoker)(() => estadosFilosofos[id].Text = "Finalizó"));
            }

        }

        private void UpdateEstado(int id, int ronda, string estado, Color color)
        {
            //actualiza la interfaz desde un hilo secundario
            this.Invoke((MethodInvoker)(() =>
            {
                //asegura que la fila existe antes de modificarla
                while (tablaEstados.Rows.Count <= ronda)
                {
                    tablaEstados.Rows.Add();
                }

                //actualiza el estado del dgv
                tablaEstados.Rows[ronda].Cells[id].Value = estado;
                //cambia el color de la celda
                tablaEstados.Rows[ronda].Cells[id].Style.BackColor = color;
                //actualiza el label para reflejar estado actual
                estadosFilosofos[id].Text = estado;
                estadosFilosofos[id].BackColor = color;
            }));
        }

    }
}
