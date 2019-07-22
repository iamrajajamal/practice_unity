using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Test1 : MonoBehaviour
{
    private UnityAction someListener;

    private void Awake()
    {
        someListener = new UnityAction(SomeFunction);
    }

    private void SomeFunction()
    {
        Debug.Log("SomeFunction was called");
    }

    private void OnEnable()
    {
        EventManager.StartListening("test", someListener);
    }
    private void OnDisable()
    {
        EventManager.StopListening("test", someListener);
    }
}
