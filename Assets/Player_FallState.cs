using UnityEngine;

public class Player_FallState : EntityState
{

    public Player_FallState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    override public void Enter()
    {
        base.Enter();
    }

    override public void Update()
    {
        base.Update();
    }
}
