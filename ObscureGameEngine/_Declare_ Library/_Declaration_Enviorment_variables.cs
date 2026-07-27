namespace ObscureEngine._Declare__Library;
using ObscureEngine.Game_Manager;
//< Recordar continuar esto para poder declarar estancias dentro del engine main> 

public static class @Service_Variables_Serialize_Enviormnet_Variables
{
    public static _Declaration_Enviorment_variables @Service_Variables_Serialize_Contract(String? enviorment)
    {
        return enviorment switch
        {
            "Declarete"  => new _Declaration_Enviorment_variables("Declarete"),
            "informal" => new _Declaration_Enviorment_variables("informal"),
            "Iprivate" => new _Declaration_Enviorment_variables("Iprivate"),
            "Ipublic" => new _Declaration_Enviorment_variables( "Ipublic"),
            "onRun" => new _Declaration_Enviorment_variables( "onRun"),
            _ => throw new NotImplementedException(
                "[Diana]:Null Reference on Enviorment variable is not implement has {Null} and result on {Null Assigment on Struct}"),
        }; 
    }
}

public struct _Declaration_Enviorment_variables
{

    private String _Declare_Property;
    
    //Enviorment Data Type  
    private string? Declarete;
    private string? informal;
    private string? Iprivate;
    private string? Ipublic;
    private string? onRun;
    //endof
    public _Declaration_Enviorment_variables(String? property)
    {
        _Declare_Property = property;
    }
    
    public string Get_Declare_Property() => _Declare_Property;

    public static _Declaration_Enviorment_variables Struct_Engine(string enviorment)
    {
        return new _Declaration_Enviorment_variables(enviorment);
    }
    
    public _Declaration_Enviorment_variables GameManager_Evariable(string enviorment)
    {
        dynamic? gameData_Enviorment; 
        
        return @Service_Variables_Serialize_Enviormnet_Variables.Service_Variables_Serialize_Contract(enviorment);
    }
}





class _Determinate_Porperty
{
    private static string _Property; 
    private static _Declaration_Enviorment_variables _Enviorment = new _Declaration_Enviorment_variables(GameBeheivorData.EngineEnviormentVariable);
    // "Declarete","Informal", "IPublic","Iprivate","on run"
    // "Valor ya declarado","Valor declarado pero sin propiedad util", "Visible para el resto" , "invisible" , "Protocolario" 


    public static async Task _Property_Declare_Confirm()
    {
        var EnvResult = _Enviorment.GameManager_Evariable(GameBeheivorData.EngineEnviormentVariable);

        string? activeProperty = EnvResult.Get_Declare_Property(); 
        if (_Property == " " || _Property == null)
        {
            _Property = "informal";
            Console.WriteLine($"Informal protocol in Enviorment Property: {_Property}, Declare Async Property");
        }
        
        
    }
}