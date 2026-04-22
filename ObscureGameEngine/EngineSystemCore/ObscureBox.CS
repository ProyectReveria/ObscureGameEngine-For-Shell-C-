using System; 
using Game_engine_Obscure; 
using Game_engine_Obscure.InputManager; 


namespace Game_engine_Obscure.Hitbox; 

public class _Hitbox_
{
    public static void _Hitbox_Check(ref int x, ref int y)
    {
        if (x >= Game_engine_Obscure.CNect_UnsafeStack.ScreenRednerPipeline.Screen_Render_Sceen_Hitbox.Map_Limitx)
        {
            x = Game_engine_Obscure.CNect_UnsafeStack.ScreenRednerPipeline.Screen_Render_Sceen_Hitbox._HitBox_PlayerLimit_on_X - 1;
        }

        if (y >= Game_engine_Obscure.CNect_UnsafeStack.ScreenRednerPipeline.Screen_Render_Sceen_Hitbox.Map_Limity )
        {
            y = Game_engine_Obscure.CNect_UnsafeStack.ScreenRednerPipeline.Screen_Render_Sceen_Hitbox._HitBox_PlayerLimit_On_Y - 1;
        }



        if (x <= 1)
        {
            x = 1;
        }

        if (y <= 1)
        {
            y = 1;
        }
    }
}
