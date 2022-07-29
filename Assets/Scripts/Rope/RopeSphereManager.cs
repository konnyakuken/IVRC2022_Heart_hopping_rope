using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSphereManager : MonoBehaviour
{
    private RopeRotateManager ropeRotateManager;

    // Start is called before the first frame update
    void Start()
    {
        ropeRotateManager = GameObject.Find("Rope").GetComponent<RopeRotateManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        ropeRotateManager.OnHitLope();
    }
}
