using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 10f;  // 기본 이동 속도
    public float rotationSpeed = 100f;  // 회전 속도

    void Update()
    {
        // 전진/후진 (W, S 키 또는 조이스틱)
        float moveInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, moveInput);

        // 좌우 회전 (A, D 키 또는 마우스)
        float rotationInput = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationInput, 0);

        // 상하 회전 (마우스 Y축, 선택 사항)
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        transform.Rotate(-mouseY, 0, 0);
    }
}