using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace III_2020
{
    public partial class UserControl1: UserControl
    {
        // Agregado 

        private bool estadoJuego = false;
        private int intentosLleva;
        private int intentosFaltan;
        private char[] codigo = new char[4];



        public UserControl1()
        {
            InitializeComponent();
            this.IntentoTextBox.Enabled = false;
            this.ComprobarButton.Enabled = false;
        }

        private void iniciarJuego()
        {
            this.estadoJuego = true;
            this.intentosLleva = 0;
            this.intentosFaltan = 8;
            this.IntentoTextBox.Enabled = true;
            this.ComprobarButton.Enabled = true;
            this.IntentosLabel.Text = "Intentos: 0";
            this.FaltalLabel.Text = "Faltan: 8";
            this.generarCodigo();
        }


        private void generarCodigo()
        {
            var random = new Random();     

            for(int i=0; i<4; i++)
            {
                int num = random.Next(1,7);
                codigo[i] = this.asignarColor(num);
            }           
        }

        private char asignarColor(int num)
        {
            switch (num) {
                case 1:
                    return 'A';
                    break;
                case 2:
                    return 'R';
                    break;
                case 3:
                    return 'B';
                    break;
                case 4:
                    return 'N';
                    break;
                case 5:
                    return 'V';
                    break;
                case 6:
                    return 'M';
                    break;
                default:
                    return 'X';
                    break;

            }
        }

            private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AciertosTotalesLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void IniciarJuegoButton_Click(object sender, EventArgs e)
        {
            this.iniciarJuego();
        }

        private void ComprobarButton_Click(object sender, EventArgs e)
        {

            this.AciertosParcialesLabel.Text = "Aciertos Parciales: " + Convert.ToString(this.verificarParciales(this.IntentoTextBox.Text.ToCharArray()));
            this.AciertosTotalesLabel.Text = "Aciertos Totales: " + Convert.ToString(this.verificarTotales(this.IntentoTextBox.Text.ToCharArray()));
            this.actualizarJuego();
            this.ResultadosLabel.Text = "Codigo"+ new string(this.codigo)+"    " +"Ultimo Intento: " + this.IntentoTextBox.Text;


        }

        private void actualizarJuego()
        {

            if(this.verificarTotales(this.IntentoTextBox.Text.ToCharArray()) == 4)
            {
                // Gano 
            }
            else
            {
                
                this.intentosFaltan--;
                this.intentosLleva++;
            }

            if(this.intentosLleva == 8)
            {
                // Perdio 
            }
        }

        private int verificarParciales(char[] intento)
        {
            int parciales = 0;         

            for(int i = 0; i<4; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    if (this.codigo[i] == intento[j] && i != j)
                    {                                               
                        parciales++;                                           
                    }
                }               
            }

            return parciales; 
        }

        private int verificarTotales(char[] intento)
        {
            int totales = 0;

            for (int i = 0; i < 4; i++)
            {
                if(this.codigo[i] == intento[i])
                {
                    totales++;
                }             
            }

            return totales;
        }

        private bool terminarJuego()
        {
            return  this.intentosLleva == 8 ? true : false;
        }
    }
}
