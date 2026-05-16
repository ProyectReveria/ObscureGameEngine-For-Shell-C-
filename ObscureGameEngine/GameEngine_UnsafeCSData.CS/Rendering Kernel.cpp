#include <iostream> 
#include <vector> 
#include <cstdint> 

struct Nbits{
    std::int64_t data = 0; //This variable define how much data the engine have ONLY AND JUST ONLY if the Kernel is Modify, in that case change EngineRunSize from 64 bits to Data size;
};

#ifdef Engine_Nucleum  //Engine Kernel Library
std::int64_t engineRunSize = 64; 
std::int64_t engine_TileSize = 16; 

class DataStruct {
    public: 

    int MemoryUsage_Timers = 0; 
    std::int64_t* MemoryData_Ts;  //TileSize
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




    private: 

}; 

#endif 


