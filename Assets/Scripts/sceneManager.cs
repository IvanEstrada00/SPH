using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void CargarEscena(int numeroEscena)
    {
        SceneManager.LoadScene(numeroEscena);
    }

    /*
    public void CargarEscena0()
    {
        SceneManager.LoadScene(0);
    }

    public void CargarEscena1()
    {
        SceneManager.LoadScene(1);
    }

    public void CargarEscena2()
    {
        SceneManager.LoadScene(2);
    }

    public void CargarEscena3()
    {
        SceneManager.LoadScene(3);
    }

    public void CargarEscena4()
    {
        SceneManager.LoadScene(4);
    }

    */
    public void RecargarEscenaActual()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}