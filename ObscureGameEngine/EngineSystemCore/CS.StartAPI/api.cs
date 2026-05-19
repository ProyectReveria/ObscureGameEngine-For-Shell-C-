using System; 

namespace Game_engine_Obscure.API; 

class api{

    bool Active_Gustom_APY = false; 
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

    static bool Console(string command){
        if (command == "./EnterGameConsole.GameEngineObscure"){
            Console.
        }
    }
}