using System;
using System.Collections.Generic;

namespace EmSELab1.DTOs
{
    public class InputDataDto
    {
        public int Y { get; set; }

        public int X1 { get; set; }

        public int X2 { get; set; }


        public static float[,] FindCorrelationMatrix(IList<InputDataDto> list)
        {

            //
            // формула http://statistica.ru/upload/medialibrary/19b/image401.gif
            //

            float[,] corellationMatrixt = new float[3, 3];

            corellationMatrixt[0, 0] = 1;
            corellationMatrixt[1, 1] = 1;
            corellationMatrixt[2, 2] = 1;

            float avrX1 = 0;
            float avrX2 = 0;
            float avrY = 0;

            for (int i = 0; i < list.Count; i++)
            {
                avrX1 += list[i].X1;
                avrX2 += list[i].X2;
                avrY += list[i].Y;
            }

            avrX1 /= list.Count;
            avrX2 /= list.Count;
            avrY /= list.Count;

            float numerator = 0; // числитель
            float denominator1 = 0; // знаменатель 
            float denominator2 = 0;

            // Y X1
            for (int i = 0; i < list.Count; i++)
            {
                numerator += ((list[i].X1 - avrX1) * (list[i].Y - avrY));
                denominator1 += (float) Math.Pow(list[i].X1 - avrX1, 2);
                denominator2 += (float) Math.Pow(list[i].Y - avrY, 2);
            }
            float denominator = (float) Math.Sqrt(denominator1 * denominator2);
            corellationMatrixt[0, 1] = corellationMatrixt[1, 0] = numerator / denominator;

            // Y X2
            numerator = 0;
            denominator1 = 0;
            denominator2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                numerator += ((list[i].X2 - avrX2) * (list[i].Y - avrY));
                denominator1 += (float)Math.Pow(list[i].X2 - avrX2, 2);
                denominator2 += (float)Math.Pow(list[i].Y - avrY, 2);
            }
            denominator = (float)Math.Sqrt(denominator1 * denominator2);
            corellationMatrixt[0, 2] = corellationMatrixt[2, 0] = numerator / denominator;

            // X1 X2
            numerator = 0;
            denominator1 = 0;
            denominator2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                numerator += ((list[i].X1 - avrX1) * (list[i].X2 - avrX2));
                denominator1 += (float)Math.Pow(list[i].X1 - avrX1, 2);
                denominator2 += (float)Math.Pow(list[i].X2 - avrX2, 2);
            }
            denominator = (float)Math.Sqrt(denominator1 * denominator2);
            corellationMatrixt[1, 2] = corellationMatrixt[2, 1] = numerator / denominator;

            return corellationMatrixt;
        }


    } 

}
