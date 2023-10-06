using UnityEngine;

public class Attacking : BaseState
{
    private MovementSM sm;

    public Attacking(MovementSM stateMachine) : base("Attacking", stateMachine)
    {
        sm = (MovementSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.spriteRenderer.color = Color.blue;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (Input.GetKeyDown(KeyCode.V) == false)
        {
            sm.timer -= Time.deltaTime;
            Debug.Log("ATTACKING!");
            if (sm.timer <= 0)
            {
                stateMachine.ChangeState(sm.idleState);
                sm.timer = 0;
            }
        }
    }
}
