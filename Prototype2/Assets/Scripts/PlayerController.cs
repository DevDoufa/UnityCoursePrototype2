using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    public float speed;
    public float xRange;

    public GameObject foodPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Boundary
        if (transform.position.x < -xRange) //Left Boundary
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) //Right Boundary
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Horizontal Movement
        horizontalInput = Input.GetAxisRaw("Horizontal"); //Get the horizontal input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); //Move the character

        //Launch Food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
