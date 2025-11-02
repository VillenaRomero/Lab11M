using UnityEngine;

public class crearobjeto : MonoBehaviour
{
    public GameObject prefabEnemy;
    private Transform comTransform;

    public float timeTiCreate = 5;
    public float currentTimetuCreate;


    public Transform spawner1;


    private void Update()
    {
        currentTimetuCreate = currentTimetuCreate + Time.deltaTime;
        if (currentTimetuCreate >= timeTiCreate)
        {
            CrearEnemigo();

            currentTimetuCreate = 0;
        }
       
    }
    private void CrearEnemigo()
    {

        GameObject nuevo = Instantiate(prefabEnemy, spawner1.position, spawner1.rotation);

    }
}
