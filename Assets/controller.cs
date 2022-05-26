using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    float speed = 9;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") ==true)
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("down") == true)
        {
            this.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("right") == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left") == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        text.text = col.gameObject.tag;
    }
    
    
}
