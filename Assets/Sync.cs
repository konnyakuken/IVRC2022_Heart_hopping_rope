using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sync : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;   //プレイヤー情報格納用
    
    void Start()
    {
        //unitychanの情報を取得
        this.player = GameObject.Find("U_CharacterSelf");
    }

    // Update is called once per frame
    void Update()
    {
        //public Transform GetBoneTransform(HumanBodyBones humanBoneId);
        //新しいトランスフォームの値を代入する
        transform.position = player.transform.position;
    }
}
