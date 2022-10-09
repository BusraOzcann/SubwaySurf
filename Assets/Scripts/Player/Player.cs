using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player/PlayerSettings", order = 1)]
public class Player : ScriptableObject
{
    public GameObject Character;
    public PlayerState state;
    public float speed = 3f;
    public float swipeSpeed = 15f;
    public float moveXPos = 2f;
    public float jumpSpeed;
}
