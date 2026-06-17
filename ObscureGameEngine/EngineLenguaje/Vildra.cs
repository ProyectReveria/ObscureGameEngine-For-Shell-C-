using System.Net.Mime;

namespace ObscureGameEngine.ViltraProcessPrograming;

public class Vildra
{
    public static string PrintProcess = "NewProces.Log()";
    public static string SumPrimtProcess = "{NewProces.Sum()";
    public static string Detect_Obscure = "{Use_OPSEngine}";
    public static string Detect_Cs = "{Use_OPSCS}";
    

    public static bool LenguajeLexer(string code)
    {
        string[] mathcodeparts; 
        if (code.Contains(PrintProcess))
        {
            string[] CodeParts = code.Split(new[] { '(' }, 2);
            string[] args;
            string[] RawNumber; 

            if (CodeParts.Length > 1) 
            {
                args = CodeParts[1].TrimEnd(')', ';').Split(',');
                
                Console.WriteLine($"[Diana.ObscureEngine] New Process (Log Argument): {args[0]}");
                
                return true; 
            }

            if (code.Contains(SumPrimtProcess))
            {
                mathcodeparts = code.Split(new[] { '(' }, 2);
                if (code.Contains((SumPrimtProcess)))
                {
                    dynamic acumulate; 
                    int tempNumofValues = 1;
                    int value = code.IndexOf('(') + tempNumofValues;
                    int SearchValue_End = code.IndexOf(')'); 
                    args = code.Split(new[] { '(' }, 2);

                    for (int i = 0; i < mathcodeparts.Length; i++)
                    {
                        
                    }
                    
                }
            }
        }
        else
        {
            return false;  
        }
        return false;
        
        
    }
    
    

}