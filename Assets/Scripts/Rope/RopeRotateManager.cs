using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// to rotate rope gameObjects
/// </summary>

public class RopeRotateManager : MonoBehaviour
{ 
    [SerializeField] private float ropeSpeed = 1.0f;
    [SerializeField] private float initializeLopeRotate = 45.0f;
    [SerializeField] GameObject ropeParent;

    public event Action OnHitLope;

    private void Start()
    {
        RopeInitialize();
    }

    void Update()
    {
        // rotate to rope
        ropeParent.transform.Rotate(new Vector3(ropeSpeed, 0, 0));
    }

    /// <summary>
    /// if hit rope gameobject to player leg
    /// </summary>
    public void HitLope()
    {
        OnHitLope?.Invoke();
    }

    /// <summary>
    /// game start to call this method for Initialize
    /// </summary>
    void RopeInitialize()
    {
        ropeParent.transform.Rotate(new Vector3(initializeLopeRotate, 0, 0));
    }

    /// <summary>
    /// change rope rotate speed
    /// </summary>
    /// <param name="speed"></param>
    public void SetRopeSpeed(float speed)
    {
        ropeSpeed = speed;
    }
}