using System.Numerics;
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.InputManager.IA;


namespace Game_engine_Obscure;

class ScreenCite : Math_Alogirth
{

    public const int Map_Limitx = 16, Map_Limity = 16;
    public static int StarterPointAx = 16, StarterPointAy = 16;
    public static int StarterPointBx = 16, StarterPointBy = 16;
    public static int _HitBox_PlayerLimit_on_X = Map_Limitx - 1, _HitBox_PlayerLimit_On_Y = Map_Limity - 1;


}

public static class GameBeheivorData
{
    public static bool Sincron = true;
    public static bool Asincron = false;

    public static float _IA_ROV = 7.0f;
    public static float _Ia_speed = 1.0f;
}



public static class GameManager
{

    public static bool Game_Active = false;
    public static bool Game_oveer = false;



    public static void Game_UI()
    {
        {
            {
                Console.WriteLine("Bienvenido, Esto es un prototipo tecnico (actualmente de  deteccion) hice de forma simple");
                Console.WriteLine("Para iniciar Precione 1, para salir precione 2. Cualquier otra cosa efectuara la segunda opcion");
                Console.WriteLine("Una ves pierdas la partida se da la puntuacion y debe reiniciar el programa");
                string? Respuesta = Console.ReadLine();

                if (Respuesta == "1")
                {
                    Game_Active = true;
                    System.Console.Clear();
                }
                else if (Respuesta == "2")
                {
                    Console.WriteLine("Programa Detenido, para iniciar Reinicie");
                }
                else
                {
                    Console.WriteLine("no es un opcion valida");
                    GameManager.Game_UI();
                }
            }
        }
    }


    public static void Game_Over_UI()
    {

        if (GameManager.Game_oveer == true)
        {
            Console.Clear();
            Console.WriteLine("Game over");
            Console.WriteLine($"Puntuacion {ControlMangaer.Points}");
            Console.WriteLine("Close System");
        }
    }

}






class Game : ScreenCite
{
    public static void Main(string[] args)
    {
        GameManager.Game_UI();


        if (GameManager.Game_Active == true)
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
                Console.SetCursorPosition(ScreenCite.StarterPointAx, B);
                Console.Write("x");
            }
            for (int B2 = 0; B2 < StarterPointBy + 1; B2++)
            {
                Console.SetCursorPosition(B2, StarterPointAy);
                Console.Write("x");
            }


        }

        while (GameManager.Game_Active == true)
        {
            Console.SetCursorPosition(0, 17);
            Console.Write($"IA positon {Enemy_IA._IA_Position_X},{Enemy_IA._IA_Position_Y}");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine($"Actual distance {_IA_LogicalDetector.Player_Lock(ControlMangaer.PxF, ControlMangaer.PyF, GameBeheivorData._IA_ROV)}");

            ControlMangaer.Control();
            Console.SetCursorPosition(ControlMangaer.Px_old, ControlMangaer.Py_old);
            Console.Write(" ");
            Console.SetCursorPosition(ControlMangaer.Px, ControlMangaer.Py);
            Console.Write("0"); //Player
            Console.SetCursorPosition(Enemy_IA._IA_Position_X_old, Enemy_IA._IA_Position_Y_old);
            Console.Write(" ");
            Console.SetCursorPosition(Enemy_IA._IA_Position_X, Enemy_IA._IA_Position_Y);
            Console.Write("2"); //Enemy
            Console.SetCursorPosition(0, 17);
            //Console.WriteLine($"Points: {Player.Points}");


        }
    }

}




