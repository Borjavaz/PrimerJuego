using UnityEngine;

//movimiento de los cubos
public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
    }
 
}