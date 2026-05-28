using System;
using System.Runtime.CompilerServices;
using Game_engine_Obscure.API.HerrorHandler; 

namespace Game_engine_Obscure.API.Engine; 

public class Engine_Special_Names
{
    public static int sicles = 0; 

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.NoInlining)]
    public static void Curontine(int duration, int siclenum)
    {
        if (duration == 0 || siclenum == 0)
        {
            throw new ArgumentException(nameof(duration), ILoveCorrectPeapol.Curontine_1);
        }
        
        for (int i = 0; i < duration + 1; i++)
        {
            Thread.Sleep(50); 
            if (i == duration - 1)
            {
                sicles++; 
                i = 0; 
            }

            if (sicles == siclenum)
            {
                break; 
            }

        }
    }
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.NoInlining)]
    public static void on_Stop(int time)
    {
        Thread.Sleep(time); 
    }
}