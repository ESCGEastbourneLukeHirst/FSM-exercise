using UnityEngine;

public class MovementSM : StateMachine
{
    public float speed = 4f;
    public float jumpForce = 14f;
    public float timer = 1;
    public Animator anim;

    public Rigidbody2D rigidbody;
    public SpriteRenderer spriteRenderer;

    [HideInInspector]
    public Idle idleState;
    [HideInInspector]
    public Moving movingState;
    [HideInInspector]
    public Jumping jumpingState;
    [HideInInspector]
    public Attacking attackState;
    [HideInInspector]
    public Die deadState;

    private void Awake()
    {
        idleState = new Idle(this);
        movingState = new Moving(this);
        jumpingState = new Jumping(this);
        attackState = new Attacking(this);
        deadState = new Die(this);
    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }
}
