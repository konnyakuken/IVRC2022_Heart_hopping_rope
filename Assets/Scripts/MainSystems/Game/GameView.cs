using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameView : MonoBehaviour
{
    // variable
    [SerializeField] private Button _startButton;

    // C# events
    public event Action OnClickStart;
    public event Action OnCharactorJump;

    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(() => OnClickStart());
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            OnCharactorJump?.Invoke();
        }
    }
}
