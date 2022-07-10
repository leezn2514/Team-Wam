using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * 10.0f);
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * 10.0f);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector2.up * Time.deltaTime * 10.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector2.down * Time.deltaTime * 10.0f);
        }
    }
}
