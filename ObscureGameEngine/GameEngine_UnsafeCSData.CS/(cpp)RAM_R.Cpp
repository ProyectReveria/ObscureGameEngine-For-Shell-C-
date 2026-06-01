#include <iostream>
#include <cstring> 

/*

Este es el cuarto de Laura, porfi molestenla, esto es como en linux NO HAY HUEVOS A UN sudo "rm -rf --no-preserve-root" 
pero lo borrado en ves de ser el sistema operativo es quiza tu targeta grafica.
aqui se hacen muchas cosas y la mas importante tiene que ver con external C
Es volatil, si. porque? 

si se dan cuenta y leen el codigo notaran que como que hay demasiadas especificaciones de memoria y celdas. esto no es aleatorio y al final no lo use por razones (Marcus)
es un espacio reservado para crear celdas ademas de correr procesos especificos. 

pon un punero mal, explota
pon un dato mal
explota
pon un std::int64_t sin direccion y con un for (int i = 0; i < 481724980174; i++), por favor no lo hagas podes reventar tu procesador (es anecdota).

*/


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