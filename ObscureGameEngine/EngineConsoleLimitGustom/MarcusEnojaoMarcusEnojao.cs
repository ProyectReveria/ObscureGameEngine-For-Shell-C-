using System;
using System.Numerics;
using ObscureEngine;
using ObscureEngine.API; 

namespace ObscureEngine.Yagnie_Y_Marcus_Enojaos;
/// <yo avise>
/// 
///                         :3
/// 
/// </yo avise>
/// 
/// <nota>
/// 
/// deberia ponerle punteros a esta cosa solo por tocar los huevos, capas lo hago para el dia de los inocentes actualizo el repo y nadie se da ni cuenta
/// 
/// <nota>
class MarcusEnojao_porquealguntarao_seleolvido_el_API
{
    public static string ImakeMarcusMad_1 = "Marcus[1]: Algun completo y total idiota se le olvido usar el comando en la consola y API";
    public static string ImakeMarcusMad_2 = "Marcus[2]: Mira... CAMBIAS EL CENTRO PARA QUE SEA 0,0? LO ES POR DEFECTO. ALA AQUI TENES TU ERROR, Y SI ES LOGICO NO PUEDE SER 0, ES QUE ES EL COLMO"; 
}

class Yagni_Console_Negative_Allow()  // ^-^
{
    private static bool Negative_FeedReturn = Api.NegativeLimit; 

    private static Vector2 newlimit( Vector2 map_Center, Vector2 map_newCenter)
    {
            if (map_newCenter.X == 0 && map_newCenter.Y == 0)
        {
            throw new ArgumentException (nameof (map_newCenter), MarcusEnojao_porquealguntarao_seleolvido_el_API.ImakeMarcusMad_2);
        }
            float xValue = map_Center.X + map_newCenter.X;
            float Yvalue= map_Center.Y + map_newCenter.Y;

            return new Vector2 (xValue, Yvalue);

    }
    

    public static void N_Behaivoior(Vector2 map_Center, Vector2 map_newCenter)
    {
        if (Negative_FeedReturn == false)
        {
            Console.WriteLine("Marcus (:3): En serio crees que Rosary es a si de tonto don't you? esta desactivado por defecto, porque crees la clase se llama Yagni? es mas ala toma un error ");
            throw new ArgumentException(nameof(Negative_FeedReturn), MarcusEnojao_porquealguntarao_seleolvido_el_API.ImakeMarcusMad_1);
        } else if (Negative_FeedReturn == true)
        {
            
            Console.WriteLine("Marcus (>>:3): Recuerda que tienes que configurar a mano que haga toda la generacion desde el centro y ahora el centro base de la consola");
            
            Vector2 MapCenter_NewCenter = newlimit(map_Center,map_newCenter); 
        }
    }
}