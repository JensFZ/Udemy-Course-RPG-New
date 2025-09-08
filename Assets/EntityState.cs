using UnityEngine;

public abstract class EntityState
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string animBoolName;

    public EntityState(Player player, StateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        player.animator.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        Debug.Log("I run update of " + animBoolName);
    }

    public virtual void Exit()
    {
        player.animator.SetBool(animBoolName, false);
    }
}
