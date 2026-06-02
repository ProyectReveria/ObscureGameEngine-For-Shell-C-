using System; 
using System.Numerics; 
using ObscureEngine.Mathematics;

namespace ObscureEngine.ScreenCite; 

/// <summary>
/// 
/// Am... esto aunque no lo paresca es lo que permite generar mapas por defecto
/// si em... recuerdenme re-hacer todo este script en la 3.0? 
/// si 3.0
/// creo
/// no se
/// 
/// </summary>
class Screen_Render_Sceen_Hitbox : Math_Alogirth
{
    

    public static  Vector2 floor_limit; 
    public static  Vector2 Seal_limit; 

    public static int StarterPointAx = (int) floor_limit.X, StarterPointAy = (int) floor_limit.Y; //For the cube
    public static int StarterPointBx = (int)Seal_limit.X, StarterPointBy = (int)Seal_limit.Y;//for the cube
    public static int _HitBox_PlayerLimit_on_X   , _HitBox_PlayerLimit_On_Y ;

    public static Vector2 MapCenter = new Vector2 (0,0); 
}