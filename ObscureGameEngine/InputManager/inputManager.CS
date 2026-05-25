using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_engine_Obscure.Hitbox;
using Game_engine_Obscure.CNect_UnsafeStack.ScreenRednerPipeline;
using Game_engine_Obscure.API; 

namespace Game_engine_Obscure.InputManager
{
    
    class ControlMangaer : Screen_Render_Sceen_Hitbox
    {
        public static string command = " "; 
        private static bool activeconsole = false; 
        public static int Px = 8, Py = 8;
        public static int Px_old, Py_old;
        public static float PxF, PyF; // Cardinal Point on Flotate area (F(x) = Xf, Y; for vectors
        public static float PxF_old = Px_old, PyF_old = Py_old; // Cardinal Point on Flotate area (F(x) = Xf, Y; for vectors
        public static int Points = 0;
        ConsoleKeyInfo key = Console.ReadKey(true);

        //Controles

        public enum controlManager
        {
            up,
            down,
            left,
            right,
            Dconsole, 
            none,
        }

        public static void Control()
        {
            Px_old = Px;
            Py_old = Py;
            //Float Value; 
            PxF = Px;
            PyF = Py;
            controlManager direccional_Control = controlManager.none;
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.W: direccional_Control = controlManager.up; Points++; break;
                case ConsoleKey.S: direccional_Control = controlManager.down; Points++; break;
                case ConsoleKey.D: direccional_Control = controlManager.left; Points++; break;
                case ConsoleKey.A: direccional_Control = controlManager.right; Points++; break;
            }

            switch (direccional_Control)
            {
                case controlManager.up: Py--; break;
                case controlManager.down: Py++; break;
                case controlManager.left: Px++; break;
                case controlManager.right: Px--; break;
            }

            if (Px == ControlMangaer.Map_Limitx)
            {
                Px = _HitBox_PlayerLimit_on_X;
            }

            if (Py == ControlMangaer.Map_Limity)
            {
                Py = _HitBox_PlayerLimit_On_Y;
            }



            if (Px < 1)
            {
                Px = 1;
            }

            if (Py < 1)
            {
                Py = 1;
            }

        }
    }
}