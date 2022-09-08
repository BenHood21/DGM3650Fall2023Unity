using System;
using UnityEngine.Events;
using UnityEngine;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, destroyEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnMouseDown()
    {
        destroyEvent.Invoke();
    }
    
}
