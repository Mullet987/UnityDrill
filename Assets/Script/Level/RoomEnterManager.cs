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
            //RoomBlue로 부터 각 방으로 진입
            case "RBRR":
                roomEnterTimelines.playableDirectorRBRR.Play();
                break;
            case "RBRY":
                roomEnterTimelines.playableDirectorRBRY.Play();
                break;
            case "RBRG":
                roomEnterTimelines.playableDirectorRBRG.Play();
                break;

            //각 방에서부터 RoomBlue로 진입
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
