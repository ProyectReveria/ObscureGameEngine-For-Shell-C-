using System; 
using System.Numerics;
using System.Text.Json; 
using System.IO; 
using Game_engine_Obscure.Game_Manager;
using Microsoft.VisualBasic;
using Game_engine_Obscure.API.HerrorHandler; 

///<SAVE FILES!>
/// 
/// Te presento a Ania (nombrada en honor a alguien amo mucho)
/// Ania es tu sistema de guardado, tiene la memoria muy buena, dañale algo y no se acuerda de absolutamente nada.
/// es un sistema creara un .json con datos especificos, agrega lso que ocupes esta pensado para eso
/// 
/// Si en esta implementacion el archivo falla al guardarse revisa el codigo entero, porque algo esta muy mal, es una implementacion estandar basada en
/// la documentacio nde c# sobre serialziacion.
/// 
/// <\end_ofText>

namespace Game_engine_Obscure.SaveFile
{
    public class Save_File_Serializate
    {
        public bool SaveFile_Enable = false; 
        public Vector2 SaveFile_Player_Position = new Vector2(0,0); 
        public int Points = 0; 

        public Vector2 SAveFile_EnemyPosition = new Vector2(0,0); 

        public Vector2 Map_Gen_savFile = new Vector2 (0,0); 
    }

    public class On_SaveFile_Event
    {
        public static void _Event_OnSaveFile(bool save_State, Vector2 P_Position, int points, Vector2 E_Position, Vector2 seed)
        {
            var On_SaveFile = new Save_File_Serializate
            {
                SaveFile_Enable = save_State,
                SaveFile_Player_Position = P_Position,
                Points = points,
                SAveFile_EnemyPosition = E_Position, 
                Map_Gen_savFile = seed
            };
            var option = new JsonSerializerOptions {WriteIndented = true}; 
            string JsonSaveFile = JsonSerializer.Serialize(On_SaveFile, option);

            try
            {
                File.WriteAllText("Save_File.Json", JsonSaveFile);
                Console.Write("Marcus [:3]:  Ya guarde la Partida, puede ser encontrada en los archivos como Save_File.Json"); 
            }catch (Exception Excepti_onSerial)
            {
                throw new ArgumentException(nameof(On_SaveFile), ILoveCorrectPeapol.Seralization_1); 
            }
        }
    } 


}