using System;
using System.Numerics;
using Game_engine_Obscure.Mathematics; 
using Game_engine_Obscure.Mathematics.VectorialMath;  
using Game_engine_Obscure.API.HerrorHandler; 
using Game_engine_Obscure.ScreenCite;
using System.Runtime.CompilerServices;
using Game_engine_Obscure.API.Engine;

namespace Game_engine_Obscure.Map.io; 

/// <summary>
/// 
/// Map.io recuerdo cuando inicie esto.
/// aun no lo termino (al menos si lees esto en la 1.9.0.Marcus.Ferguson )
/// es un nodo de generacion de mapas, por ahroa es algoritmico procedural.
///
/// </summary>


enum World_Generate_Data : 
{
        player = '\x03B8', 
        wall  = '\x00DF', 
        Enemy = '\u25CB', 
        door,//Agrega mas elementos si hace falta 
}


//base de algoritmo de generacion procedural
class MapClass_MidPointAlgorithm : Screen_Render_Sceen_Hitbox 
{
    
     public static bool Valid_MidPoint = false; 
    private static int X_Validpoint; 
    private static int y_Validpoint; 

    public static void MapLimitGeneration_internal(Vector2 base_Data, Vector2 top_data)
    {

        Screen_Render_Sceen_Hitbox.floor_limit = new Vector2 (base_Data.X + 1, base_Data.Y + 1);
        Screen_Render_Sceen_Hitbox.Seal_limit = new Vector2 (top_data.X -1, top_data.Y - 1); 

    }

        public static void MapLimitGeneration_External(Vector2 base_Data, Vector2 top_data)
    {
        if (base_Data.X == 0 && base_Data.Y == 0)
        {
            Screen_Render_Sceen_Hitbox.floor_limit = new Vector2 (base_Data.X + 1, base_Data.Y + 1);
        }else if  (base_Data.X < 3 && base_Data.Y < 3){
            Screen_Render_Sceen_Hitbox.floor_limit = new Vector2 (base_Data.X - 1, base_Data.Y - 1);
        }else if (base_Data.X >= 3 && base_Data.Y >= 3)
        {
            Screen_Render_Sceen_Hitbox.floor_limit = new Vector2 (base_Data.X - 1, base_Data.Y - 1);
        }
        Screen_Render_Sceen_Hitbox.Seal_limit = new Vector2 (top_data.X +1, top_data.Y -+1); 
    }

    public static void Map_Generation(Vector2 baseMidpoint_Data, bool? External)
    {

        bool Hvalue = ILoveHandlingErrors.Catch_Null(External); 

        

        if ((baseMidpoint_Data.X - 1) % 2 == 0)
        {
            if ((baseMidpoint_Data.Y - 1)  % 2 == 0 && baseMidpoint_Data.X == baseMidpoint_Data.Y )
            {
                 Valid_MidPoint = true; 
            }else
            {
                Valid_MidPoint = false; 
                Console.WriteLine($"Invalid BaseMidpoint Cordinates = {baseMidpoint_Data}"); 
            }
        }else
        {
            Valid_MidPoint = false; 

        }


        if (Valid_MidPoint == true)
        {

            Vector2 corner_A = baseMidpoint_Data; 
            Vector2 corner_B = new Vector2 (0,baseMidpoint_Data.Y); 

            if (External == true && Hvalue == true )
            {
                MapLimitGeneration_External(corner_A,corner_B);
            }else if (External == false &&  Hvalue ==  true)
            {
                MapLimitGeneration_internal(corner_A,corner_B); 
            }else if (Hvalue == false)
            {
                throw new ArgumentNullException(nameof(External), ILoveCorrectPeapol.MapGen_Error_1);
            }


            X_Validpoint = (int)baseMidpoint_Data.X; 
            y_Validpoint = (int)baseMidpoint_Data.Y; 

            //cemtro
            
            Vector2 CentralCordinate = new Vector2(baseMidpoint_Data.X / 2f, baseMidpoint_Data.Y / 2f);
            int MidPoint_CardinalData_X = (int)Math.Floor(CentralCordinate.X),
                MidPoint_CardinalData_Y = (int)Math.Floor(CentralCordinate.Y); 

            //puntos medios de cada esquina

            float midpoint_x1 = Vmath.midpoint_parts(corner_A);
            float midpoint_x2 = Vmath.midpoint_parts(corner_B); 
            float midpoint_x3 = Vmath.midpoint_parts(new Vector2 (corner_A.X,corner_B.X)); 
            float midpoint_x4 = Vmath.midpoint_parts(new Vector2 (corner_B.Y,corner_A.Y)); 

            //Redondeados a piso
            int floorPoint_x1 = (int)Math.Floor(midpoint_x1), 
            floorPoint_x2 = (int)Math.Floor(midpoint_x2), 
            floorPoint_x3 = (int)Math.Floor(midpoint_x3), 
            floorPoint_x4 = (int)Math.Floor(midpoint_x4);


            Console.SetCursorPosition
            (X_Validpoint,0); 
            Console.Write("x"); 

            Console.SetCursorPosition
            (0,y_Validpoint); 
            Console.Write("x"); 

            Console.SetCursorPosition
            (X_Validpoint, y_Validpoint); 
            Console.Write("x"); 

            Console.SetCursorPosition
            (0, 0); 
            Console.Write("x"); 

             
        }

        
    }

}

//base de generacion Lineal
class Generate_Map_Dynamic
{
    public static void Dynamic_Generative_Data(Vector2 Cordinates_T)
    {
        float X_T = Cordinates_T.X; 
        float Y_T = Cordinates_T.Y; 

        for (int i = 0; i < (int)X_T; i++)
        {
            Console.SetCursorPosition((int)X_T,0);
            Console.Write(World_Generate_Data.wall); 
        }

        for (int i = 0; i < (int)Y_T; i++)
        {
            Console.SetCursorPosition(0,(int)X_T); 
            Console.WriteLine(World_Generate_Data.wall); 
        }

        for (int i = 0; i < (int)X_T; i++)
        {
            Console.SetCursorPosition((int)X_T,(int)Y_T); 
            Console.WriteLine(World_Generate_Data.wall); 
        }

        for (int i = 0; i < (int)Y_T; i++)
        {
            Console.SetCursorPosition((int)Y_T,(int)X_T); 
            Console.WriteLine(World_Generate_Data.wall); 
        }
    }
}