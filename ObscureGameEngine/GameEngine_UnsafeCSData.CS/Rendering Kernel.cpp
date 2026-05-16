#include <iostream> 
#include <vector> 
#include <cstdint> 
#include <string> 
#define EngineBitDefinition
#define Configurations
#define Engine_Nucleum





#ifdef EngineBitDefinition

std::int64_t data = 0;

struct Parcel_Reader_nbits{

    static std::int32_t standar_Win32_RunCode = 16; 
    static std::int64_t standar_win64_RunCode = 64; //Also standar AMRx86 
    static std::int32_t standar_i386_RunCode = 32; 
    static std::int64_t GustomStandar_Nbits_Runcode = data; 

    std::string KernelVersion = "Prototipe 0.0.3"; 

};


#endif 

#ifdef Configurations

struct Kernel_Configs{
        bool _IgnoreCpp_ = true; 
        bool _Ignore_DLL = true; 
        bool _UseEngine_RenderKernel = false; 
        bool _Engine_Unsafe = false; 
        std::int64_t Standar_RenderBitSize = static_cast<std::int64_t>(Parcel_Reader_nbits::standar_win64_RunCode); 
        bool CS_Shell = true;
        bool GustomShell = false; 
};

static Kernel_Configs GlobalEngineConfig; 

extern "C" {
    __declspec(dllexport) Kernel_Configs* GetKernelConfiguration(){
        return &GlobalEngineConfig; 
    }
}


#endif 

#ifdef Engine_Nucleum  //Engine Kernel Library
std::int64_t engineRunSize = Parcel_Reader_nbits::standar_win64_RunCode; 
std::int64_t engine_TileSize = 16; 

class DataStruct {

    private: 
    int MemoryUsage_Timers = 0; 
    std::int64_t* MemoryData_Ts;  //TileSize
    public: 


    ///<Clear Memory>/// 
    DataStruct(){
        MemoryData_Ts = nullptr; 
    }

    ~DataStruct(){
        delete MemoryData_Ts; 
    }

      ///<Clear Memory>/// 


    std::int64_t* TileSize(std::int64_t runSize, int tile_x, int tile_y){
        std::vector<int> tileVector = {tile_x,tile_y }; 
        std::int64_t TileSize_Res = runSize * (static_cast<std::int64_t>(tile_x) * static_cast<std::int64_t>(tile_y) ); 

        MemoryData_Ts = new std::int64_t (TileSize_Res); 
        MemoryUsage_Timers +=1; 

        return  MemoryData_Ts;
    }








}; 

#endif 


