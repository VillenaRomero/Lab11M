using UnityEngine;

public class crearobjeto : MonoBehaviour
{
    public GameObject prefabEnemy;

    public float timeTiCreate = 5f;
    private float currentTimetuCreate;

    public Transform spawner1;

    public float posX;
    public float posY;
    public float posZ;

    private void Update()
    {
        currentTimetuCreate += Time.deltaTime;

        if (currentTimetuCreate >= timeTiCreate)
        {
            CrearEnemigo();
            currentTimetuCreate = 0f;
        }
    }

    private void CrearEnemigo()
    {
        Vector3 posicion = new Vector3(posX, posY, posZ);
        Instantiate(prefabEnemy, posicion, Quaternion.identity);
    }
}
