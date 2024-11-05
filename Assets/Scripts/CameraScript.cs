using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Jorge;
    void Update()
    {
        if(Jorge != null)
        {
        Vector3 position = transform.position;
        position.x = Jorge.transform.position.x;
        transform.position = position;
        }
    }
}
