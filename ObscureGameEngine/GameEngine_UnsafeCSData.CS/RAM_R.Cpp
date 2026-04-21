#include <iostream>
#include <cstring> 

    struct Cell {
        float postx,posy; 
        float velx,vely; 

        float futureStackx[16]; 
        float futurestatey[16]; 
    };

Cell* MemoryDirection = nullptr;  
int FrameSice = 0; 
extern "C" {

    __declspec(dllexport) void Cnet_TileUpdate(int _Size){
            if (MemoryDirection == nullptr && _Size > 0){
        FrameSice = _Size; 
            MemoryDirection = new Cell[FrameSice]; 
            std::memset(MemoryDirection, 0, sizeof(Cell) * FrameSice); 
    }

    __declspec(dllexport) void Cnet_DataManagement();{
        if (MemoryDirection != nullptr){
            delete[] MemoryDirection; 
            MemoryDirection = nullptr; 
            FrameSice = 0; 
        }
    }
    }

}