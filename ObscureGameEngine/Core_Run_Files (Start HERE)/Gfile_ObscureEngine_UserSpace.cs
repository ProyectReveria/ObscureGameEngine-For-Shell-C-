//C# library
using System; 
using System.Numerics;
//Obscure Library and Internal Lenguaje 
using ObscureEngine.DeltaTime;
using ObscureEngine.Mathematics;
using ObscureEngine.InputManager;
using ObscureEngine.InputManager.IA;
using ObscureEngine.Game_user_Interface_Library;
using ObscureEngine.Game_Manager;
using System.Runtime.Versioning;
using ObscureEngine.Kernel; 
using ObscureEngine.API;
using ObscureEngine;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
//Save File (De nada se que siempre se ocupa)
using ObscureEngine.SaveFile;
using System.Security.Cryptography.X509Certificates;
using ObscureEngine.EngineSystemCore.MainExecute;
using ObscureEngine.AnIa;

///<summary>///
/// 
/// Bienvenido a Obscure Game Engine 
/// Engine Version: 2.0.0:3.>:3
/// 
/// Versiones LTS: Obscure engine 1.0 
/// 
/// Wiki: //! on Development.
/// Recomendado para uso: Vscode,Studio code. 
/// Ejecute en la Terminal por defecto de C#. 
/// Lenguajes en soporte: C# | C++ (POR FAVOR NO PIDA SOPORTE PARA OTROS LENGUAJES)
/// 
/// Actualmente esta en la Funcion main(), retire el "/* */" ademas de desactivar core_class_test y esta listo para uso.
/// Recuerde leer el manual
/// 
/// Gracias por usar Obscure Engine for Shell! 
/// 
/// Posdata: Mi sistema de errores del engine se llama Marcus y Ferbuson. Sip estan diseñados para tratarte mal. Avisado estas (y no son IA, es que les puse nombre)
/// 
/// </end_ofText> ///

namespace ObscureEngine; 
class ObscureEngine_Main : GameManager_OperativeBehavior
{
    public class Game_FrameUpdate
    {
        public static float Update_Frame = 60; 
        public static float Status_update = 0; 
    }
    public static bool GameActive = GameManager_OperativeBehavior.Game_Active;

    public static void Engine_Process_Line()
    {
        
    }

    public static void Engine_Process_Frame()
    {
        
    }


}