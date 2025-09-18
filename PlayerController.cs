using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float pushUp;
    public float gravityModifier = 2.0f;
    public bool isOnGround = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * pushUp, ForceMode.Impulse);
            isOnGround = false;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
    
}
