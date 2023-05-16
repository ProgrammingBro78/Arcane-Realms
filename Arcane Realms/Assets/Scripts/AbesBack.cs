using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbesBack : MonoBehaviour
{
    public GameObject Instructions;
    private void OnTriggerEnter(Collider collision) { 
        if (collision.gameObject.tag == "player") {
            Instructions.SetActive(false);
        }
    }
}
