using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject player;   //�v���C���[���i�[�p
    //private Vector3 offset;      //���΋����擾�p

    // Start is called before the first frame update
    void Start()
    {
        //unitychan�̏����擾
        this.player = GameObject.Find("U_CharacterSelf");

        // MainCamera(�������g)��player�Ƃ̑��΋��������߂�
        //offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //�V�����g�����X�t�H�[���̒l��������
        transform.position = player.transform.position;
    }
}
