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

    #region Articy ���� ����
    public void OnBranchesUpdated(IList<Branch> aBranches)
    {
        // Branch �ʱ�ȭ
        ClearAllBranches();
        bool dialogueIsFinished = true;

        //branch.Target(������ �� ����� �ǹ���)�� DialogueFragment���� Ȯ���ϰ� ������ ����.
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
                // branchLayoutPanel�� branchButton�� �ڽ����μ� ������
                GameObject btn = Instantiate(branchButton, branchLayoutPanel);
                // Let the BranchChoice component fill the button content
                btn.GetComponent<BranchManager>().AssignBranch(flowPlayer, branch);
            }
        }
        else
        {
            // ���̾�αװ� �������� branchLayoutPanel�� closeButton�� �ڽ����μ� ������
            GameObject btn = Instantiate(closeButton, branchLayoutPanel);
            // Clicking this button will close the Dialogue UI
            var btnComp = btn.GetComponent<Button>();
            btnComp.onClick.AddListener(CloseDialogueBox);
        }
    }

    public void OnFlowPlayerPaused(IFlowObject aObject)
    {
        // If the object has a "Speaker" property try to fetch the speaker
        // ��ü�� "Speaker" �Ӽ��� �ִٸ� ����Ŀ�� ��������.
        var objectWithSpeaker = aObject as IObjectWithSpeaker;
        var speakerEntity = objectWithSpeaker.Speaker as Entity;

        //�ؽ�Ʈ ��������
        if (aObject is IObjectWithLocalizableText objWithLocalizableText)
        {
            textLabel.text += "\n";
            textLabel.text += speakerEntity.DisplayName + " - ";
            textLabel.text += "\n";
            textLabel.text += objWithLocalizableText.Text;
            textLabel.text += "\n";
            Canvas.ForceUpdateCanvases(); // ��� ���̾ƿ� ������Ʈ
            ScrollToBottomPosition();    // ��ũ�� �� �Ʒ��� �̵�
        }
        else
        {
            textLabel.text = string.Empty;
        }

        //ȭ��(portrait) ��������
        ExtractCurrentPausePreviewImage(aObject);

    }
    #endregion

    #region ������ �����ϴ� �޼ҵ�

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
            scrollRect.verticalNormalizedPosition = 0f; // 0�� �� �Ʒ�, 1�� �� ��
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
