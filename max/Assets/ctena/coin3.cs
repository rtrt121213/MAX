using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject z;
    public GameObject wew;
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    void Start()
    {
        z = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        z.transform.position += new Vector3(0, -10, 0);
        wew.transform.position += new Vector3(0, +1, 0);
    }
}
