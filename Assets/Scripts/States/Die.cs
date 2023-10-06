using UnityEngine;

public class Die : BaseState
{
    private MovementSM sm;

    public Die(MovementSM stateMachine) : base("Dead", stateMachine)
    {
        sm = (MovementSM)this.stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.spriteRenderer.color = Color.magenta;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (Input.GetKeyDown(KeyCode.M) == false)
        {
            sm.timer -= Time.deltaTime;
            Debug.Log("DEAD!");
            if (sm.timer <= 0)
            {
                stateMachine.ChangeState(sm.idleState);
                sm.timer = 0;
            }
        }
    }
}
