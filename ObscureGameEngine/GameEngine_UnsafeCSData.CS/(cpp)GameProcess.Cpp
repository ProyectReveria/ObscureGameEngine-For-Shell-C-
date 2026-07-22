#include <iostream>
#include <chrono>

/*
no mentire deberia borrar esto.

lo que tienen aqui es un delta time en c++.

tienen el de c# es mas rapido de usar y esta cosa es mas presia, menos eficiente.

avisados estan.
*/

float  GlobalEngineSpeed = 0.0f; 
extern "C"{


    __declspec(dllexport) void ExecuteProcess(int* stackData, int stackSize, float EngineSpeed){ //32 bit Stack / 2 nucleum  520 Vram; Windows Win32 kernel

        GlobalEngineSpeed = EngineSpeed; 
        for (int i = 0; i < stackSize; i++){
            stackData[i] = (int)(stackData[i] + EngineSpeed);
        }
    }
}

namespace Cnet {
    class Obscure_Cnet {
        public:
            static inline float EngineSpeed_Current = 0.0f;
    };
}

class _Cnet_DeltaTime {
    public: 
    void _Cnet_ActiveDeltaTime(){
    auto timer_Previous = std::chrono::steady_clock::now(); 
    float DeltaTime_Cnet = 0.0f; 

    while (true){ 
        auto Timer_Concurrenci = std::chrono::steady_clock::now(); 
        
        std::chrono::duration<float> elapse =  Timer_Concurrenci - timer_Previous; 
        DeltaTime_Cnet = elapse.count(); 

        timer_Previous = Timer_Concurrenci; 

        float Engine_Speed = GlobalEngineSpeed;
    } 
}
};

