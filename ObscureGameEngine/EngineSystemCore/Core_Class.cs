using System.Numerics;
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.InputManager.IA;
using Game_engine_Obscure.Game_user_Interface_Library;
using Game_engine_Obscure.Hitbox;
using Game_engine_Obscure.Game_Manager;
using System.Runtime.Versioning;
using Game_engine_Obscure.Kernel; 
using Game_engine_Obscure.API; 




namespace Game_engine_Obscure;



class Screen_Render_Sceen_Hitbox : Math_Alogirth
{

    public const int Map_Limitx = 16, Map_Limity = 16;
    public static int StarterPointAx = 16, StarterPointAy = 16; //For the cube
    public static int StarterPointBx = 16, StarterPointBy = 16;//for the cube
    public static int _HitBox_PlayerLimit_on_X = Map_Limitx  , _HitBox_PlayerLimit_On_Y = Map_Limity;

}







[SupportedOSPlatform("Windows")]
class Game : Screen_Render_Sceen_Hitbox
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
                Console.SetCursorPosition(Screen_Render_Sceen_Hitbox.StarterPointAx, B);
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




