using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    
    public float moveSpeed = 30f,  gravity = 6f, jumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.z = moveSpeed*Input.GetAxis("Vertical");
        position.y -= gravity;

        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        controller.Move(position*Time.deltaTime);
    }
}