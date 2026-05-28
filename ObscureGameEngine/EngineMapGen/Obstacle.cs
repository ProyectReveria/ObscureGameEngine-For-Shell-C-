using System;
using System.Numerics;
using Game_engine_Obscure.API.Engine;

namespace Game_engine_Obscure.Map.Obstacles; 

class Obstacles_KITTYKAT : Engine_Special_Names
{
    public static void obstacle(Vector2 position, Vector2 finalPosition)
    {
        
        if (position.X < finalPosition.X)
        {
            on_Stop(50); 
            for (int i = 0; i < 12; i++)
            {
                float tempData = position.X; 
                
                if (position.X != finalPosition.X)
                {
                    position.X++; 
                }

                if (position.X == finalPosition.X)
                {
                    position.X--;
                }

                if (i == 11)
                {
                    i = 0; 
                }
            }
        }

    }
}