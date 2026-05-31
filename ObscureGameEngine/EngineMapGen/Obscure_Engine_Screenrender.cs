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

    public const int Map_Limitx = 16, Map_Limity = 16;

    public static  Vector2 floor_limit; 
    public static  Vector2 Seal_limit; 

    public static int StarterPointAx = 16, StarterPointAy = 16; //For the cube
    public static int StarterPointBx = 16, StarterPointBy = 16;//for the cube
    public static int _HitBox_PlayerLimit_on_X = Map_Limitx  , _HitBox_PlayerLimit_On_Y = Map_Limity;

    public static Vector2 MapCenter = new Vector2 (0,0); 
}