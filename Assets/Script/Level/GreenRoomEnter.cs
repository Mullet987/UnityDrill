using UnityEngine;

public class GreenRoomEnter : RoomEnterManager
{
    [SerializeField]
    GameObject RG_CameraRotationTrigger2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playTimeline(roomName);
            RG_CameraRotationTrigger2.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
