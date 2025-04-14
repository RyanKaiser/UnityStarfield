using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        float moveInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, moveInput);

        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float keyHorizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float totalRotation = mouseX + keyHorizontal;
        transform.Rotate(0, totalRotation, 0);

        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        transform.Rotate(-mouseY, 0, 0);
    }
}