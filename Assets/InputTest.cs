using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    private void Update()
    {
        Debug.Log($"Left Command Key: {Keyboard.current.leftCommandKey.isPressed}");
    }
}