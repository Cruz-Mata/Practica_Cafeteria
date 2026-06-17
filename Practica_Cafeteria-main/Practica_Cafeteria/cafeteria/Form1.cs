using Practica_Cafeteria.cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Practica_Cafeteria
{
    public partial class Form1 : Form
    {
        private List<Bebida> bebidas;
        public Form1()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label4.Text = "Temperatura";
            }
            else if(radioButton3.Checked == true)
            {
                label4.Text = "Grados de alcohol";
            }
            else
            {
                label4.Text = "Cantidad de hielo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            float precio = float.Parse(textBox2.Text.Trim());
            string tamaño = textBox3.Text;
            int extra = int.Parse(textBox4.Text.Trim());


            if (radioButton2.Checked == true)
            {
                bebidas.Add(new BebidaCaliente(nombre, tamaño, precio, extra));

            }
            else if (radioButton3.Checked == true)
            {
                bebidas.Add(new BebidaAlcolica(nombre, tamaño, precio, extra));
            }
            else
            {
                bebidas.Add(new BebidaFria(nombre, tamaño, precio, extra));
            }

                MessageBox.Show("Bebida agregada correctamente, tienes : " + bebidas.Count + " bebidas registradas");
            LimpiaCajas();

            if (bebidas[bebidas.Count -1] is BebidaFria fria)
            {
                listBox1.Items.Add(fria.Listar());
            }
            else if (bebidas[bebidas.Count -1] is BebidaCaliente caliente)
            {
                listBox1.Items.Add(caliente.Listar());
            }

            label5.Text = bebidas.Count + " Bebidas registradas";

        }

        private void LimpiaCajas()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            listBox1.SelectedIndex = -1;
        }

        private void lsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (bebidas[lsbLista.SelectedIndex] is BebidaFria fria)
            {
                lblDescripcion.Text=fria.d
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.Listar());
            }*/

            label5.Text = bebidas[listBox1.SelectedIndex].Preparar();
        }
    
        //fin
        

        
    }
}
