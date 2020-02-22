using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject s;
    public GameObject wew;
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    void Start()
    {
        s = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        s.transform.position += new Vector3(0, -10, 0);
        wew.transform.position += new Vector3(0, +1, 0);
    }
}
