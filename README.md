# sequencing system
 
A sequencing system refers to a mechanism or framework that allows for the orchestration and control of a series of actions or events in a specific order. It provides a way to define and manage the flow of actions or events.
 
Create a sequencing system that allows for the dynamic control of objects, audio playback, and material changes within a small interactive scene. This task will test your ability to design and implement a flexible system, utilizing scripting and Unity's features effectively.
 
The sequencing system should support the following actions:
- Run animations in the Unity Animator with the ability to wait for the animation to finish before proceeding to the next action.
- Play audio clips with the ability to wait for the audio to finish before proceeding to the next action.
- Waiting before an audio or animation is finished should be optional. (It can be disabled for the given action)
- Enable or disable game objects.
- Smoothly move cameras cinematically from point A to point B.

# Requriment

unity 2021.3.18f1 or later.

[Odin Inspector and Serializer](https://assetstore.unity.com/packages/tools/utilities/odin-inspector-and-serializer-89041)

# Example

The final result should look like this
![alt](/Screenshot.png)

# classDiagram

```mermaid
classDiagram
    Sequencer --|> SerializedMonoBehaviour
    Sequencer : +List<Action> actions
    Sequencer : +void Start()
    Sequencer : +void Update()
    Action <|-- AnimationAction
    Action <|-- AudioAction
    Action <|-- GameObjectAction
    Action <|-- CameraAction
    Action : #virtual void Execute()
    Action : #virtual bool IsDone()
    AnimationAction : +GameObject animatorObject
    AnimationAction : +string animationName
    AnimationAction : +bool wait
    AnimationAction : #override void Execute()
    AnimationAction : #override bool IsDone()
    AudioAction : +GameObject audioSourceObject
    AudioAction : +AudioClip audioClip
    AudioAction : +bool wait
    AudioAction : #override void Execute()
    AudioAction : #override bool IsDone()
    GameObjectAction : +GameObject gameObject
    GameObjectAction : +bool enable
    GameObjectAction : #override void Execute()
    GameObjectAction : #override bool IsDone()
    CameraAction : +GameObject cameraObject
    CameraAction : +Vector3 startPosition
    CameraAction : +Vector3 endPosition
    CameraAction : +Quaternion startRotation
    CameraAction : +Quaternion endRotation
    CameraAction : +float duration
    CameraAction : -float timer
    CameraAction : #override void Execute()
    CameraAction : #override bool IsDone()

```
