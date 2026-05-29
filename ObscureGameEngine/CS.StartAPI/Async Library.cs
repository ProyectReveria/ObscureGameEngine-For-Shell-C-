using System;
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Mathematics;


class Async_Library
{
    public async Task<int> on_AnyUpdate(int frames)
    {
        _DeltaTime_.RunDeltaTime();
        return frames + 1; 
    }
}