using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sync : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;   //�v���C���[���i�[�p
    
    void Start()
    {
        //unitychan�̏����擾
        this.player = GameObject.Find("U_CharacterSelf");
    }

    // Update is called once per frame
    void Update()
    {
        //public Transform GetBoneTransform(HumanBodyBones humanBoneId);
        //�V�����g�����X�t�H�[���̒l��������
        transform.position = player.transform.position;
    }
}
