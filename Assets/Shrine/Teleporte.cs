using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleporte : MonoBehaviour
{
    // Start is called before the first frame update
    public string Level;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CommomValues.ShrinePlayerPosition = other.transform.position - other.transform.forward * 3;

            StartCoroutine(MyLoadScene());
        }
    }

    IEnumerator MyLoadScene()
    {
        Camera.main.SendMessage("FadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(Level);
    }
}
