using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarTerra : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Coletador>().Terra();
        Destroy(gameObject, 2);

    }
}
