using System;
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

namespace Game_engine_Obscure.accesKey; 

class console_Cryptodata {
    private static random  Cryptografic_RandomKey = random(); 
    static int standarCryptograficKey = 1; //This is the Original Key Secion 
    static string Console_AccesKey(string command){
        int CryptograficKey =  Cryptografic_RandomKey.next(0,4712049710);
        System.WriteLine($"Cryptografic Console ID on Operation{CryptograficKey}"); 

        if (command == "./Cryptografic original Data"){
             Console.WriteLine($"Cryptografic Console origin ID on Operation{standarCryptograficKey}");
             Console.WriteLine("Inser / for finish operation, other command also can be use"); 
            command = Console.WriteLine(); 
             if (command == "/" ){
                return "End"; 
             } 
             if (command == "@Service.Terminal = Terminal.Data.CreateRender(OpenTerminal) not  valid"){
                return "Data is only Read"; 
             }
        }
        return $"String original cryptografic Data is not Change"; 


    }
}