using System;
using System.Runtime.InteropServices;

namespace Game_engine_Obscure.Kernel
{

    /// <casa de Diana>
    /// 
    /// Oh c# llegaste a mi vida tras dos años de negacion
    /// y sigues pareciendome molesto con tus dll
    /// o c#
    /// 
    /// (sip pondre esto en cada DLL)
    /// 
    /// Bienvenido a la puerda de Diana AK el AccesPoint DLL del kernel.
    /// si son solo para tener todo en c#, sip es importante.
    /// 
    /// como de costumbre es de diana cuidenlo, no me hagan estallar el motor
    /// 
    /// si ocupan pasarlo a linux o mag recuerten cambiar la estructura del dll.
    /// </summary>
    /// 
    public class RenderingKernel
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Kernel_Configs_Native
        {
            public bool _IgnoreCpp_;
            public bool _Ignore_DLL;
            public bool _UseEngine_RenderKernel;
            public bool _Engine_Unsafe;
            public long Standar_RenderBitSize;
            public bool CS_Shell;
            public bool GustomShell;
        }

        internal static unsafe class KernelConfigs
        {
            [DllImport("ObscureKernel.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr GetKernelConfiguration();
        }

        public bool forceIgnoreNative = false;

        public unsafe void InitializeEngine()
        {
            if (forceIgnoreNative)
            {
                Console.WriteLine("[ObscureEngine.Kernel.DLL] MODO FALLBACK: Ignorando C++ por completo de forma local.");
                return;
            }

            try
            {
                Console.WriteLine("[ObscureEngine.Kernel.DLL] !!!: C++ is active");

                IntPtr configPtr = KernelConfigs.GetKernelConfiguration();
                Kernel_Configs_Native nativeConfig = Marshal.PtrToStructure<Kernel_Configs_Native>(configPtr);

                Console.WriteLine($"IgnoreCpp: {nativeConfig._IgnoreCpp_}");
                Console.WriteLine($"IgnoreDLL: {nativeConfig._Ignore_DLL}");
                Console.WriteLine($"UseEngine: {nativeConfig._UseEngine_RenderKernel}");
                Console.WriteLine($"Unsafe: {nativeConfig._Engine_Unsafe}");
                Console.WriteLine($"BitSize: {nativeConfig.Standar_RenderBitSize}");
                Console.WriteLine($"CS_Shell: {nativeConfig.CS_Shell}");
                Console.WriteLine($"GustomShell: {nativeConfig.GustomShell}");

                if (nativeConfig._IgnoreCpp_ || nativeConfig._Ignore_DLL)
                {
                    Console.WriteLine("[ObscureEngine.Kernel.DLL] Kernel is NOT active");
                }
                else
                {
                    Console.WriteLine("[ObscureEngine.Kernel.DLL] Kernel is active");
                }
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("[ObscureEngine.Kernel.DLL] DLL not Found, DLL is now only on Read Mode (CS pure Unsafe)");
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            RenderingKernel rk = new RenderingKernel();
            rk.InitializeEngine();
        }
    }
}
