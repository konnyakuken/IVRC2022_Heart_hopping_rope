using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePresenter : MonoBehaviour
{
    // Game
    [SerializeField] private GameModel gameModel;
    [SerializeField] private GameView gameView;
    // User
    [SerializeField] private UserPresenter userPresenter;
    //Manager
    [SerializeField] private RopeRotateManager ropeManager;

    // Start is called before the first frame update
    void Start()
    {
        // view -> gameModel
        gameView.OnClickStart += gameModel.StartGame;

        // view -> userPresenter -> userView
        gameView.OnCharactorJump += userPresenter.userView.CharactorJump;

        // model -> ropeManager
        gameModel.OnSetRopeSpeed += ropeManager.SetRopeSpeed;

        // ropeManager -> model
        ropeManager.OnHitLope += gameModel.OnGameFail;

        // ropeManager -> userPresenter -> vediceManager
        ropeManager.OnHitLope += userPresenter.vediceManager.SendM5Damaged;

        // vediceManager -> userPresenter -> OnSendHeartBeat
        userPresenter.vediceManager.OnSendHeartBeat += gameModel.OnChangeHeartBeat;
    }
}
