//C# library
using System; 
using System.Numerics;
//Obscure Library and Internal Lenguaje 
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.InputManager.IA;
using Game_engine_Obscure.Game_user_Interface_Library;
using Game_engine_Obscure.Game_Manager;
using System.Runtime.Versioning;
using Game_engine_Obscure.Kernel; 
using Game_engine_Obscure.API;
using Game_engine_Obscure;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
//Save File (De nada se que siempre se ocupa)
using Game_engine_Obscure.SaveFile; 

///<summary>///
/// 
/// Bienvenido a Obscure Game Engine 
/// Engine Version: 1.9.9.:3.>:3
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

namespace Game_engine_Obscure; 
class Obscure_Game_Engine : GameManager_OperativeBehavior
{
    public static bool GameActive = GameManager_OperativeBehavior.Game_Active; 
    /*

    public static void main(){

    //!Game Active: 
    GameManager_OperativeBehavior.Game_Active = true
    
    }

    */ 
} 