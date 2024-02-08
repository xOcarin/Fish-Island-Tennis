using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using Unity.VisualScripting;

public class cameracontroller : NetworkBehaviour
{
    public GameObject cameraHolder;
    public Vector3 offset;


    public override void OnStartAuthority()
    {
        if (isLocalPlayer)
        {
            cameraHolder.SetActive(true);
        }
        if (!isLocalPlayer)
        {
            cameraHolder.SetActive(false);
        }
        
    }

    public void Update()
    {
        if (isLocalPlayer)
        {
            cameraHolder.transform.position = transform.position + offset;
        }
        if (!isLocalPlayer)
        {
            cameraHolder.SetActive(false);
        }
    }
}