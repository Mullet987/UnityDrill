using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.Unity.Interfaces;

public class BranchManager : MonoBehaviour
{
    private ArticyFlowPlayer flowPlayer;
    private Branch branch;
    private Text branchText;

    // the method used when the button is clicked
    public void OnBranchSelected()
    {
        // by giving the processor the branch assigned to the button on creation, the processor knows where to continue the flow
        flowPlayer.Play(branch);
    }

    internal void AssignBranch(ArticyFlowPlayer aFlowPlayer, Branch aBranch)
    {
        GetComponentInChildren<Button>().onClick.AddListener(OnBranchSelected);
        branchText = GetComponentInChildren<Text>();

        branch = aBranch;
        flowPlayer = aFlowPlayer;

        var target = aBranch.Target;
        branchText.text = string.Empty;

        if (target is IDialogueFragment)
        {
            //������ ��: �����ϰԵ� �ؽ�Ʈ�� IObjectWithLocalizableMenuText�� �ƴϸ� ����� �� �Ǵµ�. Branch�� IObjectWithMenuText�����ε� �߸� �Ǵ���.
            if (target is IObjectWithMenuText objWithMenuText)
                branchText.text = objWithMenuText.MenuText;
            else if (target is IObjectWithLocalizableMenuText objWithLocalizableMenuText)
                branchText.text = objWithLocalizableMenuText.MenuText;

            //�귣ġ�� �ؽ�Ʈ�� ������ "ERROR"�� ��µȴ�. ���� Ȯ�ο�.
            if (branchText.text == "")
            {
                branchText.text = "ERROR";
            }
        }
    }
}
