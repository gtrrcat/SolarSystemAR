using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Скорость вращения по осям")]
    public Vector3 rotationSpeed = new Vector3(0, 40, 10); 

    private void Update()
    {
        transform.Rotate(rotationSpeed  * Time.deltaTime);
    }
}
