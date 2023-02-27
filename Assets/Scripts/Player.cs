using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;
    SpriteRenderer sprite;
    Animator anim;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxis("Horizontal");
        inputVec.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // position movement
        Vector2 netxVec = inputVec * speed * Time.deltaTime;
        rigid.MovePosition(rigid.position + netxVec);
    }

    private void LateUpdate()
    {
        anim.SetFloat("Run", inputVec.magnitude);

        if (inputVec.x != 0)
        {
            sprite.flipX = inputVec.x < 0;
        }
    }
}
