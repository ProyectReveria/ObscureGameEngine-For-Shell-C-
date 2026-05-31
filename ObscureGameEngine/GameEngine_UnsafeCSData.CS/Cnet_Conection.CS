using System;
using System.Runtime.InteropServices;
using ObscureEngine.DeltaTime; 
using ObscureEngine.Game_Manager;
using ObscureEngine.CNect_UnsafeStack; 

namespace ObscureEngine.CNect_UnsafeStack.Library; 


/// <Cnet>
/// 
/// Oh c# llegaste a mi vida tras dos años de negacion
/// y sigues pareciendome molesto con tus dll
/// o c#
/// 
/// (sip pondre esto en cada DLL)
/// 
/// o Cnet, ignorando la referencia a Skinet este es probablemente le archivo mas peligroso de TODO el engine.
/// esto es un contacto a cpp y es importante se entienda esto: RESERVA MEMORIA
/// sip el engine tiene un sistema por defecto para reservar memoria y corre a partir de estos dos dll y son tan bolatiles qu eno me soprenderia puedan dañar una gpu
/// 
/// Si los tenes que usar (por openGL o Vulkan) valora los riesgos antes
/// 
/// </end.ofDiana>

class Cnet_Conector  
{

    public unsafe class GameProcess
    {
        private const string Library_Name = "ObscureGameEngine.dll"; 

        [DllImport(Library_Name, CallingConvention = CallingConvention.Cdecl)]

        public static extern void Stack_Process_Cnet(int* stackdata, int size, float EngineSpeed); 

        public void Cnet_FrameUpdate()
        {
            float EngineSpeed = Game_Manager.GameBeheivorData.Delta_Time_Speed; 
            int* Buffer = stackalloc int[16]; 

            Stack_Process_Cnet(Buffer,16,EngineSpeed);
        }

    }

    public unsafe class GameProcess_MapSize
    {
        private const string Library_Name = "ObscureGameEngine_TileSize.dll";
        [DllImport(Library_Name, CallingConvention = CallingConvention.Cdecl)]

        public static extern void Size(int* size); 

        public void Cnet_TileUpdate()
        {
            int _Size = 0; 

            unsafe
            {
                Size(&_Size); 
            }
        }
    }


}