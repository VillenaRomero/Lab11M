using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiodeescena : MonoBehaviour
{
    public void Cambiodeescena(string escenacambio) {
        SceneManager.LoadScene(escenacambio);
    }
}
