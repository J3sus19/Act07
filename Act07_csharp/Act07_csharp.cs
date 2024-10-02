using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica07_EncenderLed
{
    public partial class Form1 : Form
    {
       
        public SerialPort ArduinoPort { get; }
        
        public Form1()
        {
            InitializeComponent();
            //Crear Serial Port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM7";  //sustituir
            ArduinoPort.BaudRate = 9600;
            

            //Vincular eventos
            this.FormClosing+=CerrandoForm1;
            this.btnApagar.Click += btnApagar_Click;
            this.btnEncender.Click += btnEncender_Click;


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            //Cerrar el puerto
            if (ArduinoPort.IsOpen) ArduinoPort.Close();

        }

        private void btnEncender_Click(object obj, EventArgs e)
        {
            ArduinoPort.Write("b");




        }

    }
}

