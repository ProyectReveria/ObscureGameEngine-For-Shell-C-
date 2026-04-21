using System; 
using Game_engine_Obscure; 

namespace  Game_engine_Obscure.CNect_UnsafeStack; 

//Note: Esta seccion del codigo esta programada con la intencion de comuncarse desde aqui hacia C++, por tanto el codigo de aqui es inestable e inseguro por naturalesa.

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