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

    void Update()
    {
        ropeParent.transform.Rotate(new Vector3(speed, 0, 0));
    }
}