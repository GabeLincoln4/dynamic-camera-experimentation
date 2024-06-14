using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputGenerator : MonoBehaviour
{
    [SerializeField]
    private GameEvent _spaceInput;

    private void Update ()
    {
        if (Input.GetButtonDown("Submit"))
        { _spaceInput.Raise(); }
    }

    public void OutputResponse () 
    { Debug.Log("Space Input has been activated"); }
}
