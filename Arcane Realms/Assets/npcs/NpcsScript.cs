using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcsScript : MonoBehaviour
{
    public GameObject player;
    public GameObject dialog;

    public GameObject Instructions;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);

        if (Input.GetKeyDown(KeyCode.E)) {
            Collider[] collider_array = Physics.OverlapSphere(transform.position, 2f);
            foreach(Collider collider in collider_array) {
                if (collider.tag == "player") {
                    dialog.SetActive(true);
                }                                                                                                    
            }            
        }              

        if(Vector3.Distance(gameObject.transform.position, player.transform.position) < 2f)
        {
            Instructions.SetActive(true);
        }else {
            Instructions.SetActive(false);
        }


                                  
    }

                                                
    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "player") {

            Instructions.SetActive(true);
            

            
        } else {
            Instructions.SetActive(false);
        }
    }




}
