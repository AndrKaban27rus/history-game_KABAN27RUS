using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found!");
        }
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position - transform.up * 0.5f, groundCheckDistance, groundLayer); //Проверяем на земле ли игрок

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position - transform.up * 0.5f, groundCheckDistance);
    }
}