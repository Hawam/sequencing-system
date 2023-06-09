
using UnityEngine;

// The subclass of Action that smoothly moves a camera between two points 
public class CameraAction : Action
{
    // The game object with the Camera component 
    public GameObject cameraObject;

    // The start position of the camera movement 
    public Vector3 startPosition;

    // The end position of the camera movement 
    public Vector3 endPosition;

    // The start rotation of the camera movement 
    public Quaternion startRotation;

    // The end rotation of the camera movement 
    public Quaternion endRotation;

    // The duration of the camera movement in seconds 
    public float duration;

    // The timer for tracking the progress of the camera movement 
    private float timer;

    // The Camera component reference 
    private Camera camera;

    // The override method that performs the action 
    public override void Execute()
    {
        // Get the Camera component from the game object 
        camera = cameraObject.GetComponent<Camera>();

        // Set the timer to zero 
        timer = 0f;
    }

    // The override method that returns true if the action is finished 
    public override bool IsDone()
    {
        // Check if the timer has reached or exceeded the duration 
        if (timer >= duration)
        {
            return true;
        }
        else
        {
            // Increment the timer by delta time 
            timer += Time.deltaTime;

            // Calculate the interpolation factor between zero and one 
            float t = timer / duration;

            // Lerp the position and rotation of the camera between the start and end points 
            camera.transform.position = Vector3.Lerp(startPosition, endPosition, t);
            camera.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);

            return false;
        }
    }
}
