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
            //의하한 점: 기이하게도 텍스트는 IObjectWithLocalizableMenuText가 아니면 출력이 안 되는데. Branch는 IObjectWithMenuText만으로도 잘만 되더라.
            if (target is IObjectWithMenuText objWithMenuText)
                branchText.text = objWithMenuText.MenuText;
            else if (target is IObjectWithLocalizableMenuText objWithLocalizableMenuText)
                branchText.text = objWithLocalizableMenuText.MenuText;

            //브랜치에 텍스트가 없으면 "ERROR"가 출력된다. 에러 확인용.
            if (branchText.text == "")
            {
                branchText.text = "ERROR";
            }
        }
    }
}
