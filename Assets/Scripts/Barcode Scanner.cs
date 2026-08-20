using UnityEngine;
using Vuforia;

public class BarcodeScanner : MonoBehaviour
{
    BarcodeBehaviour mBarCodeBehaviour;
    public static string urlLink;
    public GameObject canvas;
    
    void Start()
    {
        mBarCodeBehaviour = GetComponent<BarcodeBehaviour>();
    }

    
    void Update()
    {
        if(mBarCodeBehaviour != null && mBarCodeBehaviour.InstanceData != null)
        {
            urlLink = mBarCodeBehaviour.InstanceData.Text;
            Debug.Log(urlLink);
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }

    public void OnClick()
    {
        Debug.Log("Oprimí el boton");
        Debug.Log(urlLink);
        Application.OpenURL(urlLink);
        
    }
}
