using UnityEngine;

// The subclass of Action that enables or disables a game object
public class GameObjectAction : Action
{
    // The game object to enable or disable
    public GameObject gameObject;

    // The flag to indicate if enabling or disabling the game object
    public bool enable;

    // The override method that performs the action
    public override void Execute()
    {
        // Set the active state of the game object to the enable flag value
        gameObject.SetActive(enable);
    }

    // The override method that returns true if the action is finished (always true for this action)
}
