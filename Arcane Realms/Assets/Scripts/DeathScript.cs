using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript: MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            OnTriggerEnter();
        }
    }

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(2);
    }
}
