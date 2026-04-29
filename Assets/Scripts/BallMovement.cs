using UnityEngine;

using GG.Infrastructure.Utils.Swipe;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private SwipeListener swipeListener;
    private Vector3 moveDirection;

    private void Start()
    {
        swipeListener.OnSwipe.AddListener(swipeListener =>
        {
            switch (swipeListener)
            {
            case "Right":
                moveDirection = Vector3.right;
                break;
            case "Left":
                moveDirection = Vector3.left;
                break;
            case "Up":
                moveDirection = Vector3.forward;
                break;
            case "Down":
                moveDirection = Vector3.back;
                break;
            }
            Debug.Log(swipeListener);
        });
    }
}