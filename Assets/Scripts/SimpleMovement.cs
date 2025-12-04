using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationOffset = 45f; // Ángulo de rotación del movimiento

    void Update()
    {
        // Obtener input del teclado
        float moveX = Input.GetAxis("Horizontal"); // A/D o Flechas Izq/Der
        float moveZ = Input.GetAxis("Vertical");   // W/S o Flechas Arriba/Abajo

        // Crear vector de movimiento (solo en X y Z)
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        // Rotar el vector de movimiento por el ángulo deseado
        movement = Quaternion.Euler(0, rotationOffset, 0) * movement;

        // Mover el objeto
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
