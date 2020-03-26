using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MoveBase
{
    public GameAction speedUpAction, slowDownAction;
    
    public float walkSpeed = 30f;
    public float sprintSpeed = 60f;

    private bool canRun = true;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        moveSpeed = walkSpeed;
        speedUpAction.action += SpeedIncrease;
        slowDownAction.action += SpeedDecrease;
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
            if (position  != Vector3.zero)
            {
                controller.transform.forward = position;
            }
        }
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        controller.Move(position*Time.deltaTime);
    }

    private void SpeedIncrease()
    {
        if (!canRun) return;
        moveSpeed = sprintSpeed;
        speedUpEvent.Invoke();
        canRun = false;
        StartCoroutine(nameof(WaitAndCheck));
    }

    private void SpeedDecrease()
    {
        moveSpeed = walkSpeed;
        speedDownEvent.Invoke();
    }

    private IEnumerator WaitAndCheck()
    {
        yield return new WaitForSeconds(5);
        canRun = true;
        Debug.Log("Can you run now?");
    }
}