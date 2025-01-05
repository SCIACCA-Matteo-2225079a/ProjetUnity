using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("J'ai démarré");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Je tourne");
        transform.Rotate(new Vector3(1, 0, 0) * 90 * Time.deltaTime);
    }
}
