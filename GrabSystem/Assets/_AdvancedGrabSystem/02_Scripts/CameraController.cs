using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    [SerializeField] private Transform bodyTarget;
    [SerializeField] private float sensitivity = 1;

    private float x, y;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        x = (x + Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime * 100) % 360;
        y = Mathf.Clamp(y - Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * 100, -90, 90);

        cameraTarget.rotation = Quaternion.Euler(y, x, 0);
        bodyTarget.rotation = Quaternion.Euler(0, x, 0);
    }
}
