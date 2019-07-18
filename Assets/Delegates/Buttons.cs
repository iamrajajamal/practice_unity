using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour, IPointerClickHandler
{
    public UIButtonManager.MyButtons MyButtons_enum;

    public delegate void ButtonPressed(UIButtonManager.MyButtons myButtons);

    public static event ButtonPressed buttonPressed_event;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (buttonPressed_event != null)
            buttonPressed_event(MyButtons_enum);
    }
}
