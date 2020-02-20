using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class MoveBase : MonoBehaviour
{
    protected Vector3 position;
    protected CharacterController controller;
    
    public float jumpSpeed = 30f, rotationSpeed = 100;
    public float gravity = 9.81f;
    public float moveSpeed = 10f;
    
    protected int jumpCount;
    public int jumpCountMax = 2;

    public UnityEvent speedUpEvent, speedDownEvent;
}