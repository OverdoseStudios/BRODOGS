using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float sprintMultiplier = 2f;
    public float rotationSpeed = 100f;
    
    private void Update()
    {
        // Handle rotation
        float rotationInput = 0f;
        if (Input.GetKey(KeyCode.Q)) rotationInput -= 1f;
        if (Input.GetKey(KeyCode.E)) rotationInput += 1f;
        
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.eulerAngles += new Vector3(0f, rotationAmount, 0f);

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
