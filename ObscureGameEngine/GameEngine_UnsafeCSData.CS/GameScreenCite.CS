using System;
using System.Runtime.InteropServices;
using ObscureEngine.Mathematics; 

namespace ObscureEngine.CNect_UnsafeStack.ScreenRednerPipeline; 



unsafe class Screen_Render_Sceen_Hitbox : Math_Alogirth
{

    private IntPtr _Cent_ScreenMemory; 
    int* Map_Limitx_Memory;
    int* Map_Limity_Memory;
    public const int Map_Limitx = 16, Map_Limity = 16;

       public static int StarterPointAx = 16, StarterPointAy = 16; //For the cube
    public static int StarterPointBx = 16, StarterPointBy = 16;//for the cube
    public static int _HitBox_PlayerLimit_on_X = Map_Limitx  , _HitBox_PlayerLimit_On_Y = Map_Limity;

    public void Memory_Reservation()
    {
        _Cent_ScreenMemory = Marshal.AllocHGlobal(sizeof(int) * 2); 
        
        Map_Limitx_Memory = (int*)_Cent_ScreenMemory;
        Map_Limity_Memory = Map_Limitx_Memory + 1; 

        *Map_Limitx_Memory = Map_Limitx; 
        *Map_Limity_Memory = Map_Limity;
    }



}