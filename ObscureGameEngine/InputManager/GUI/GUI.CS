using System; 
using Game_engine_Obscure; 
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.Game_Manager; 


namespace Game_engine_Obscure.Game_user_Interface_Library;


internal class GUI
{
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
                    GameManager_OperativeBehavior.Game_Active = true;
                    Console.Clear();
                }
                else if (Respuesta == "2")
                {
                    Console.WriteLine("Programa Detenido, para iniciar Reinicie");
                }
                else
                {
                    Console.WriteLine("no es un opcion valida");
                    GUI.Game_UI();
                }
            }
        }
    }
       public static void Game_Over_UI()
    {

        if (GameManager_OperativeBehavior.Game_oveer == true)
        {
            Console.Clear();
            Console.WriteLine("Game over");
            Console.WriteLine($"Puntuacion {GameBeheivorData.Points}");
            Console.WriteLine("Close System");
        }
    }
}
