using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void OnTriggerEnter(Collider other)
    {
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
    }
}
