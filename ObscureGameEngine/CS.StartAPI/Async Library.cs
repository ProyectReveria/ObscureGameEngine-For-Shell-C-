using System;
using ObscureEngine.DeltaTime;
using ObscureEngine.Mathematics;


namespace ObscureEngine.API.Async;
class Async_Library
{
    public async Task<int> on_AnyUpdate(int frames)
    {
        _DeltaTime_.RunDeltaTime();
        return frames + 1; 
    }
}