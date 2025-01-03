//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using UnityEngine;


namespace Articy.Noname.GlobalVariables
{
    
    
    [Serializable()]
    [CreateAssetMenu(fileName="ArticyGlobalVariables", menuName="Create GlobalVariables", order=620)]
    public class ArticyGlobalVariables : BaseGlobalVariables
    {
        
        [SerializeField()]
        [HideInInspector()]
        private NPCs mNPCs = new NPCs();
        
        #region Initialize static VariableName set
        static ArticyGlobalVariables()
        {
            variableNames.Add("NPCs.BLUE_FirstMeet");
            variableNames.Add("NPCs.Green_FirstMeet");
            variableNames.Add("NPCs.Gamestate_End");
            variableNames.Add("NPCs.RED_FirstMeet");
            variableNames.Add("NPCs.YELLOW_Angry");
            variableNames.Add("NPCs.YELLOW_FirstMeet");
            variableNames.Add("NPCs.FIND_KNIFE");
            variableNames.Add("NPCs.BLUE_Angry");
        }
        #endregion
        
        public NPCs NPCs
        {
            get
            {
                return mNPCs;
            }
        }
        
        public static ArticyGlobalVariables Default
        {
            get
            {
                return ((ArticyGlobalVariables)(Articy.Unity.ArticyDatabase.DefaultGlobalVariables));
            }
        }
        
        public override void Init()
        {
            NPCs.RegisterVariables(this);
        }
        
        public static ArticyGlobalVariables CreateGlobalVariablesClone()
        {
            return Articy.Unity.BaseGlobalVariables.CreateGlobalVariablesClone<ArticyGlobalVariables>();
        }
    }
}
