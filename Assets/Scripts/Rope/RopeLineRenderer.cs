using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// LineRenderer follows vertices in this script 
/// </summary>

public class RopeLineRenderer : MonoBehaviour
{
    [SerializeField] GameObject[] vertices = new GameObject[20];
    LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Unlit/Color"));
        line.positionCount = vertices.Length;

        foreach (GameObject vertice in vertices)
        {
            vertice.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void Update()
    {
        int index = 0;
        foreach (GameObject vertice in vertices)
        {
            line.SetPosition(index, vertice.transform.position);
            index++;
        }
    }
}