using UnityEngine;

public class RelativeMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform cameraTransform; // ������ �� Transform ������


    void Update()
    {
        //��������� ����������� �������� �� ������
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // ������� ������������ ������������ �� ����������� ������
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        // �������� ������� ������
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        // ��������� ������ ��������
        Vector3 movement = (forward * verticalInput + right * horizontalInput).normalized * speed * Time.deltaTime;


        // ���������� ������
        transform.position += movement;

    }
}