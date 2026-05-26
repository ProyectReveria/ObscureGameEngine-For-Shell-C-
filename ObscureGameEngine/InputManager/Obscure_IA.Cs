using Game_engine_Obscure;
using Game_engine_Obscure.InputManager;
using Game_engine_Obscure.InputManager.IA;
using Game_engine_Obscure.Mathematics;
using Game_engine_Obscure.DeltaTime;
using Game_engine_Obscure.Hitbox;
using Game_engine_Obscure.ScreenCite; 
using System;
using System.Numerics;
using Game_engine_Obscure.Game_user_Interface_Library;
using Game_engine_Obscure.Game_Manager;

///<completionlist cref="IA"/>
/// ok lean bien
/// esta es la IA, si la IA es determinista denle una hojada y lean la documentacion (si es que la hago)
/// esta consume exactamente 12 siclos por cada 16 acciones, si es terrible eficiente y s me costo hacerla.
/// traten de protegerla.
namespace Game_engine_Obscure.InputManager.IA;

internal class Enemy_IA : ControlMangaer
{
    public static int _IA_Position_X = Math_Alogirth.RNG.Next(0, Screen_Render_Sceen_Hitbox.Map_Limitx - 1), _IA_Position_Y = Math_Alogirth.RNG.Next(0, Screen_Render_Sceen_Hitbox.Map_Limity - 1);
    public static float _IA_FloatPostion_X, _IA_FloatPostion_Y;
    public static int _IA_Position_X_old, _IA_Position_Y_old;

    public static void UpdateFloat_IA_()
    {
        _IA_FloatPostion_X = _IA_Position_X;
        _IA_FloatPostion_Y = _IA_Position_Y;
    }




}

class _IA_LogicalDetector : Enemy_IA
{
    public static float _IA_Logical_Cardinal_X, _IA_Logical_Cardinal_Y;
    public static Vector2 location = new Vector2(_IA_LogicalDetector._IA_Logical_Cardinal_X, _IA_Logical_Cardinal_Y); // Ia Location eh puesto esto despues.

    //Update Logical Cardinals for IA 
    public static void _Logical_Cardenal_Update()
    {
        _IA_Logical_Cardinal_X = _IA_FloatPostion_X;
        _IA_Logical_Cardinal_Y = _IA_FloatPostion_Y;
    }


    static float _Logical_Cardinates_IA_Distance(float Px_IA, float Py_IA, Vector2 args)
    {
        UpdateFloat_IA_();
        _Logical_Cardenal_Update();


        location = new Vector2(Px_IA, Py_IA);
        args = new Vector2(Px_IA, Py_IA);
        return Vector2.Distance(location, args);
    }

    public static Vector2 _IA_Cardinal_Desplasamiento(float x, float y)
    {
        UpdateFloat_IA_();
        _Logical_Cardenal_Update();
        Vector2 _IA_DesplazamientoV2 = new Vector2(x, y);
        return _IA_DesplazamientoV2;
    }

    public static float Player_Distance(float Player_Aritmetic_Cardenal_X, float Player_Aritmetic_Cardenals_Y, float V_range) //En realidad esto es la distancia pero ahora me da peresa cambiar el nombre de cada metodo
    {
        UpdateFloat_IA_();
        _Logical_Cardenal_Update();
        location = new Vector2(_IA_LogicalDetector._IA_Logical_Cardinal_X, _IA_Logical_Cardinal_Y);
        Vector2 Player_Aritmetic_Position_Vector2 = new Vector2(Player_Aritmetic_Cardenal_X, Player_Aritmetic_Cardenals_Y);
        return Vector2.Distance(location, Player_Aritmetic_Position_Vector2); //Poner despues a la ia a hacer la arimetica.
    }

    public static Vector2 Player_Lock_DesplasamientoVector2(float Player_Aritmetic_Cardenal_X, float Player_Aritmetic_Cardenals_Y)
    {
        UpdateFloat_IA_();
        _Logical_Cardenal_Update();
        Vector2 Player_DesplazamientoV2 = new Vector2(Player_Aritmetic_Cardenal_X, Player_Aritmetic_Cardenals_Y);
        return Player_DesplazamientoV2;
    }
}

class IA_Logical_Controler : Enemy_IA
{
    public static void Enemy_IA_Controler()
    {
        float _Delta_Run_Time = oscilador_SENO(_DeltaTime_._RunDeltaTime_, Game_Manager.GameBeheivorData.GameEngine_Speed);
        _IA_Position_X_old = _IA_Position_X;
        _IA_Position_Y_old = _IA_Position_Y;

        Vector2 Playervector = _IA_LogicalDetector.Player_Lock_DesplasamientoVector2(ControlMangaer.PxF, ControlMangaer.PyF);
        Vector2 IAVector = _IA_LogicalDetector._IA_Cardinal_Desplasamiento(_IA_FloatPostion_X, _IA_FloatPostion_Y);
        float Delta_X = Get_Delta_X(Playervector.X,IAVector.X); 
        float Delta_Y = Get_Delta_Y(Playervector.Y, IAVector.Y);

        Vector2 DistanceVector = Get_Delata_Vector2(Delta_X,Delta_Y); 
        
        if (_IA_FloatPostion_X < Px)
        {
            _IA_Position_X +=  1 * Game_Manager.GameBeheivorData.GameEngine_Speed;
        } else if (_IA_FloatPostion_X > Px)
        {
            _IA_Position_X -=1 * Game_Manager.GameBeheivorData.GameEngine_Speed; 
        }else if (_IA_Position_Y < Py)
        {
            _IA_Position_Y +=1 * Game_Manager.GameBeheivorData.GameEngine_Speed; 
        }else if (_IA_Position_Y > Py)
        {
            _IA_Position_Y -=1 * Game_Manager.GameBeheivorData.GameEngine_Speed; 
        }
        

        if (_IA_Position_X == ControlMangaer.Px && _IA_Position_Y == ControlMangaer.Py)
        {
            GameManager_OperativeBehavior.Game_Active = false;
            GameManager_OperativeBehavior.Game_oveer = true;
            Console.SetCursorPosition(_IA_Position_Y, _IA_Position_X);
            Console.Write(" ");
            GUI.Game_Over_UI();

        }




    }
}