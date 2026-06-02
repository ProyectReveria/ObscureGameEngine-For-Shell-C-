using System.Runtime.InteropServices;

namespace ObscureEngine.Winda;

public class Kernel32_DLL
{
    [DllImport("kernel32.dll", SetLastError = true,EntryPoint = "ReadConsoleOutputCharacterW")]
    public static extern bool ReadConsoleChar(
            IntPtr hConsoleOutput,
            [Out] char[] lpCharacter,
            uint nLength,
            COORD dwReadCoord,
            out uint lpNumberOfCharsRead); 
    [DllImport("kernel32.dll", SetLastError = true,EntryPoint = "GetStdHandle")]
    public static extern IntPtr GetsdHandle(int nStdHandle);

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        public short X;
        public short Y;
    }

    public static bool Analizis_CharonSet(int P_X, int P_Y, char D_Target)
    {
        IntPtr Hout = GetsdHandle(-11); 
        
        char[] buffer = new char[1];
        uint read = 0; 
        
        COORD Post = new COORD { X = (short)P_X , Y = (short)P_Y };

        if (ReadConsoleChar(Hout, buffer, 1,Post,out read))
        {
            return buffer[0] == D_Target;
        }

        return false; 
    }

} 