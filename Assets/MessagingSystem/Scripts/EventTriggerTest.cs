using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            EventManager.TriggerEvent("test");
        }
        if (Input.GetKeyDown("w"))
        {
            EventManager.TriggerEvent("Spawn");
        }
        if (Input.GetKeyDown("e"))
        {
            EventManager.TriggerEvent("Destroy");
        }
    }
}
