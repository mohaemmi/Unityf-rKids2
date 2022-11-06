using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float jump = 5.0f;
    public float gravity = 15.0f;
    public float speed = 5.0f;
    public Sprite front, back;
    public Sprite right1, right2;
    public Sprite left1, left2;

    private SpriteRenderer spriteRenderer;
    private CharacterController figur;
    private Vector3 moveVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        figur = GetComponent<CharacterController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y -= gravity * Time.deltaTime;

        if (Input.GetButton("Jump")) moveVector.y = jump;

        if (moveVector.x < 0) spriteRenderer.sprite = left1;
        else if (moveVector.x > 0) spriteRenderer.sprite = right1;
        else spriteRenderer.sprite = front;

        figur.Move(moveVector * Time.deltaTime * speed);
    }
}
