using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    private void Update()
    {
        Debug.Log($"Left Command Key (New): {Keyboard.current.leftCommandKey.isPressed}");
        Debug.Log($"Left Command Key (Old): {Input.GetKey(KeyCode.LeftCommand)}");
    }
}