using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    private void Update()
    {
        Debug.Log($"Left Command Key (New System): {Keyboard.current.leftCommandKey.isPressed}");
        Debug.Log($"Left Command Key (Old Manager): {Input.GetKey(KeyCode.LeftCommand)}");
    }
}