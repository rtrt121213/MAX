using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wewew : MonoBehaviour
{
    Animator sas;
    Animator asa;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            sas.SetBool("sas", !sas.GetBool("sas"));
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            asa.SetBool("asa", !asa.GetBool("asa"));
        }
    }
}
