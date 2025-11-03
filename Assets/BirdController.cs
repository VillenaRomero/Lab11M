using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Cambio de escena")]
    public string cambiodeescena;

    [Header("Fuerzas de impulso")]
    public float fuerzaImpulsoArriba = 10f;

    [Header("Rotación del pájaro")]
    public float velocidadRotacionMaxima = 45f;
    public float factorRotacionMomentum = 3f;

    private bool impulsoSolicitado;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            impulsoSolicitado = true;
        }
    }

    void FixedUpdate()
    {
        if (impulsoSolicitado)
        {
            rb.AddForce(Vector3.up * fuerzaImpulsoArriba, ForceMode.Impulse);
            impulsoSolicitado = false;
        }

        float rotacion = -rb.linearVelocity.y * factorRotacionMomentum;
        rotacion = Mathf.Clamp(rotacion, -velocidadRotacionMaxima, velocidadRotacionMaxima);
        transform.rotation = Quaternion.Euler(rotacion, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tuberia"))
        {
            rb.AddForce(new Vector3(-3f, 1.5f, 0), ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("puntaje"))
        {
            ScoreManager.SumarPunto();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("LimitesCamara"))
        {
            SceneManager.LoadScene(cambiodeescena);
        }
    }
}
