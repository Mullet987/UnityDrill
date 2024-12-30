using UnityEngine;

public class BlueRoomEnter : RoomEnterManager
{
    [SerializeField]
    GameObject Room_CameraRotationTrigger1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playTimeline(roomName);
            Room_CameraRotationTrigger1.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
