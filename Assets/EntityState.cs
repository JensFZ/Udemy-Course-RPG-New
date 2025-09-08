using Unity.VisualScripting;
using UnityEngine;

public abstract class EntityState
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string stateName;


    public EntityState(Player player, StateMachine stateMachine, string stateName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        // every time we enter a state
        Debug.Log("Entering state: " + stateName);
    }

    public virtual void Exit()
    {
        // every time we exit a state
        Debug.Log("Exiting state: " + stateName);
    }

    public virtual void Update()
    {
        // every frame we are in a state
        Debug.Log("Updating state: " + stateName);
    }

}
