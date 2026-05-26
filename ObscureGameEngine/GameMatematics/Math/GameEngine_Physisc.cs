using System; 
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.DeltaTime;
using System.Numerics;

            //Palutena quiere las phisicas de vuelta.
namespace Game_engine_Obscure.Physics; 
class _Physics_  : Mathematics.Math_Alogirth 
{
    class Universal_Constants
    {
        #region  Physics universal Variables
        public float Universal_Gravity_Constant = 6.674e-11f; 
        public float Earth_Gravity = 9.81f;
        #endregion 
    }
    
    public static float Gravity_Const_Aceleration_G( float universal_Gravity_Constant, float Stelar_Entity_Masa, float Stelar_entity_Radio)
    {
        float  Gravity_Aceleration = (universal_Gravity_Constant * Stelar_Entity_Masa) / (float)Math.Pow( Stelar_entity_Radio,2); 
        return Gravity_Aceleration;
    }

    public static float Newton_Str(float masa, float Gravity_Aceleration) => masa * Gravity_Aceleration; 
    public static Vector2 Newton_Aceleration(Vector2 Position_i, Vector2 position_K, float Tiempo) => (Position_i - position_K)/ Tiempo; 

}