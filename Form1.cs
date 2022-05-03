using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2_Algebra__TransformcionMatricial_
{
    public partial class Form1 : Form
    {
        float[] puntosXY=new float[] { 0,0};
        float ValuScrolbarX = 0, ValuScrolbarY = 0, ValuScrolbarAngulo;
        int  validacionGrafica = 0;
        Graphics grafica;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            grafica = pictureBox1.CreateGraphics();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (validacionGrafica >= 1 && validacionGrafica <= 3){ ToolStripMenuItemTransformacion.Enabled = true; buttonReset.Enabled = true; }

            Pen lapiz = new Pen(Color.IndianRed);
            grafica.DrawLine(lapiz, 0, 200, 800, 200);
            grafica.DrawLine(lapiz, 305, 0, 305, 400);
            labelPosX.Text = trackBarX.Value.ToString();
            labelPosY.Text = trackBarY.Value.ToString();
            labelAngulo.Text = trackBarAngulo.Value.ToString() + "°";

            if (validacionGrafica == 1)
                GraficarSenoidal();

            else if (validacionGrafica == 2)
                GraficaExponencial();

            else if (validacionGrafica==3)
                GraficarPolinomial();
        }
        private void GraficarSenoidal()
        {
            SolidBrush brush = (SolidBrush)Brushes.Red;
            Pen lapiz = new Pen(Color.Black);

            grafica.DrawBezier(lapiz,puntosXY[0], puntosXY[1], puntosXY[2], puntosXY[3], puntosXY[4], puntosXY[5], puntosXY[6], puntosXY[7]);
            /*grafica.DrawString(((puntosXY[0] - 305) + 0).ToString(), DefaultFont, brush,(int) puntosXY[0], (int)puntosXY[1]);
            grafica.DrawString(((puntosXY[0] - 305) + 180).ToString(), DefaultFont, brush, (int)puntosXY[0] + 60, (int)puntosXY[1]);
            grafica.DrawString(((puntosXY[0] - 305) + 360).ToString(), DefaultFont, brush, (int)puntosXY[0] + 120, (int)puntosXY[1]);
            grafica.DrawString((((puntosXY[1] - 160) - 1) * (-1)).ToString(), DefaultFont, brush, (int)puntosXY[0], (int)puntosXY[1] - 40);
            grafica.DrawString((((puntosXY[1] - 160) + 1) * (-1)).ToString(), DefaultFont, brush, (int)puntosXY[0], (int)puntosXY[1] + 20);*/

            string punto1 = ((int)(puntosXY[0] - 305) * 3 + "," + (int)((puntosXY[1] - 200) * (-1))).ToString();
            string punto2 = ((int)(puntosXY[2] - 305) * 3 + "," + (int)((puntosXY[3] - 200) * (-1))).ToString();
            string punto3 = ((int)(puntosXY[4] - 305) * 3 + "," + (int)((puntosXY[5] - 200) * (-1))).ToString();
            string punto4 = ((int)(puntosXY[6] - 305) * 3 + "," + (int)((puntosXY[7] - 200) * (-1))).ToString();

            grafica.DrawString(punto1, DefaultFont, brush, puntosXY[0], puntosXY[1]);

            grafica.DrawString(punto2, DefaultFont, brush, puntosXY[2], puntosXY[3]);

            grafica.DrawString(punto3, DefaultFont, brush, puntosXY[4], puntosXY[5]);

            grafica.DrawString(punto4, DefaultFont, brush, puntosXY[6], puntosXY[7]);

            /*grafica.DrawString(((int)(puntosXY[0] - 305) * 3).ToString(), DefaultFont, brush, puntosXY[0], 160);
            grafica.DrawString(((int)(puntosXY[1] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[1]);
            grafica.DrawString(((int)(puntosXY[2] - 305) * 3).ToString(), DefaultFont, brush, puntosXY[2], 160);
            grafica.DrawString(((int)(puntosXY[3] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[3]+60);
            grafica.DrawString(((int)(puntosXY[4] - 305) * 3).ToString(), DefaultFont, brush, puntosXY[4], 160);
            grafica.DrawString(((int)(puntosXY[5] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[5]-80);
            grafica.DrawString(((int)(puntosXY[6] - 305) * 3).ToString(), DefaultFont, brush, puntosXY[6], 160);
            grafica.DrawString(((int)(puntosXY[7] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[7]);*/
        }
        private void GraficaExponencial()
        {
            SolidBrush brush = (SolidBrush)Brushes.Red;
            Pen lapiz = new Pen(Color.Black);
            string punto1 = ((int)puntosXY[0] - 305 + "," + (int)((puntosXY[1] - 200) * (-1))).ToString();
            string punto2 = ((int)puntosXY[2] - 305 + "," + (int)((puntosXY[3] - 200) * (-1))).ToString();
            string punto3 = ((int)puntosXY[4] - 305 + "," + (int)((puntosXY[5] - 200) * (-1))).ToString();
            string punto4 = ((int)puntosXY[6] - 305 + "," + (int)((puntosXY[7] - 200) * (-1))).ToString();

            grafica.DrawBezier(lapiz, puntosXY[0], puntosXY[1], puntosXY[2], puntosXY[3], puntosXY[4], puntosXY[5], puntosXY[6], puntosXY[7]);

            grafica.DrawString(punto1, DefaultFont, brush, puntosXY[0], puntosXY[1]);

            grafica.DrawString(punto2, DefaultFont, brush, puntosXY[2], puntosXY[3]);

            grafica.DrawString(punto3, DefaultFont, brush, puntosXY[4], puntosXY[5]);

            grafica.DrawString(punto4, DefaultFont, brush, puntosXY[6], puntosXY[7]);
            
           /* grafica.DrawBezier(lapiz, puntosXY[0], puntosXY[1], puntosXY[2], puntosXY[3], puntosXY[4], puntosXY[5], puntosXY[6], puntosXY[7]);
            grafica.DrawString(((int)(puntosXY[0] - 305)).ToString(), DefaultFont, brush, puntosXY[0], 160);
            grafica.DrawString(((int)(puntosXY[1] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[1]);
            grafica.DrawString(((int)(puntosXY[2] - 305)).ToString(), DefaultFont, brush, puntosXY[2], 160);
            grafica.DrawString(((int)(puntosXY[3] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[3]);
            grafica.DrawString(((int)(puntosXY[4] - 305)).ToString(), DefaultFont, brush, puntosXY[4], 160);
            grafica.DrawString(((int)(puntosXY[5] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[5]);
            grafica.DrawString(((int)(puntosXY[6] - 305)).ToString(), DefaultFont, brush, puntosXY[6], 160);
            grafica.DrawString(((int)(puntosXY[7] - 160) * (-1)).ToString(), DefaultFont, brush, 305, puntosXY[7]);*/
        }

        public void GraficarPolinomial()
        {
            SolidBrush brush = (SolidBrush)Brushes.Red;
            Pen lapiz = new Pen(Color.Black);

            string punto1 = ((int)puntosXY[0] - 305 + "," + (int)((puntosXY[1] - 200) * (-1))).ToString();
            string punto2 = ((int)puntosXY[6] - 305 + "," + (int)((puntosXY[7] - 200) * (-1))).ToString();
            string punto3 = ((int)puntosXY[14] - 305 + "," + (int)((puntosXY[15] - 200) * (-1))).ToString();

            grafica.DrawBezier(lapiz, puntosXY[0], puntosXY[1], puntosXY[2], puntosXY[3], puntosXY[4], puntosXY[5], puntosXY[6], puntosXY[7]);
            grafica.DrawBezier(lapiz, puntosXY[8], puntosXY[9], puntosXY[10], puntosXY[11], puntosXY[12], puntosXY[13], puntosXY[14], puntosXY[15]);

            grafica.DrawString(punto1, DefaultFont, brush, puntosXY[0], puntosXY[1]);

            grafica.DrawString(punto2, DefaultFont, brush, puntosXY[6], puntosXY[7]);

            grafica.DrawString(punto3, DefaultFont, brush, puntosXY[14], puntosXY[15]);
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            if (validacionGrafica == 1)
                puntosXY = new float[] { 305, 200, 335, 100, 395, 300, 425, 200 };
            else if (validacionGrafica == 2)
                puntosXY = new float[] { 305, 200, 365, 170, 395, 100, 425, 50 };
            else if (validacionGrafica == 3)
                puntosXY = new float[] { 305, 200, 365, 200, 395, 100, 425, 50, 305, 200, 245, 200, 215, 100, 185, 50 };

            ValuScrolbarAngulo = (-1) * trackBarAngulo.Value;
            Transformacion.Rotar(ValuScrolbarAngulo, puntosXY);
            ValuScrolbarX = trackBarX.Value;
            ValuScrolbarY = trackBarY.Value;
            grafica.Clear(Color.White);

            Transformacion.Trsaladar(ValuScrolbarX, ValuScrolbarY, puntosXY);
        }

        private void trasladarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBarX.Enabled = true;
            trackBarY.Enabled = true;
            trackBarAngulo.Enabled = false;
        }

        private void rotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBarX.Enabled = false;
            trackBarY.Enabled = false;
            trackBarAngulo.Enabled = true;
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {

            Reestablecer();
            if(validacionGrafica==1)
                puntosXY = new float[] { 305, 200, 335, 100, 395, 300, 425, 200 };
            else if (validacionGrafica==2)
                puntosXY = new float[] { 305, 200, 365, 170, 395, 100, 425, 50 };
            else if (validacionGrafica == 3)
                puntosXY = new float[] { 305, 200, 365, 200, 395, 100, 425, 50, 305, 200, 245, 200, 215, 100, 185, 50 };

            Transformacion.Trsaladar(0, 0, puntosXY);

            if (validacionGrafica == 1) { GraficarSenoidal(); }
            else if (validacionGrafica == 2) { GraficaExponencial(); }
            else if (validacionGrafica == 3) { GraficarPolinomial(); }
            
            
        }

        private void Reestablecer()
        {
            trackBarAngulo.Value = 0;
            trackBarX.Value = 0;
            trackBarY.Value = 0;
            grafica.Clear(Color.White);
            trackBarX.Enabled = false;
            trackBarY.Enabled = false;
            trackBarAngulo.Enabled = false;
        }
        private void ToolStripMenuItemTransformacion_Click(object sender, EventArgs e)
        {

        }

        private void exponencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reestablecer();
            validacionGrafica = 2;
            puntosXY = new float[] { 305, 200, 365, 170, 395, 100, 425, 50 };
        }

        private void polinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reestablecer();
            validacionGrafica = 3;
            puntosXY = new float[] { 305, 200, 365, 200, 395, 100, 425, 50, 305, 200, 245, 200, 215, 100, 185, 50 };
        }

        private void senoidalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reestablecer();
            validacionGrafica = 1;
            puntosXY = new float[] { 305, 200, 335, 100, 395, 300, 425, 200 };
        }

        private void trackBarAngulo_Scroll(object sender, EventArgs e)
        {
            if (validacionGrafica == 1)
                puntosXY = new float[] { 305, 200, 335, 100, 395, 300, 425, 200 };
            else if (validacionGrafica == 2)
                puntosXY = new float[] { 305, 200, 365, 170, 395, 100, 425, 50 };
            else if (validacionGrafica == 3)
                puntosXY = new float[] { 305, 200, 365, 200, 395, 100, 425, 50, 305, 200, 245, 200, 215, 100, 185, 50 };

            ValuScrolbarX = trackBarX.Value;
            ValuScrolbarY = trackBarY.Value;
            Transformacion.Trsaladar(ValuScrolbarX, ValuScrolbarY, puntosXY);
            ValuScrolbarAngulo = (-1) * trackBarAngulo.Value;
            grafica.Clear(Color.White);
            
            Transformacion.Rotar(ValuScrolbarAngulo,puntosXY);
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            if (validacionGrafica == 1)
                puntosXY = new float[] { 305, 200, 335, 100, 395, 300, 425, 200 };
            else if (validacionGrafica == 2)
                puntosXY = new float[] { 305, 200, 365, 170, 395, 100, 425, 50 };
            else if (validacionGrafica == 3)
                puntosXY = new float[] { 305, 200, 365, 200, 395, 100, 425, 50, 305, 200, 245, 200, 215, 100, 185, 50 };

            ValuScrolbarAngulo = (-1) * trackBarAngulo.Value;
            Transformacion.Rotar(ValuScrolbarAngulo,puntosXY);
            ValuScrolbarX = trackBarX.Value;
            ValuScrolbarY = trackBarY.Value;
            grafica.Clear(Color.White);

            Transformacion.Trsaladar(ValuScrolbarX,ValuScrolbarY,puntosXY);
            
        }
    }
}
