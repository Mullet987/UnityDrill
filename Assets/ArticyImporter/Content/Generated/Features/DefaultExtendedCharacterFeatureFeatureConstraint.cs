//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Noname;
using Articy.Unity;
using Articy.Unity.Constraints;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Noname.Features
{
    
    
    public class DefaultExtendedCharacterFeatureFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private TextConstraint mMotivation;
        
        private TextConstraint mInnerConflict;
        
        private TextConstraint mSkills;
        
        private TextConstraint mFears;
        
        private TextConstraint mHabits;
        
        private TextConstraint mFurtherDetails;
        
        public TextConstraint Motivation
        {
            get
            {
                EnsureConstraints();
                return mMotivation;
            }
        }
        
        public TextConstraint InnerConflict
        {
            get
            {
                EnsureConstraints();
                return mInnerConflict;
            }
        }
        
        public TextConstraint Skills
        {
            get
            {
                EnsureConstraints();
                return mSkills;
            }
        }
        
        public TextConstraint Fears
        {
            get
            {
                EnsureConstraints();
                return mFears;
            }
        }
        
        public TextConstraint Habits
        {
            get
            {
                EnsureConstraints();
                return mHabits;
            }
        }
        
        public TextConstraint FurtherDetails
        {
            get
            {
                EnsureConstraints();
                return mFurtherDetails;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mMotivation = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
            mInnerConflict = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
            mSkills = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
            mFears = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
            mHabits = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
            mFurtherDetails = new Articy.Unity.Constraints.TextConstraint(2048, "", null, true, true);
        }
    }
}
