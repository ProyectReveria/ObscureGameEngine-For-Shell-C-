using System.Runtime.InteropServices; 
using System.Diagnostics;
using System.Numerics;
using ObscureEngine.Game_Manager;
using System.Data;
using ObscureEngine.API.HerrorHandler;

namespace ObscureEngine.Kernel.Diana; 


public unsafe class Kernel_Corontine
{
    private static Stopwatch GPU_Cicles = new Stopwatch(); 
    private static Stopwatch Restart_Times = new Stopwatch(); 
    double Timer; 

    public static long ticks; 
    public void Execute_Cicle(){
        
        GPU_Cicles.Restart();
        Restart_Times.Start(); 

        long Ticks_on_Restart = GPU_Cicles.ElapsedTicks; 

        if (Game_Manager.GameManager_OperativeBehavior.Game_Active == false)
        {
            GPU_Cicles.Stop(); 
            
            throw new ArgumentOutOfRangeException(nameof(GPU_Cicles), ILoveCorrectPeapol.Kernel_1); 
        }


        if (Ticks_on_Restart == 6000)
        {
            GPU_Cicles.Stop(); 
            Restart_Times.Stop(); 
        }

        //! Kernel Execute Timer !// 

        GPU_Cicles.Stop(); 
        Restart_Times.Stop(); 
        

        ticks = GPU_Cicles.ElapsedTicks; 

        

    }
}




public unsafe class Kernel_Memory_Allow
{
    private static IntPtr Newbuffer = Marshal.AllocHGlobal(16 * 4); 


    public void delete_Buffer() => Marshal.FreeHGlobal(Newbuffer); 
    
}

public class SafeKernelData
{
    public static long Tick_Public = Kernel_Corontine.ticks; 
}


