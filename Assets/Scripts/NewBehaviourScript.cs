using UnityEngine;

public class CollisionSelector : MonoBehaviour
{
    [Header("Objetos de Colisión")]
    public GameObject objeto1;
    public GameObject objeto2;

    [Header("Referencias")]
    public SPH sphScript;

    private bool objeto1Activo = true;

    void Start()
    {
        // Establecer el objeto1 como activo al inicio
        ActualizarObjetoActivo();
    }

    public void SeleccionarObjeto1()
    {
        objeto1Activo = true;
        ActualizarObjetoActivo();
    }

    public void SeleccionarObjeto2()
    {
        objeto1Activo = false;
        ActualizarObjetoActivo();
    }

    private void ActualizarObjetoActivo()
    {
        if (sphScript == null) return;

        if (objeto1Activo)
        {
            // Activar objeto1
            if (objeto1 != null)
            {
                sphScript.collisionSphere = objeto1.transform;
                ActivarMovimiento(objeto1, true);
            }

            // Desactivar objeto2
            if (objeto2 != null)
            {
                ActivarMovimiento(objeto2, false);
            }

            Debug.Log("Objeto 1 seleccionado y movimiento activado");
        }
        else
        {
            // Activar objeto2
            if (objeto2 != null)
            {
                sphScript.collisionSphere = objeto2.transform;
                ActivarMovimiento(objeto2, true);
            }

            // Desactivar objeto1
            if (objeto1 != null)
            {
                ActivarMovimiento(objeto1, false);
            }

            Debug.Log("Objeto 2 seleccionado y movimiento activado");
        }
    }

    private void ActivarMovimiento(GameObject obj, bool activar)
    {
        // Buscar el script SimpleMovement en el objeto
        SimpleMovement movimiento = obj.GetComponent<SimpleMovement>();

        if (movimiento != null)
        {
            movimiento.enabled = activar;
        }
    }

    // Alternar entre los dos objetos
    public void AlternarObjeto()
    {
        objeto1Activo = !objeto1Activo;
        ActualizarObjetoActivo();
    }
}