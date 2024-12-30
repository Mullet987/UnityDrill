using UnityEngine;

public class RedRoomEnter : RoomEnterManager
{
    [SerializeField]
    GameObject RR_CameraRotationTrigger2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playTimeline(roomName);
            RR_CameraRotationTrigger2.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
