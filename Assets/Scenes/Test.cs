using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //[SerializeField] GameObject NeckPos;
    //public GameObject Camera;
    public GameObject Head;
    public GameObject body;
    public GameObject SteamCamera;
    public GameObject SteamCameraRig;
    public HumanBodyBones bone;

    void Start()
    {

    }

    void Update()
    {
        Transform HeadTransfrom = Head.transform;
        Vector3 HeadPos = HeadTransfrom.position;

        SteamCameraRig.transform.position = HeadPos;
        //SteamCamera.transform.position = HeadPos;
       

        //SteamCamera.transform.eulerAngles = new Vector3(0, Head.transform.eulerAngles.y, 0);
        //SteamCamera.transform.rotation = Quaternion.Euler(new Vector3(0f, Head.transform.eulerAngles.y, 0f));
    }
}


