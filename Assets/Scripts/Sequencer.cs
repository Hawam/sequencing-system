using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : SerializedMonoBehaviour
{
    // The list of actions to execute in the sequence
    public List<Action> actions;

    // The current index of the action being executed
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        // Execute the first action and increment the index
        actions[index].Execute();
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the current action is done
        if (actions[index - 1].IsDone())
        {
            // Check if there are more actions in the list
            if (index < actions.Count)
            {
                // Execute the next action and increment the index
                actions[index].Execute();
                index++;
            }
            else
            {
                // Stop the sequence
                Debug.Log("Sequence finished");
            }
        }
    }
}
