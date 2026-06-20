using System.Net.Mime;

namespace ObscureGameEngine.VildraProcessPrograming;

public struct DataTypes
{
    public int process_Integerl;
    public double Process_Double;
}

public class DataTypeCreation
{
    static dynamic double_Integer(int arg_nt)
    {
        DataTypes data = new DataTypes(); 
        data.process_Integerl = arg_nt; 
        
        return data; 
    }
}

public class Vildra
{
    public static string PrintProcess = "NewProces.Log()";
    public static string SumPrimtProcess = "NewProces.Sum()";
    public static string NewProxData = "NewProces.Protocol()";
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
                    int start = code.IndexOf('(') + 1; 
                    int length = code.IndexOf(')') - start; 
                    string content = code.Substring(start, length);

                    double total = content.Split(',')
                        .Select(n => double.Parse(n.Trim()))
                        .Sum();
                    
                    Console.WriteLine($"[Diana.ObscureEngine] Process @Sum is complete: {total}");

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