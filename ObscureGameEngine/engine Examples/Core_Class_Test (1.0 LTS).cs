using System.Numerics;
using ObscureEngine.DeltaTime;
using ObscureEngine.Mathematics;
using ObscureEngine.InputManager;
using ObscureEngine.InputManager.IA;
using ObscureEngine.Game_user_Interface_Library;
using ObscureEngine.Hitbox;
using ObscureEngine.Game_Manager;
using System.Runtime.Versioning;
using ObscureEngine.Kernel; 
using ObscureEngine.API; 
using ObscureEngine.ScreenCite; 

///<summary> /// 
/// 
/// Como es de Imaginar durante el desarollo existio una clase para probar el engine en si
/// 
/// por la forma en que esta desarollado este corre con el codigo completamente abierto
/// A esto se le llama Enfoque "Blueprint" (o "Plano"), significa que esto es una libreria de clases MUY Grande.
/// 
/// Simplemente desactive (oh borre, si lo hace asegurese de borrar el Namespace "Game Engine Obscure.Test")
/// 
/// Siempre puede encontrar este mismo ejemplo en todas las versiones LTS a partir de la 1.0
/// 
/// </end_ofText>///

#if Open_Example_obc

namespace ObscureEngine.test;


[SupportedOSPlatform("Windows")]
[Obsolete("1.0 LTS Core Example")] class Game : Screen_Render_Sceen_Hitbox
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Desa activar la consola para una revicion? y/N"); 
        string? comman = Console.ReadLine().ToLower(); 
        if (comman == "y")
        {
            Console.WriteLine("insert command"); 
            string? api_command = Console.ReadLine();
            Api.Api_Console(api_command);
        }

        Api.API_MAIN(); 
        GUI.Game_UI();
        Game_FrameUpdate Start_Point = new Game_FrameUpdate(); 

        
        if (GameManager_OperativeBehavior.Game_Active == true)
        {
            for (int A = 0; A < StarterPointAx + 1; A++)
            {
                Console.SetCursorPosition(A, 0);
                Console.Write("x");
            }
            for (int A2 = 0; A2 < StarterPointAy + 1; A2++)
            {
                Console.SetCursorPosition(0, A2);
                Console.Write("x");
            }

            for (int B = 0; B < StarterPointBx + 1; B++)
            {
                Console.SetCursorPosition(StarterPointAx, B);
                Console.Write("x");
            }
            for (int B2 = 0; B2 < StarterPointBy + 1; B2++)
            {
                Console.SetCursorPosition(B2, StarterPointAy);
                Console.Write("x");
            }


        }

        while (GameManager_OperativeBehavior.Game_Active == true)
        {
            Console.SetCursorPosition(0, 17);
            Console.Write($"plyaer {InputManager.ControlMangaer.Px},{InputManager.ControlMangaer.Py}");
            Console.SetCursorPosition(0, 18);
            

            ControlMangaer.Control();
            _Hitbox_._Hitbox_Check(ref InputManager.ControlMangaer.Px,ref InputManager.ControlMangaer.Py);
            Console.SetCursorPosition(ControlMangaer.Px_old, ControlMangaer.Py_old);
            Console.Write(" ");
            Console.SetCursorPosition(ControlMangaer.Px, ControlMangaer.Py);
            Console.Write("0"); //Player
            Console.SetCursorPosition(Enemy_IA._IA_Position_X_old, Enemy_IA._IA_Position_Y_old);
            Console.Write(" ");
            IA_Logical_Controler.Enemy_IA_Controler();
            _Hitbox_._Hitbox_Check(ref Enemy_IA._IA_Position_X,ref Enemy_IA._IA_Position_Y);
            Console.SetCursorPosition(Enemy_IA._IA_Position_X, Enemy_IA._IA_Position_Y);
            Console.Write("2"); //Enemy
            Console.SetCursorPosition(0, 17);
            //Console.WriteLine($"Points: {Player.Points}");
            

        }
    }




}

#endif 




