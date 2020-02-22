using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _target; // в инспекторе задаём объект движения
    public float speed = 10;
    public GameObject playr;//здесь ми указываем персонажа как игровой Object;
    public float jumptime = 0.5f;
    float tyt = 0;
    public Animator wew;
    void Start()
    {
        playr = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //if (tyt <(-1)) {
          //  tyt = -1;
        //}
        //if (tyt > 0) { }

        tyt -= Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            playr.transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed;
    
        }
        if (Input.GetKey(KeyCode.S))
        {
            playr.transform.position += new Vector3(0, 0, -1) * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.D))
        {
            playr.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
     
        }
        if (Input.GetKey(KeyCode.A))
        {
            playr.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.Space)&& tyt<=0)
        {
            playr.transform.position += new Vector3(0, 7, 0) * Time.deltaTime * speed;
            tyt = jumptime;
            wew.SetInteger("wew",3) ;

        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playr.transform.position += new Vector3(0, 7, 0) * Time.deltaTime * speed*2;
            tyt = jumptime;

        }
        if (Input.GetKey(KeyCode.R))
        {
    

        }

    }
    void OnCollisionEnter(Collision col)
    {
        var ded = col.gameObject.GetComponent<rew>();
        if (ded != null)
        {
            speed = 20;
        }
        var baba = col.gameObject.GetComponent<opo>();
        if (baba != null)
        {
            speed = 5;
        }

    }
}
