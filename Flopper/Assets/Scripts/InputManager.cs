using System.Security.Cryptography;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    private InputSystem_Actions inputActions;

    public event Action<Vector2> OnMove;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        inputActions = new InputSystem_Actions();

        inputActions.Player.Move.performed += ctx => OnMove?.Invoke(ctx.ReadValue<Vector2>());
    }

    public void OnEnable()
    {
        inputActions.Enable();
    }

    public void OnDisable()
    {
        inputActions.Disable();
    }
}
