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

    private float current = 0.0f;
    private SpriteRenderer renderer;
    private CharacterController figur;
    private Vector3 moveVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        figur = GetComponent<CharacterController>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y -= gravity * Time.deltaTime;

        if (Input.GetButton("Jump")) moveVector.y = jump;

        if (moveVector.x < 0) goLeft();
        else if (moveVector.x > 0) goRight();
        else renderer.sprite = front;

        figur.Move(moveVector * Time.deltaTime * speed);
    }

    private void goLeft()
    {
        current += Time.deltaTime;
        if (current < 0.2f && (renderer.sprite == left1 || renderer.sprite == left2)) return;
        if (renderer.sprite == left1)
            renderer.sprite = left2;
        else
            renderer.sprite = left1;
        current = 0.0f;
    }

    private void goRight()
    {
        current += Time.deltaTime;
        if (current < 0.2f && (renderer.sprite == right1 || renderer.sprite == right2)) return;
        if (renderer.sprite == right1)
            renderer.sprite = right2;
        else
            renderer.sprite = right1;
        current = 0.0f;

    }
}
