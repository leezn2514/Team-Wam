using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdasd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * 10.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * 10.0f);
        }
    }
}
