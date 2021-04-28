using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarFogo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Coletador>().Fogo();
        Destroy(gameObject, 2);

    }
}
