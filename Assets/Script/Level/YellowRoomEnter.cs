using UnityEngine;

public class YellowRoomEnter : RoomEnterManager
{
    [SerializeField]
    GameObject RY_CameraRotationTrigger2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playTimeline(roomName);
            RY_CameraRotationTrigger2.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
