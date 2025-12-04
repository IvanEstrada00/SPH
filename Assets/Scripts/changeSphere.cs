using UnityEngine;
using UnityEngine.UI;

public class ChangeCollisionObject : MonoBehaviour
{
    [Header("Referencias")]
    public SPH sphScript; // Arrastra aquí el objeto que tiene el script SPH
    public Transform esfera1;
    public Transform esfera2;
    public Button botonCambiar; // Arrastra aquí tu botón UI

    private bool usandoEsfera1 = true;

    void Start()
    {
        // Asignar la función al botón
        if (botonCambiar != null)
        {
            botonCambiar.onClick.AddListener(CambiarEsfera);
        }

        // Establecer la esfera inicial
        if (sphScript != null && esfera1 != null)
        {
            sphScript.collisionSphere = esfera1;
        }
    }

    public void CambiarEsfera()
    {
        if (sphScript == null) return;

        // Alternar entre las dos esferas
        if (usandoEsfera1)
        {
            sphScript.collisionSphere = esfera2;
            Debug.Log("Cambiado a Esfera 2");
        }
        else
        {
            sphScript.collisionSphere = esfera1;
            Debug.Log("Cambiado a Esfera 1");
        }

        usandoEsfera1 = !usandoEsfera1;
    }

    // OPCIONAL: Si quieres usar una tecla en lugar de botón UI
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarEsfera();
        }
    }
}