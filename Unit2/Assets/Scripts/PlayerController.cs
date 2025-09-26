using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This is a player controller
    // need a variable for user input
    public float horizontalInput;

    public float speed = 10.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
    }
}
