using ObscureEngine; 
using ObscureEngine.Game_Manager; 
using ObscureEngine.Winda;
using System.Numerics; 

namespace ObscureEngine.AnIa;

class __Ia
{


    public struct IAposition
    {
        public float x;
        public float y;

        public void __IAPostionDeclaration(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public static Vector2 IA_Movement(Vector2 position)
    {

        return new Vector2(); 
    }
    
    /* IA Base Position Template
    public static Vector2 IA_Position(Vector2 position)
    {
         IAposition Declaration =  new __Ia.IAposition();
         Declaration.x = position.X;
         Declaration.y = position.Y;
         
         
         
         return new Vector2(Declaration.x, Declaration.y);
        
    }
    
    */

    public static Vector2 __IA_Movement(Vector2 position, int movement, bool Up_Down)
    {
        IAposition Declaration =  new __Ia.IAposition();

        int Range_Loop = Math.Abs(movement); 
        

        if (Up_Down == false)
        {
            for (int i = 0; i < Range_Loop; ++i)
            {
                if (movement <= 0)
                {
                    --position.X; 
                }else if (movement >= 0)
                {
                    ++position.Y; 
                }
            }
        }else if (Up_Down == true)
        {

            for (int i = 0; i < Range_Loop; ++i)
            {
                if (movement <= 0)
                {
                    --position.Y;
                }else if (movement >= 0)
                {
                    ++position.Y;
                }
            }
        }

        Declaration.x = position.X;
        Declaration.y = position.Y;
         
         
        return new Vector2(Declaration.x, Declaration.y);
    }

    public static bool IA_ReadSite(Vector2 position,Char T_target)
    {
        int F_To_I_X = (int)position.X, F_To_I_Y = (int)position.Y;
        
        return Kernel32_DLL.Analizis_CharonSet(F_To_I_X, F_To_I_Y, T_target); 
    }
    
}




