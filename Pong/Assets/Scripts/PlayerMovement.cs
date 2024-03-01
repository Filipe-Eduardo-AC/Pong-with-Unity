using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField]
    public KeyCode KeyCodeUp;
    [SerializeField]
    public KeyCode KeyCodeDown;

    private void Update()
    {
        if (Input.GetKey(KeyCodeUp))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCodeDown))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }
    }

    public void Reset()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, 0);
    }
}
