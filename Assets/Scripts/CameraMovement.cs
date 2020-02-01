using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float mouseInfluenceAmount = 1f;
    //The adjusted mouse position from the center of the screen
    private Vector3 mouseAdjust;
    //The vector to lerp to
    private Vector3 mouseDirection;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        //Reference mouse position, adjusted for the player being in the center of the screen
        mouseAdjust = new Vector3(Input.mousePosition.x - (Screen.width / 2), Input.mousePosition.y - (Screen.height / 2), player.transform.position.z);
        //Get the direction for camera offset
        mouseDirection = player.transform.position - mouseAdjust;
        mouseDirection = mouseDirection.normalized;
        mouseDirection *= mouseInfluenceAmount;
        //Lerp smoothly to new player position, informed by mouse offset
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x - mouseDirection.x, player.transform.position.y - mouseDirection.y, transform.position.z), 0.25f);
    }
}
