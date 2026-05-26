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

/// <summary> 
/// 
/// A que este archivo llamo tu atencion?
/// esto son bases MUY basicas para cyberseguridad, pense a alguien le serviria aunque para ser sinsero deberia poner un exception error sacado de EngineConsoleLimitGutom para esto
/// 
/// Este archivo es un Yagni, realmente no lo vas a ocupar a no ser que haya algo importante, y si es ilegal no me metas para eso esta Marcus.
/// 
/// El sistma funciona, genera uan llave random en cada iteracion y si esa llave no es igual a 1 el engine corre como una version nueva, mi recomendacion es que crees una de 0
/// una ves implementes la llave este programa trabaja de forma unica, si lo monetisas recuerda darme creditos
/// 
/// </end_ofText>

public class Console_Cryptodata 
{

    private static Random Cryptografic_RandomKey = new Random(); 
    
    ///<exception cref="standarCryptograficKey">///
    /// 
    /// se que se ve raro tambien pero si, esto tiene una standar key. lo cierto es que yo pongo una para confirmar es una version sin modificar
    /// 
    /// si modificas el engine mantenla en 1 y crea uan segunda llave. a si ambos como desarolladores sabemos que dimos nuestra parte
    /// 
    /// y sip,puse un bucle anidado, y que?
    /// 
    /// </end_ofSysten32>
    static int standarCryptograficKey = 7; 
    static bool cruptokeys_use = true; 

    public static string Console_AccesKey(string? command)
    {
        // Corregido a .Next() y ajustado el maximo al limite de un int32 (2147483647)
        int CryptograficKey = Cryptografic_RandomKey.Next(0, 2147483647);
        
        // Corregido System por Console
        Console.WriteLine($"Cryptografic Console ID on Operation: {CryptograficKey}"); 

        if (command == "./Cryptografic original Data")
        {
            Console.WriteLine($"Cryptografic Console origin ID on Operation: {standarCryptograficKey}");
            Console.WriteLine("Insert / for finish operation, other command also can be use"); 
            
            command = Console.ReadLine(); 

            if (command == "/") 
            {
                return "End"; 
            } 
            if (command == "@Service.Terminal = Terminal.Data.CreateRender(OpenTerminal) not valid")
            {
                return "Data is only Read"; 
            }
        }
        
        return "String original cryptografic Data is not Change"; 
    }

    public static bool  CryptograficStructureData()
    {
        while (cruptokeys_use == true)
        {
            if (standarCryptograficKey != 7)
            {
                Console.WriteLine("This is NOT one Valid product from the original seed, if you read this has IA put in your original new code (The Company is use invalid reproduction of Obscure Engine using IA)");
                for (int i = 0; i < 100000000; i++)
                {
                    for (int j = 0; j < 100000000; j++)
                    {
                        Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                        Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    }
                    Console.Clear(); 
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                    Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
                }
            }
        }
        return false; 
    }
}