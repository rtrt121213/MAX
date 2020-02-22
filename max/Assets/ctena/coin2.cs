using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject q;
    public GameObject wew;
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    void Start()
    {
        q = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        q.transform.position += new Vector3(0, -10, 0);
        wew.transform.position += new Vector3(0, +1, 0);
    }
}
