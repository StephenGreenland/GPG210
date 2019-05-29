using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerScript : MonoBehaviour
{

    public float speed;
    int codeNumber1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x,this.gameObject.transform.position.y + speed * Time.deltaTime,this.gameObject.transform.position.z);
        }
        if (Input.GetKey("s"))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - speed * Time.deltaTime, this.gameObject.transform.position.z);
        }
        if (Input.GetKey("a"))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - speed * Time.deltaTime, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        if (Input.GetKey("d"))
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + speed * Time.deltaTime, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("it hit");
        if (Input.GetKey("q"))
        {
            if (other.gameObject.tag == "Guard"){

                codeNumber1 = (Random.Range(1, 6));
                Debug.Log(codeNumber1);
               
            }


        }


    }


}
