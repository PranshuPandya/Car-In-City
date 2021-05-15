using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public GameObject player;
    public controler movement;
    private float speed = 20.0f;
    private float turnspeed=35.0f;
    public float horizontalInput;
    public float vertiInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        //if(player.transform.position.x<8 && player.transform.position.x > -8)
        horizontalInput = Input.GetAxis("Horizontal");
        vertiInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed*-1*vertiInput);

        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
        if(player.transform.position.x > 8.5 || player.transform.position.x < -8.5)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
