using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPickable : MonoBehaviour
{

    public AudioSource m_coinSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter : " + other.name);
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}
