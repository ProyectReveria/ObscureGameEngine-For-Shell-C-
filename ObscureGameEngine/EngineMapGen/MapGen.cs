using System;
using System.Numerics;
using Game_engine_Obscure.Mathematics; 

namespace Game_engine_Obscure.Map.io; 

class MapClass
{
    
    public static bool Valid_MidPoint = false; 
    private static int X_Validpoint; 
    private static int y_Validpoint; 

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
            }
        }else
        {
            Valid_MidPoint = false; 
        }

        if (Valid_MidPoint == true)
        {
            X_Validpoint = (int)baseMidpoint_Data.X; 
            y_Validpoint = (int)baseMidpoint_Data.Y; 
                    int opsetCornerx = X_Validpoint; 
                    int opsetCornery = y_Validpoint; 
            
            Vector2 CentralCordinate = new Vector2(baseMidpoint_Data.X / 2f, baseMidpoint_Data.Y / 2f);
            int MidPoint_CardinalData_X = (int)Math.Floor(CentralCordinate.X ),
                MidPoint_CardinalData_Y = (int)Math.Floor(CentralCordinate.Y); 


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