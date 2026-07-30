using System;
using System.Numerics;


        //Am... se llama jorge y hace lo que dice abajo de este comentario
namespace ObscureEngine.Mathematics
{
    public static class AlgebraicVariables
    {
        #region algebra

        public static float pi = 3.14f; 

        #endregion
    }
    internal class Math_Alogirth
    {
        public static Random RNG = new Random();
        public static Vector2 Get_Vector2Sum(Vector2 Vector_1, Vector2 Vector_2) => Vector_2 + Vector_1;

        public static float Get_Pitagoras(float x, float y) => (float)Math.Sqrt((x * x) + (y * y));

        public static float Get_Sin(float angle) => (float)Math.Sin(angle);
        public static float Get_cos(float angle) => (float)Math.Cos(angle);
        public static float Get_Tan(float angle) => (float)Math.Tan(angle);
        //delta 
        public static float Get_Delta_X(float x1, float x2) => x1 - x2;
        public static float Get_Delta_Y(float y1, float y2) => y1 - y2;

        public static Vector2 Get_Delata_Vector2(float Delta_X, float Delta_Y)
        {
            Vector2 Delta_Vector = new Vector2(Delta_Y, Delta_X);
            return Delta_Vector;
        }

        public static Func<float,float,float> oscilador_SENO = (tiempo, velocidad) => (float) Math.Sin(tiempo * velocidad);
    }
}

