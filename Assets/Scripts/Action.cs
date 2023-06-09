using UnityEngine;

// The abstract class that represents a single action in the sequence
public abstract class Action
{
    // The virtual method that performs the action
    public virtual void Execute()
    {
        // Do nothing by default
    }

    // The virtual method that returns true if the action is finished
    public virtual bool IsDone()
    {
        // Return true by default
        return true;
    }
}
