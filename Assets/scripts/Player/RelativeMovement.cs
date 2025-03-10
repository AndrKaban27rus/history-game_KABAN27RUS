using UnityEngine;

public class RelativeMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform cameraTransform; // Ссылка на Transform камеры


    void Update()
    {
        //Получение направления движения от камеры
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Убираем вертикальную составляющую от направления камеры
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        // Получаем входные данные
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        // Вычисляем вектор движения
        Vector3 movement = (forward * verticalInput + right * horizontalInput).normalized * speed * Time.deltaTime;


        // Перемещаем объект
        transform.position += movement;

    }
}