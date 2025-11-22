using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public void OnEnable()
    {
        InputManager.Instance.OnMove += movePlayer;
    }
    public void Update()
    {

    }

    private void movePlayer(Vector2 input)
    {
        Transform transform = this.transform;

        transform.Translate(input.x, input.y, 0);

    }
}
