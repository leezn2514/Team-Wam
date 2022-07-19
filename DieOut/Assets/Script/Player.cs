using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator player_ani;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player_ani = GetComponent<Animator>();
    }

    void Update()
    {
        player_ani.SetBool("is_Walk", false);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * 10.0f);
            spriteRenderer.flipX = true;

            player_ani.SetBool("is_Walk", true);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * 10.0f);
            spriteRenderer.flipX = false;

            player_ani.SetBool("is_Walk", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector2.up * Time.deltaTime * 10.0f);
            player_ani.SetBool("is_Walk", true);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector2.down * Time.deltaTime * 10.0f);
            player_ani.SetBool("is_Walk", true);

        }
    }
}
