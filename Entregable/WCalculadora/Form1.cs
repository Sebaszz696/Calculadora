using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exponencial;
using BlHipotenusa;
using BlMultiplicacion;
using BlRadicacion;
using BlResta;
using BlLogaritmo;
using BlSuma;
using BlTangente;
using Division;
using Moda;



namespace WCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }


       
        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double I = double.Parse(TxtNumero1.Text);
                double J = double.Parse(TxtNumero2.Text);
                double M = double.Parse(TxtNumero3.Text);
                double N = double.Parse(TxtNumero4.Text);
                double Respuesta;
                //--------------------------------Basicas------------------------------
                if (CtxTipoDeOperacionesBasicas.Text == "Suma")
                {




                    Respuesta = BlSuma.ClsSuma.Suma(I, J, M, N);
                    TxtRespuesta.Text = (Respuesta.ToString());


                }
                else if
                    (CtxTipoDeOperacionesBasicas.Text == "Resta")
                {

                    Respuesta = BlResta.ClsResta.Resta(I, J, M, N);
                    TxtRespuesta.Text = (Respuesta.ToString());

                }
                else if
                    (CtxTipoDeOperacionesBasicas.Text == "Multiplicacion")
                {

                    Respuesta = BlMultiplicacion.ClsMultiplicacion.Multiplicacion(I, J, M, N);
                    TxtRespuesta.Text = (Respuesta.ToString());

                }
                else if
                   (CtxTipoDeOperacionesBasicas.Text == "Division")
                {

                    Respuesta = Division.Class1.division(I, J);
                    TxtRespuesta.Text = (Respuesta.ToString());

                }
                //--------------------------------Basicas------------------------------

                //--------------------------------Avanzadas----------------------------
                if (CtxTipoDeOperacionesAvanzadas.Text == "Exponencial")
                {
                    Respuesta = Exponencial.ClsExponencial.Exponencial(I, J);
                    TxtRespuesta.Text = (Respuesta.ToString());

                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Radicacion")
                {
                    Respuesta = BlRadicacion.ClsRadicacion.Raiz(I, J);
                    TxtRespuesta.Text = (Respuesta.ToString());
                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Hipotenusa")
                {
                    Respuesta = BlHipotenusa.ClsHipotenusa.Hipotenusa(I, J);
                    TxtRespuesta.Text = (Respuesta.ToString());
                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Seno")
                {
                    Respuesta = Seno.ClsSeno.Seno(I);
                    TxtRespuesta.Text = (Respuesta.ToString());
                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Coseno")
                {
                    Respuesta = Coseno.ClsCoseno.Coseno(I);
                    TxtRespuesta.Text = (Respuesta.ToString());


                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Logaritmo")
                {
                    Respuesta = BlLogaritmo.ClsLogaritmo.Logaritmo(I, J);
                    TxtRespuesta.Text = (Respuesta.ToString());
                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Moda")
                {
                    Respuesta = Moda.ClsModa.Moda(I, J, N, M);
                    TxtRespuesta.Text = (Respuesta.ToString());

                }
                else if (CtxTipoDeOperacionesAvanzadas.Text == "Tangente")
                {
                    Respuesta = BlTangente.ClsObtenerTangente.ObtenerTangente(I);
                    TxtRespuesta.Text = (Respuesta.ToString());
                }
                //--------------------------------Avanzadas----------------------------

            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite solo numeros y seleccione los campos correctamente");
                
            }
            
     
        }


                //--------------------------------Basicas------------------------------
        private void CtxTipoDeOperacionesBasicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtxTipoDeOperacionesBasicas.Enabled = true;
            CtxTipoDeOperacionesAvanzadas.Enabled= false;

            //Hace que los controles mantengan visibles cada que se inicie una nueva operacion
            LbNumero1.Show();
            LbNumero2.Show();
            LbNumero3.Show();
            LbNumero4.Show();
            TxtNumero1.Show();
            TxtNumero2.Show();
            TxtNumero3.Show();
            TxtNumero4.Show();
            TxtNumero1.Text = "0";
            TxtNumero2.Text = "0";
            TxtNumero3.Text = "0";
            TxtNumero4.Text = "0";

            if (CtxTipoDeOperacionesBasicas.Text == "Suma")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero 1";
                LbNumero2.Text = "Numero 2";
                LbNumero3.Text = "Numero 3";
                LbNumero4.Text = "Numero 4";
                //
              
         

            }
            else if (CtxTipoDeOperacionesBasicas.Text == "Resta")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero 1";
                LbNumero2.Text = "Numero 2";
                LbNumero3.Text = "Numero 3";
                LbNumero4.Text = "Numero 4";
                //
     
      

            }
            else if (CtxTipoDeOperacionesBasicas.Text == "Multiplicacion")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero 1";
                LbNumero2.Text = "Numero 2";
                LbNumero3.Text = "Numero 3";
                LbNumero4.Text = "Numero 4";
                //
          

            }
            else if (CtxTipoDeOperacionesBasicas.Text == "Division")
            {
                LbNumero1.Text = "Dividiendo";
                LbNumero2.Text = "Divisor";

                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();

            }
        

        }
        private void RadBasicas_CheckedChanged(object sender, EventArgs e)
        {
            CtxTipoDeOperacionesBasicas.Enabled = true;
            CtxTipoDeOperacionesAvanzadas.Enabled = false;

        }

                //--------------------------------Basicas------------------------------

                //--------------------------------Avanzadas----------------------------
       

        private void CtxTipoDeOperacionesAvanzadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtxTipoDeOperacionesBasicas.Enabled = false;
            CtxTipoDeOperacionesAvanzadas.Enabled = true;


            //Hace que los controles mantengan visibles cada que se inicie una nueva operacion
            LbNumero1.Show();
            LbNumero2.Show();
            LbNumero3.Show();
            LbNumero4.Show();
            TxtNumero1.Show();
            TxtNumero2.Show();
            TxtNumero3.Show();
            TxtNumero4.Show();
            TxtNumero1.Text = "0";
            TxtNumero2.Text = "0";
            TxtNumero3.Text = "0";
            TxtNumero4.Text = "0";

            if (CtxTipoDeOperacionesAvanzadas.Text == "Exponencial")
            {
                //Asignar nombres
                LbNumero1.Text = "Base";
                LbNumero2.Text = "Exponente";

                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }
            else if (CtxTipoDeOperacionesAvanzadas.Text == "Radicacion")
            {
                //Asignar nombres
                LbNumero1.Text = "Radical";
                LbNumero2.Text = "Indice";

                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }
            else if (CtxTipoDeOperacionesAvanzadas.Text == "Hipotenusa")
            {
                //Asignar nombres
                LbNumero1.Text = "Cateto1";
                LbNumero2.Text = "Cateto2";

                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }
            else if (CtxTipoDeOperacionesAvanzadas.Text == "Seno")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero";


                LbNumero2.Text= "Recordar que esta en radianes";
                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero2.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }
            else if (CtxTipoDeOperacionesAvanzadas.Text == "Coseno")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero";


                LbNumero2.Text = "Recordar que esta en radianes";
                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero2.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }
            else if (CtxTipoDeOperacionesAvanzadas.Text == "Logaritmo")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero";

                LbNumero2.Text = "Este es logaritmo natural";
                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero2.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }
            else if (CtxTipoDeOperacionesBasicas.Text == "Moda")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero 1";
                LbNumero2.Text = "Numero 2";
                LbNumero3.Text = "Numero 3";
                LbNumero4.Text = "Numero 4";
                //



            }
            else if (CtxTipoDeOperacionesAvanzadas.Text == "Tangente")
            {
                //Asignar nombres
                LbNumero1.Text = "Numero";


                LbNumero2.Text = "Recordar que esta en Deg";
                LbNumero3.Hide();
                LbNumero4.Hide();
                TxtNumero2.Hide();
                TxtNumero3.Hide();
                TxtNumero4.Hide();
                //



            }


        }
        private void RadAvanzadas_CheckedChanged(object sender, EventArgs e)
        {
            CtxTipoDeOperacionesBasicas.Enabled = false;
            CtxTipoDeOperacionesAvanzadas.Enabled = true;

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            TxtRespuesta.Clear();
            RadBasicas.Checked = false;
            RadAvanzadas.Checked = false;
            CtxTipoDeOperacionesBasicas.Text = "";
            CtxTipoDeOperacionesAvanzadas.Text = "";
            TxtNumero1.Clear();
            TxtNumero2.Clear();
            TxtNumero3.Clear();
            TxtNumero4.Clear();
            CtxTipoDeOperacionesAvanzadas.Enabled = true;
            CtxTipoDeOperacionesBasicas.Enabled = true;
            LbNumero1.Text = "";
            LbNumero2.Text = "";
            LbNumero3.Text = "";
            LbNumero4.Text = "";

        }
        //--------------------------------Avanzadas-----------------------------
    }
}
