using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float jumpForce = 10f;

    [SerializeField] CameraController cam;
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Color colorCyan;
    [SerializeField] Color colorYellow;
    [SerializeField] Color colorPink;
    [SerializeField] Color colorMajenta;
    public string currentColor;

    private void Start()
    {
        SetRandomColor();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            playerRb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "colorChanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
        }
        if(collision.tag !=currentColor && collision.tag != "colorChanger" )
        {
            this.transform.position = new Vector3(0, -12, 0);
            cam.ResetCamera();
            Debug.Log("GAME OVER!!");
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "pink";
                sr.color = colorPink;
                break;
            case 3:
                currentColor = "majenta";
                sr.color = colorMajenta;
                break;
        }
    }
}
