using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rew : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ded;
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    void Start()
    {
        ded = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update() { }
}
