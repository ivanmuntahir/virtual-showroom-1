using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTriggerHandler : MonoBehaviour
{
    public UnityEvent whileTrigger, whileExit;

    private void OnTriggerEnter(Collider other)
    {
        whileTrigger.Invoke();
        Debug.Log("Door Opened");
    }

    private void OnTriggerExit(Collider other)
    {
        whileExit.Invoke();
    }
}
