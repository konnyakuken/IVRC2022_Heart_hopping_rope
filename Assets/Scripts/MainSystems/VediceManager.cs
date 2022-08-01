using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VediceManager : MonoBehaviour
{
    public event Action<float> OnSendHeartBeat;

    public void SendM5Damaged()
    {
        Debug.Log("SendM5Damaged");
    }

    private void Update()
    {
        OnSendHeartBeat?.Invoke(2.0f);
    }

}
