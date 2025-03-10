using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 10f; // Скорость вращения

    public float xRotation = 0f; // Текущее вращение по оси X
    public float yRotation = 0f; // Текущее вращение по оси Y

    void Update()
    {
        // Получаем входные данные от мыши (или другого контроллера)
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        // Изменяем углы вращения
        xRotation += mouseX;
        yRotation -= mouseY; // Обратите внимание на знак минус для оси Y

        // Ограничиваем вертикальное вращение (опционально)
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        // Создаем кватэрнион из углов Эйлера
        Quaternion rotation = Quaternion.Euler(yRotation, xRotation, 0f);

        // Устанавливаем новое вращение камеры
        transform.rotation = rotation;
    }
}