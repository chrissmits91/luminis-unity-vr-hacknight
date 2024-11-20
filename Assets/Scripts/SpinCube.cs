using System;
using UnityEngine;

/// <summary>
/// https://docs.unity3d.com/2022.3/Documentation/Manual/ExecutionOrder.html
/// </summary>
public class SpinCube : MonoBehaviour
{
    [SerializeField] private float bobSpeed = 1f;
    [SerializeField] private float bobDistance = .5f;
    [SerializeField] private float rotationSpeed = 1f;

    private Vector3 _initialPosition;
    
    private void Awake()
    {
        // A place to grab references to other components on this GameObject.
        // Use GetComponent<T>() and store the reference in a private class variable
        // private T _reference
    }

    private void Start()
    {
        // This is the place to grab other GameObject's references and initialize them with values
        // Also a place to store initial values to use within this script, the default localScale or position for example

        _initialPosition = transform.position;
    }

    private void Update()
    {
        // This method is executed every frame
        // Time.deltaTime is the time between the previous frame and current frame in seconds
        
        // Rotate the cube
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        
        // Move cube up and down
        var moveBy = Vector3.up * bobDistance * Mathf.Sin(Time.time * bobSpeed);
        transform.position = _initialPosition + moveBy;
    }

    private void OnDestroy()
    {
        // A place to clean up references and unsubscribe from events
    }
}