using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 10f; // �������� ��������

    public float xRotation = 0f; // ������� �������� �� ��� X
    public float yRotation = 0f; // ������� �������� �� ��� Y

    void Update()
    {
        // �������� ������� ������ �� ���� (��� ������� �����������)
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        // �������� ���� ��������
        xRotation += mouseX;
        yRotation -= mouseY; // �������� �������� �� ���� ����� ��� ��� Y

        // ������������ ������������ �������� (�����������)
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        // ������� ���������� �� ����� ������
        Quaternion rotation = Quaternion.Euler(yRotation, xRotation, 0f);

        // ������������� ����� �������� ������
        transform.rotation = rotation;
    }
}