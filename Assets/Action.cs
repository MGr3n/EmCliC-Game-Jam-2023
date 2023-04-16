using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.G) == true)
        {

            other.GetComponent<PlayerController>().points += 1;


            Destroy(gameObject);



        }

    }




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
