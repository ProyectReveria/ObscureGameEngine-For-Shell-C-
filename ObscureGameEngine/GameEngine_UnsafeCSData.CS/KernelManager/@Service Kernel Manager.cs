using ObscureEngine._Declare__Library;

namespace ObscureEngine.Kernel.Diana.Manager;

public class @Service_Kernel_Manager
{
    private static _Declaration_Enviorment_variables enviorment_KernelStatus = new _Declaration_Enviorment_variables("onRun");
    public static bool _engineStatus_ = false;

    public static bool _EnviormentStatus_()
    {
        string? PropertyStatus = enviorment_KernelStatus.Get_Declare_Property(); 
        if ( PropertyStatus != "onRun")
        {
            return _engineStatus_ = false; 
        }
        else
        {
            return _engineStatus_ = true; 
        }
        
    }

}