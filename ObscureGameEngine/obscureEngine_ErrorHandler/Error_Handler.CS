using System; 

namespace Game_engine_Obscure.API.HerrorHandler; 
/// <summary>
/// A que no sabias de donde nace Marcus y Ferguson. bienvenido a Obscure Engine Erro Handler.
/// 
/// Sip este es mi HQ no explota nada muy seguido pero cuando expltoa alguien tiene que hacer algo, tus dos nuevos (no tan) amigos son Marcus y Ferguson
/// 
/// Marcus es represando por ":3" y usualmente te va a putiar porque estas haciendo algo no deberias, si intentas usar negativos te putea, el engine no esta pensado para eso
/// 
/// el otro es Ferguson, mas calmado pero usualmente si lo ves es porque tiene algo que ver con serializacion, por la naturalesa del motor 
/// la serializacion es delicada, se usa con Json principalmente porque xml apesta.
/// 
/// posdata: ando usando xml para este mensaje
/// 
/// </summary>
class ILoveCorrectPeapol // >:3 
{
    //MapGen
    public static String MapGen_Error_1 = "MapGen [1] : punto base invalido"; // MapGen: Null External or Internal declaration of map generation

    
    //Serialization
    public static String Seralization_1 = "Serialziation [1] [>:3]: el save file no se creo correctamente"; 

    //Special Commands

    public static String  Curontine_1 = "Curontine[1] [:3]: La duracion o la cantidad de siclos son iguales a 0 o nulas ";

    //Kernel

    public static string Kernel_1 = "Kernel[!1!] = GPU cicles can't run on C# if Game is not Active in the proper variable"; 


    
}

class ILoveHandlingErrors // :3
{
    public static bool Catch_Null(bool? Catch_Data)
    {
        return Catch_Data.HasValue; 
    }

}

