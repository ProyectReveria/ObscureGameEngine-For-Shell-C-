using ObscureEngine.Kernel.Diana.Manager;

namespace ObscureEngine.Treading.Delta;

using System; 
using System.Diagnostics; 
using System.Threading; 


/// <Delta time Kernel Level>
/// Notaras que particularmente tengo muchos delta times, no es porque me guste programarlos de hecho son LO MISMO TODO EL PUTO RATO.
/// Esta delta no deberias llamarlo nunca, es su propio hilo, y te preguntaras. PARA QUE PUTAS OCUPO OTRO DELTA.
/// Este sostiene las fisicas por si mismo. de hay su importancia. no puede correr en el mimso hilo y por naturalesa ocupa un Pointer.
/// </Diana>

public unsafe class Physics_Kernel
{
    public static Stopwatch Timer = new Stopwatch();
    public static double Timer_Elapsed => Timer.Elapsed.TotalMilliseconds;
    public static void @Physics_Delta()
    {
        
        if (@Service_Kernel_Manager._engineStatus_)
        {
            Timer.Start();
        }else 
        {
            Timer.Stop();
        }
    }
}



