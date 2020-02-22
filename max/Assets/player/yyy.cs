using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yyy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _target; // в инспекторе задаём объект движения
    public float speed1 = 20;
    public GameObject camera1;//здесь ми указываем персонажа как игровой Object;
    public GameObject playr;
    public float jumptime = 0.5f;
    float tyt = 0;
    public float speed = 10;
    // Start is called before the first frame update
    float a = 0;
    void Start()
    {
        camera1 = (GameObject)this.gameObject;
        a = camera1.transform.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        a -= Input.GetAxis("Mouse Y") * Time.deltaTime * speed1;
        float b = Input.GetAxis("Mouse X") * Time.deltaTime * speed1;
        a = Mathf.Clamp(a, -90, 90);
        playr.transform.Rotate(0,b,0);
        Vector3 rotation = camera1.transform.eulerAngles;
        rotation.x = a;
        camera1.transform.eulerAngles = rotation;
        tyt -= Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            playr.transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playr.transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playr.transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playr.transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Space) && tyt <= 0)
        {
            playr.transform.position += new Vector3(0, 7, 0) * Time.deltaTime * speed;
            tyt = jumptime;
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
