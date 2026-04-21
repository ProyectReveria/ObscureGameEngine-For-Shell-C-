#include <iostream>
#include <chrono>

float  GlobalEngineSpeed = 0.0f; 
extern "C"{

    __declspec(dllexport) void ExecuteProcess(int* stackData, int stackSize, float EngineSpeed){

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
        
        std::chrono::duration<float> elapse = timer_Previous - Timer_Concurrenci; 
        DeltaTime_Cnet = elapse.count(); 

        timer_Previous = Timer_Concurrenci; 

        float Engine_Speed = GlobalEngineSpeed;
    } 
}
};

