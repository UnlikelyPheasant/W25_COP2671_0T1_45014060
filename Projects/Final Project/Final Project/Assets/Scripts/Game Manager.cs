using UnityEngine;
using UnityEngine.InputSystem.XR;

public class GameManager : MonoBehaviour
{
    public GameObject startCamera;
    public GameObject pizzaCamera;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            startCamera.SetActive(false);
            pizzaCamera.SetActive(true);
        }
    }
}
