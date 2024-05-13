using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : TopDownController
{
    Camera camera;


    private void Awake()
    {
            camera = Camera.main;

    }

    public void OnMove(InputValue value)
    {
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 wordpos = camera.ScreenToWorldPoint(newAim);
        newAim = (wordpos-(Vector2)transform.position).normalized;
        CallLookEvent(newAim);
    }

}
