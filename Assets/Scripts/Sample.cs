using UnityEngine;
using UnityFinger;

public class Sample : MonoBehaviour
{
    void Start()
    {
        var manager = FingerManager.Instance;

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
}
