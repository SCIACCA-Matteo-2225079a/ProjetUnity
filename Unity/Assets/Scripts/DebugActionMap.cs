using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugActionMap : MonoBehaviour
{
    Coroutine m_MovingCoroutine;
    public void Move(InputAction.CallbackContext context)
    {
        if (m_MovingCoroutine == null)
        {
            m_MovingCoroutine = StartCoroutine(Moving(context));
        }
    }

    IEnumerator Moving(InputAction.CallbackContext context)
    {
        while (context.started)
        {
            Vector2 value = context.ReadValue<Vector2>();
            Debug.Log("Moving " + value);
            yield return null;
        }
        m_MovingCoroutine = null;
    }
}
