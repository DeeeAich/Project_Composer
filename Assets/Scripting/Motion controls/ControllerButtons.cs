using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Animations;

public class ControllerButtons : MonoBehaviour
{

    [SerializeField] InputActionReference grip;
    [SerializeField] InputActionReference trigger;

    [SerializeField] UnityEvent gripPull;
    [SerializeField] UnityEvent gripRelease;
    [SerializeField] UnityEvent triggerPull;

    bool gripped = false;
    bool triggered = false;

    private void Update()
    {
        
        if(!gripped && grip.action.ReadValue<float>() > 0)
        {
            gripped = true;

            gripPull.Invoke();

        }
        else if(gripped && grip.action.ReadValue<float>() == 0)
        {
            gripped = false;

            gripRelease.Invoke();
        }

        if (!triggered && trigger.action.ReadValue<float>() > 0)
        {

            triggered = true;

            triggerPull.Invoke();

        }
        else if(triggered && trigger.action.ReadValue<float>() == 0)
                triggered = false;

    }

}
