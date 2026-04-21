using System;
using System.Runtime.InteropServices;
using Game_engine_Obscure.Game_Manager;
using Game_engine_Obscure.CNect_UnsafeStack; 

namespace Game_engine_Obscure.CNect_UnsafeStack.Library; 

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
}