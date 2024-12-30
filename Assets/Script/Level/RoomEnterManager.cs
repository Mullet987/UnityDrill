using UnityEngine;
using UnityEngine.Playables;

public class RoomEnterManager : MonoBehaviour
{
    public string roomName;

    [SerializeField]
    RoomEnterTimelines roomEnterTimelines;

    public void playTimeline(string roomName)
    {
        switch (roomName)
        {
            //RoomBlue�� ���� �� ������ ����
            case "RBRR":
                roomEnterTimelines.playableDirectorRBRR.Play();
                break;
            case "RBRY":
                roomEnterTimelines.playableDirectorRBRY.Play();
                break;
            case "RBRG":
                roomEnterTimelines.playableDirectorRBRG.Play();
                break;

            //�� �濡������ RoomBlue�� ����
            case "RRRB":
                roomEnterTimelines.playableDirectorRRRB.Play();
                break;
            case "RYRB":
                roomEnterTimelines.playableDirectorRYRB.Play();
                break;
            case "RGRB":
                roomEnterTimelines.playableDirectorRGRB.Play();
                break;
        }
    }
}
