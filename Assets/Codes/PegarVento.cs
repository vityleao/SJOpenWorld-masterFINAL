using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarVento : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Coletador>().Vento();
        Destroy(gameObject, 2);

    }
}
