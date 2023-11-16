using UnityEngine;
using UnityEngine.Events;


public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent StartEvent, AwakeEvent, DisableEvent;

    private void Awake()
    {
        AwakeEvent.Invoke();
    }

    // Start is called before the first frame update
    private void Start()
    {
        StartEvent.Invoke();
    }

    private void OnDisable()
    {
        DisableEvent.Invoke();
    }
}