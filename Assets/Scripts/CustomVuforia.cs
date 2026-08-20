using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CustomVuforia : MonoBehaviour
{
    public GameObject ball;
    public Camera cameraOriginal;

    public float force = 0.5f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 position = cameraOriginal.transform.position;
            GameObject newObject = Instantiate(ball, position, Quaternion.identity);
            newObject.GetComponent<Rigidbody>().AddForce(cameraOriginal.transform.forward * force, ForceMode.Impulse
        );
        }
    }
}
