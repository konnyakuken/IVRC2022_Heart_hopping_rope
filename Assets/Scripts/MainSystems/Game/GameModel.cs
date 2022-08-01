using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameModel : MonoBehaviour
{
    public event Action<float> OnSetRopeSpeed;

    /// <summary>
    /// call this method to start game
    /// </summary>
    public void StartGame()
    {
        Debug.Log("GameStart");
        OnSetRopeSpeed?.Invoke(1.0f);
    }

    public void OnGameFail()
    {
        Debug.Log("Lope Hit !!");
        OnSetRopeSpeed?.Invoke(0.0f);
    }

    /// <summary>
    /// ロープのスピード制御
    /// </summary>
    /// <param name="beat"></param>
    public void OnChangeHeartBeat(float beat)
    {
        Debug.Log("beat:" + beat);
    }
}
