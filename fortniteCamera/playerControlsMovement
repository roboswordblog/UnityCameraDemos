using UnityEngine;

public class PlayerControlMovements : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public float sensitivity = 2f;

    private Rigidbody rb;
    private float moveX;
    private float moveZ;

    private bool isGrounded = true;
    private float rotationY = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;

        rotationY += mouseX;

        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }

    void FixedUpdate()
    {
        Vector3 move = (transform.right * moveX + transform.forward * moveZ).normalized;
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
