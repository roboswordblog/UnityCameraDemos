using UnityEngine;

public class RobloxPlayer : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] float jumpForce = 7f;
    private Rigidbody rb;

    private float moveX;
    private float moveZ;
    private bool isGrounded = true;
    public float sensitivity = 2F;
    private float rotationX;
    private float rotationY;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            rotationY += mouseX * sensitivity;
            rotationX -= mouseY * sensitivity;

            transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);
        }
    }

    void FixedUpdate()
    {
        Vector3 move = (transform.right * moveX + transform.forward * moveZ).normalized;

        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
        
    }
}
