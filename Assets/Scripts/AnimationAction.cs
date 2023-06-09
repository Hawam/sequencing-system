using UnityEngine;

// The subclass of Action that runs an animation in the Unity Animator
public class AnimationAction : Action
{
    // The game object with the Animator component
    public GameObject animatorObject;

    // The name of the animation to play
    public string animationName;

    // The flag to indicate if waiting for the animation is enabled
    public bool wait;

    // The Animator component reference
    private Animator animator;

    // The override method that performs the action
    public override void Execute()
    {
        // Get the Animator component from the game object
        animator = animatorObject.GetComponent<Animator>();

        // Play the animation by name
        animator.Play(animationName);
    }

    // The override method that returns true if the action is finished
    public override bool IsDone()
    {
        // Return true if waiting is disabled or if waiting is enabled and the animation is done
        return !wait || (wait && !animator.GetCurrentAnimatorStateInfo(0).IsName(animationName));
    }
}
