using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarAgua : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Coletador>().Agua();
        Destroy(gameObject, 2);

    }
}