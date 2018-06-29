using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerNumber;

    public float x
    {
        get
        {
            return Input.GetAxis(string.Format("Player{0}X", playerNumber));
        }
    }

    public float rawX
    {
        get
        {
            return Input.GetAxisRaw(string.Format("Player{0}X", playerNumber));
        }
    }

    public float y
    {
        get
        {
            return Input.GetAxis(string.Format("Player{0}Y", playerNumber));
        }
    }

    public float rawY
    {
        get
        {
            return Input.GetAxisRaw(string.Format("Player{0}Y", playerNumber));
        }
    }
   
}