using System; 
using ObscureEngine; 

namespace  ObscureEngine.CNect_UnsafeStack; 

/// <sudo marcus le gusta molestar a gente en 2 bit>
/// ah c#, esta cosita realmente no tiene uso a fecha de hoy.
/// 
/// solamente define el stack, nada importante.
/// </summary>

unsafe class Stacklloc
{
    
    unsafe static void Stacklloc_Update()
    {
        int* stacklloc_Memory_Reserve  = stackalloc int[16];  

        for (int i = 0; i < 16 ;i++)
        {
            stacklloc_Memory_Reserve[i] = 1; 
        }
    }
}