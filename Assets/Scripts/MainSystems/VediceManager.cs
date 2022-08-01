using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VediceManager : MonoBehaviour
{
    public event Action<float> OnSendHeartBeat;

    /// <summary>
    /// M5Stickへダメージの処理を送る
    /// </summary>
    public void SendM5Damaged()
    {
        Debug.Log("SendM5Damaged");
    }

    private void Update()
    {
        // M5からもたらされた心拍数の情報を引数として送りたい
        OnSendHeartBeat?.Invoke(2.0f);
    }

}
