using UnityEngine;
using UnityFinger;

public class Sample : MonoBehaviour
{
    FingerObserverSupervisor supervisor;
    FingerEventManager manager;

    void Start()
    {
        var input = new EditorInput();
        supervisor = new FingerObserverSupervisor(input);
        manager = new FingerEventManager(supervisor);

        manager.AddOnScreenListener(position => Debug.Log(position));

        manager.AddOnDragStartListener(dragInfo => {
            Debug.LogFormat("DragStart: {0}", dragInfo.position);
        });

        manager.AddOnDragListener(dragInfo => {
            Debug.LogFormat("Drag: {0}", dragInfo.position);
        });

        manager.AddOnDragEndListener(dragInfo => {
            Debug.LogFormat("DragEnd: {0}", dragInfo.position);
        });
    }

    void Update()
    {
        supervisor.Update();
    }
}
