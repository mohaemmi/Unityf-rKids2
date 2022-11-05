using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController Figur;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Figur = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Figur.Move(Vector3.left * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Figur.Move(Vector3.right * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Figur.Move(Vector3.up * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Figur.Move(Vector3.down * Time.deltaTime * Speed);
        }
    }
}
