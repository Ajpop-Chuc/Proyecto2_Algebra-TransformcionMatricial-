using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Algebra__TransformcionMatricial_
{
    internal class Transformacion
    {
        public static void  Trsaladar (float a, float b, float[] puntosXY)
        {
            for (int i = 0; i < (puntosXY.Length); i += 2)
            {
                puntosXY[i] += a;
                puntosXY[i + 1] -= b;
            }
        }

        public static void Rotar(float angulo, float[] puntosXY)
        {
            angulo = (float) (angulo * Math.PI) / 180;
            float cos = (float)Math.Cos(angulo), sen = (float)Math.Sin(angulo);
            for (int i = 0; i < (puntosXY.Length); i += 2)
            {
                puntosXY[i] -= 305;
                puntosXY[i + 1] -= 200;
                float vx = puntosXY[i], vy = puntosXY[i + 1];   
                puntosXY[i] = (vx * cos) - (vy * sen);
                puntosXY[i + 1] = (vx * sen) + (vy * cos);
                puntosXY[i] += 305;
                puntosXY[i + 1] += 200;
            }
        }
    }
}
