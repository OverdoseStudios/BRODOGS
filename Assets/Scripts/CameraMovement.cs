using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float sprintMultiplier = 2f;
    
    private void Update()
    {
        // Get input axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // Calculate movement direction
        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        
        // Apply speed and multiplier
        float currentSpeed = movementSpeed * (Input.GetKey(KeyCode.LeftShift) ? sprintMultiplier : 1f);
        Vector3 translation = transform.TransformDirection(movement) * currentSpeed * Time.deltaTime;
        
        // Apply movement
        transform.position += translation;
    }
}
