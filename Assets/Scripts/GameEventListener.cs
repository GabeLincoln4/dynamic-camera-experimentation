using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class GameEventListener : MonoBehaviour 
{
    public GameEvent _gameEvent;
    public UnityEvent _response;

    private void OnEnable ()
    { _gameEvent.RegisterListener(this); }

    private void OnDisable ()
    { _gameEvent.UnRegisterListener(this); }

    public void OnEventRaised ()
    { _response.Invoke(); }
}