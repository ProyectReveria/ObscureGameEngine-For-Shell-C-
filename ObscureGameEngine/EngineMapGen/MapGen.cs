using System;
using System.Numerics;
using Game_engine_Obscure.Mathematics; 
using Game_engine_Obscure.Mathematics.VectorialMath;  

namespace Game_engine_Obscure.Map.io; 

class MapClass : Screen_Render_Sceen_Hitbox 
{
    
    public static bool Valid_MidPoint = false; 
    private static int X_Validpoint; 
    private static int y_Validpoint; 

    public static void MapLimitGeneration(Vector2 BaseMidPoint_Data, Vector2 Center_Data)
    {

        Screen_Render_Sceen_Hitbox.floor_limit = new Vector2 (Center_Data.X + 1, Center_Data.Y + 1);
        Screen_Render_Sceen_Hitbox.Seal_limit = new Vector2 (BaseMidPoint_Data.X -1, BaseMidPoint_Data.Y - 1); 

    }

    public static void Map_Generation(Vector2 baseMidpoint_Data)
    {

        

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
            Console.WriteLine($"Invalid BaseMidpoint Cordinates = {baseMidpoint_Data}"); 
        }


        if (Valid_MidPoint == true)
        {

            Vector2 corner_A = baseMidpoint_Data; 
            Vector2 corner_B = new Vector2 (0,baseMidpoint_Data.Y); 

            MapLimitGeneration(corner_A,corner_B); 

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