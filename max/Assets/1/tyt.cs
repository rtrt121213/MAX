using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tyt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wew;
    public GameObject playr;
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;

    void Start()
    {
        wew = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    { }
    private void OnTriggerEnter()
    {
        wew.transform.position += new Vector3(0,-10, 0);
        FindObjectOfType<Text>().text = "Вы выйграли//нет";
        playr.transform.position += new Vector3(50, -3, 50);
    }
}
  
