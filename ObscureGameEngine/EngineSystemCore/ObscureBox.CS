using System; 
using Game_engine_Obscure; 
using Game_engine_Obscure.InputManager; 


namespace Game_engine_Obscure.Hitbox; 

/// <:O>
/// LA HITBOX, ES EFECTIVAMENTE ES LA HITBOX
/// </:O>
/// se que te preguntas que es esto, este es el arhivo por le cua lse hacia ORIGINALMENTE la hitbox y el manejo de hitbox, si nombre? obscure BOX
/// sip es primitivo y util, su nombre es muy ironicamente OMMMMMMMMMMMMM
/// porque? PORQUE ES BIEN R(OMMMMMMMMMM)las 
/// se buguea por existir
/// por lo que es terrible pel(OMMMMMMMMMMMMMM)tudo
/// creo se entendio
/// 
/// <OMMMMMMMMMMMMMMMMMMMMM>

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
