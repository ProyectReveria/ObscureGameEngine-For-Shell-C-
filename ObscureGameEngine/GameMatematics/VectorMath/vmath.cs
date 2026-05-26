using System; 
using System.Numerics;
using Game_engine_Obscure.Mathematics; 
using Game_engine_Obscure.Map.io; 
using Game_engine_Obscure.InputManager; 

namespace Game_engine_Obscure.Mathematics.VectorialMath; 
class Vmath
{
    public static float midpoint_parts(Vector2 originalPoint)
    {
        float midpoint; 
        float point_x_1 = originalPoint.X; 
        float point_y_1 = originalPoint.Y; 

        midpoint = (point_x_1 + point_y_1) / 2; 


        
        return midpoint; 
    }
}