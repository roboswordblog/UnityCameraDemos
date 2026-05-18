using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 2f;
    private float rotationX = 0f;

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, 0f, 40f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}
