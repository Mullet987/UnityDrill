using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.Noname;
using TMPro;

public class ArticyflowPlayerManager : MonoBehaviour, IArticyFlowPlayerCallbacks
{
    #region variable

    public bool DialogueActive { get; set; }
    private ArticyFlowPlayer flowPlayer;

    [Header("UI")]
    [SerializeField]
    ScrollRect scrollRect;
    [SerializeField]
    GameObject dialogueWidget;
    [SerializeField]
    GameObject closeButton;
    [SerializeField]
    GameObject branchButton;
    [SerializeField]
    RectTransform branchLayoutPanel;
    [SerializeField]
    Image previewImagePanel;
    [SerializeField]
    TextMeshProUGUI textLabel;

    #endregion

    void Start()
    {
        flowPlayer = GetComponent<ArticyFlowPlayer>();
        //InitTextbox();
    }

    #region Articy 동작 구문
    public void OnBranchesUpdated(IList<Branch> aBranches)
    {
        // Branch 초기화
        ClearAllBranches();
        bool dialogueIsFinished = true;

        //branch.Target(다음에 올 대상을 의미함)이 DialogueFragment인지 확인하고 변수에 대입.
        foreach (var branch in aBranches)
        {
            if (branch.Target is IDialogueFragment)
            {
                dialogueIsFinished = false;
            }
        }

        if (!dialogueIsFinished)
        {
            foreach (var branch in aBranches)
            {
                // branchLayoutPanel에 branchButton을 자식으로서 생성함
                GameObject btn = Instantiate(branchButton, branchLayoutPanel);
                // Let the BranchChoice component fill the button content
                btn.GetComponent<BranchManager>().AssignBranch(flowPlayer, branch);
            }
        }
        else
        {
            // 다이얼로그가 끝났으면 branchLayoutPanel에 closeButton을 자식으로서 생성함
            GameObject btn = Instantiate(closeButton, branchLayoutPanel);
            // Clicking this button will close the Dialogue UI
            var btnComp = btn.GetComponent<Button>();
            btnComp.onClick.AddListener(CloseDialogueBox);
        }
    }

    public void OnFlowPlayerPaused(IFlowObject aObject)
    {
        // If the object has a "Speaker" property try to fetch the speaker
        // 객체에 "Speaker" 속성이 있다면 스피커를 가져오라.
        var objectWithSpeaker = aObject as IObjectWithSpeaker;
        var speakerEntity = objectWithSpeaker.Speaker as Entity;

        //텍스트 가져오기
        if (aObject is IObjectWithLocalizableText objWithLocalizableText)
        {
            textLabel.text += "\n";
            textLabel.text += speakerEntity.DisplayName + " - ";
            textLabel.text += "\n";
            textLabel.text += objWithLocalizableText.Text;
            textLabel.text += "\n";
            Canvas.ForceUpdateCanvases(); // 즉시 레이아웃 업데이트
            ScrollToBottomPosition();    // 스크롤 맨 아래로 이동
        }
        else
        {
            textLabel.text = string.Empty;
        }

        //화상(portrait) 가져오기
        ExtractCurrentPausePreviewImage(aObject);

    }
    #endregion

    #region 동작을 보조하는 메소드

    public void StartDialogue(IArticyObject aObject)
    {
        InitTextbox();

        DialogueActive = true;
        dialogueWidget.SetActive(DialogueActive);
        flowPlayer.StartOn = aObject;
    }

    public void CloseDialogueBox()
    {
        DialogueActive = false;
        dialogueWidget.SetActive(DialogueActive);
        flowPlayer.FinishCurrentPausedObject();
    }

    private void ClearAllBranches()
    {
        foreach (Transform child in branchLayoutPanel)
            Destroy(child.gameObject);
    }

    private void InitTextbox()
    {
        textLabel.text = string.Empty;

        for (int i = 0; i < 8; ++i)
        {
            textLabel.text += "\n";
        }
    }

    private void ScrollToBottomPosition()
    {
        if (scrollRect != null)
        {
            scrollRect.verticalNormalizedPosition = 0f; // 0이 맨 아래, 1이 맨 위
        }
    }

    private void ExtractCurrentPausePreviewImage(IFlowObject aObject)
    {
        IAsset articyAsset = null;
        previewImagePanel.sprite = null;
        var dlgSpeaker = aObject as IObjectWithSpeaker;

        if (dlgSpeaker != null)
        {
            ArticyObject speaker = dlgSpeaker.Speaker;
            if (speaker != null)
            {
                var speakerWithPreviewImage = speaker as IObjectWithPreviewImage;
                if (speakerWithPreviewImage != null)
                {
                    articyAsset = speakerWithPreviewImage.PreviewImage.Asset;
                }

                if (articyAsset == null)
                {
                    var objectWithPreviewImage = aObject as IObjectWithPreviewImage;
                    if (objectWithPreviewImage != null)
                    {
                        articyAsset = objectWithPreviewImage.PreviewImage.Asset;
                    }
                }
                if (articyAsset != null)
                {
                    previewImagePanel.sprite = articyAsset.LoadAssetAsSprite();
                }
            }
        }
        if (articyAsset == null)
        {
            var objectWithPreviewImage = aObject as IObjectWithPreviewImage;
        }
    }

    #endregion
}
