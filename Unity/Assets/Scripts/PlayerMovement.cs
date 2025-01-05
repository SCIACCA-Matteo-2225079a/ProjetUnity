using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 10.0f;
    public float PlayerRotationSpeed = 100.0f;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * PlayerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * PlayerRotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0,rotation,0);
    }
}
