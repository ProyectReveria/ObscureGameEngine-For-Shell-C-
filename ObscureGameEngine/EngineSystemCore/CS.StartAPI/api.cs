using System.Numerics;
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.InputManager.IA;
using Game_engine_Obscure.Game_user_Interface_Library;
using Game_engine_Obscure.Hitbox;
using Game_engine_Obscure.Game_Manager;
using System.Runtime.Versioning;
using Game_engine_Obscure.Kernel; 


namespace Game_engine_Obscure.API; 

class api{

    bool static Active_Gustom_APY = false; 
    bool static Debug_Mode_Apy = false; 
    static void API_MAIN(){
        Console.WriteLine("API is off: Obscure engine gustom functions for execute data is on beta");
 
    }

    static void Active_API(bool statement){
        if (statement == true){
            Active_Gustom_APY = true;
        } else {
            Active_Gustom_APY = false; 
        }
    }

    static bool Api_Console(string command){
        if (command == "./EnterGameConsole.GameEngineObscure"){
            Console.Clear();
            Console.WriteLine("Restart Game Engine, Game engine un UserMode");
            return false;
        }
        if (command == "./EnterGameConsole.GameEngineObscure(Start.Debug)"){
            Console.Clear();
            Console.WriteLine("Engine on Debug Mode");
            return false;
        }
        if (command == "./dotnet Cnet Check(check Score)"){
            Console.WriteLine($"Puntuacion {GameBeheivorData.Points}"); 
            return false;
        }
        if (command == "./dotnet Cnet Check(ResetScore)"){
            GameBeheivorData.Points = 0; 
            return false;
        }
        if (command == "./PrintConfigs(Kernel)"){
            Console.WriteLine("for check the kernel cheeck in the Engine EngineSystemCore->GameEngine_UnsefeCSDAta.CS -> Kernel");
            return false; 
        }
        if (command == "./Help()"){
            Console.WriteLine("Work in progress!");
            return false; 
        }

        return false;
    }
}