using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// to rotate rope gameObjects
/// </summary>

public class RopeRotateManager : MonoBehaviour
{ 
    public float speed = 1.0f;
    [SerializeField] GameObject ropeParent;

    private void Start()
    {
        ropeParent.transform.Rotate(new Vector3(90, 0, 0));
    }

    void Update()
    {
        ropeParent.transform.Rotate(new Vector3(speed, 0, 0));
    }

    public void OnHitLope()
    {
        Debug.Log("Lope Hit !!");
        speed = 0;
    }

}