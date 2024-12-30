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
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Noname
{
    
    
    public class LocationImage : ArticyObject, ILocationImage, IPropertyProvider, IObjectWithColor, IObjectWithDisplayName, IObjectWithPreviewImage, IObjectWithText, IObjectWithTransformation, IObjectWithVertices, IObjectWithExternalId, IObjectWithShortId, IObjectWithZIndex, IObjectWithSize
    {
        
        [SerializeField()]
        private ArticyValueArticyString mDisplayName = new ArticyValueArticyString();
        
        [SerializeField()]
        private PreviewImage mPreviewImage = new PreviewImage();
        
        [SerializeField()]
        private ArticyValueListLocationAnchor mAnchors = new ArticyValueListLocationAnchor();
        
        [SerializeField()]
        private ArticyValueListVector2 mVertices = new ArticyValueListVector2();
        
        [SerializeField()]
        private Transformation mTransform = new Transformation();
        
        [SerializeField()]
        private ShapeType mShapeType = new ShapeType();
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private ArticyValueArticyString mText = new ArticyValueArticyString();
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private UInt32 mShortId;
        
        [SerializeField()]
        private VisibilityModes mVisibility = new VisibilityModes();
        
        [SerializeField()]
        private Color mOutlineColor;
        
        [SerializeField()]
        private Single mOutlineSize;
        
        [SerializeField()]
        private OutlineStyle mOutlineStyle = new OutlineStyle();
        
        [SerializeField()]
        private SelectabilityModes mSelectability = new SelectabilityModes();
        
        [SerializeField()]
        private Boolean mDropShadow = new Boolean();
        
        [SerializeField()]
        private Rect mClipRect = new Rect();
        
        [SerializeField()]
        private Single mImageOpacity;
        
        [SerializeField()]
        private ArticyValueArticyObject mImageAsset = new ArticyValueArticyObject();
        
        [SerializeField()]
        private Int32 mCachedImageWidth;
        
        [SerializeField()]
        private Int32 mCachedImageHeight;
        
        [SerializeField()]
        private Boolean mShowDisplayName = new Boolean();
        
        [SerializeField()]
        private Color mDisplayNameColor;
        
        [SerializeField()]
        private Int32 mDisplayNameSize;
        
        public ArticyString DisplayName
        {
            get
            {
                return mDisplayName.GetValue();
            }
            set
            {
                mDisplayName.SetValue(value);
            }
        }
        
        public PreviewImage PreviewImage
        {
            get
            {
                return mPreviewImage;
            }
            set
            {
                var oldValue = mPreviewImage;
                mPreviewImage = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "PreviewImage", oldValue, mPreviewImage);
            }
        }
        
        public List<LocationAnchor> Anchors
        {
            get
            {
                return mAnchors.GetValue();
            }
            set
            {
                var oldValue = mAnchors;
                mAnchors.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Anchors", oldValue.GetValue(), mAnchors.GetValue());
            }
        }
        
        public List<Vector2> Vertices
        {
            get
            {
                return mVertices.GetValue();
            }
            set
            {
                var oldValue = mVertices;
                mVertices.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Vertices", oldValue.GetValue(), mVertices.GetValue());
            }
        }
        
        public Transformation Transform
        {
            get
            {
                return mTransform;
            }
            set
            {
                var oldValue = mTransform;
                mTransform = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Transform", oldValue, mTransform);
            }
        }
        
        public ShapeType ShapeType
        {
            get
            {
                return mShapeType;
            }
            set
            {
                var oldValue = mShapeType;
                mShapeType = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShapeType", oldValue, mShapeType);
            }
        }
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                var oldValue = mColor;
                mColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Color", oldValue, mColor);
            }
        }
        
        public ArticyString Text
        {
            get
            {
                return mText.GetValue();
            }
            set
            {
                mText.SetValue(value);
            }
        }
        
        public String ExternalId
        {
            get
            {
                return mExternalId;
            }
            set
            {
                var oldValue = mExternalId;
                mExternalId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ExternalId", oldValue, mExternalId);
            }
        }
        
        public Single ZIndex
        {
            get
            {
                return mZIndex;
            }
            set
            {
                var oldValue = mZIndex;
                mZIndex = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ZIndex", oldValue, mZIndex);
            }
        }
        
        public Vector2 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                var oldValue = mSize;
                mSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Size", oldValue, mSize);
            }
        }
        
        public UInt32 ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                var oldValue = mShortId;
                mShortId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShortId", oldValue, mShortId);
            }
        }
        
        public VisibilityModes Visibility
        {
            get
            {
                return mVisibility;
            }
            set
            {
                var oldValue = mVisibility;
                mVisibility = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Visibility", oldValue, mVisibility);
            }
        }
        
        public Color OutlineColor
        {
            get
            {
                return mOutlineColor;
            }
            set
            {
                var oldValue = mOutlineColor;
                mOutlineColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutlineColor", oldValue, mOutlineColor);
            }
        }
        
        public Single OutlineSize
        {
            get
            {
                return mOutlineSize;
            }
            set
            {
                var oldValue = mOutlineSize;
                mOutlineSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutlineSize", oldValue, mOutlineSize);
            }
        }
        
        public OutlineStyle OutlineStyle
        {
            get
            {
                return mOutlineStyle;
            }
            set
            {
                var oldValue = mOutlineStyle;
                mOutlineStyle = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutlineStyle", oldValue, mOutlineStyle);
            }
        }
        
        public SelectabilityModes Selectability
        {
            get
            {
                return mSelectability;
            }
            set
            {
                var oldValue = mSelectability;
                mSelectability = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Selectability", oldValue, mSelectability);
            }
        }
        
        public Boolean DropShadow
        {
            get
            {
                return mDropShadow;
            }
            set
            {
                var oldValue = mDropShadow;
                mDropShadow = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DropShadow", oldValue, mDropShadow);
            }
        }
        
        public Rect ClipRect
        {
            get
            {
                return mClipRect;
            }
            set
            {
                var oldValue = mClipRect;
                mClipRect = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ClipRect", oldValue, mClipRect);
            }
        }
        
        public Single ImageOpacity
        {
            get
            {
                return mImageOpacity;
            }
            set
            {
                var oldValue = mImageOpacity;
                mImageOpacity = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ImageOpacity", oldValue, mImageOpacity);
            }
        }
        
        public ArticyObject ImageAsset
        {
            get
            {
                return mImageAsset.GetValue();
            }
            set
            {
                var oldValue = mImageAsset;
                mImageAsset.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ImageAsset", oldValue.GetValue(), mImageAsset.GetValue());
            }
        }
        
        public Int32 CachedImageWidth
        {
            get
            {
                return mCachedImageWidth;
            }
            set
            {
                var oldValue = mCachedImageWidth;
                mCachedImageWidth = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "CachedImageWidth", oldValue, mCachedImageWidth);
            }
        }
        
        public Int32 CachedImageHeight
        {
            get
            {
                return mCachedImageHeight;
            }
            set
            {
                var oldValue = mCachedImageHeight;
                mCachedImageHeight = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "CachedImageHeight", oldValue, mCachedImageHeight);
            }
        }
        
        public Boolean ShowDisplayName
        {
            get
            {
                return mShowDisplayName;
            }
            set
            {
                var oldValue = mShowDisplayName;
                mShowDisplayName = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShowDisplayName", oldValue, mShowDisplayName);
            }
        }
        
        public Color DisplayNameColor
        {
            get
            {
                return mDisplayNameColor;
            }
            set
            {
                var oldValue = mDisplayNameColor;
                mDisplayNameColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DisplayNameColor", oldValue, mDisplayNameColor);
            }
        }
        
        public Int32 DisplayNameSize
        {
            get
            {
                return mDisplayNameSize;
            }
            set
            {
                var oldValue = mDisplayNameSize;
                mDisplayNameSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DisplayNameSize", oldValue, mDisplayNameSize);
            }
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            LocationImage newClone = ((LocationImage)(aClone));
            if ((mDisplayName != null))
            {
                newClone.mDisplayName = ((ArticyValueArticyString)(mDisplayName.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.PreviewImage = PreviewImage;
            List<LocationAnchor> temp_Anchors = new List<LocationAnchor>();
            int i = 0;
            for (i = 0; (i < Anchors.Count); i = (i + 1))
            {
                temp_Anchors.Add(((LocationAnchor)(Anchors[i].CloneObject(newClone, aFirstClassParent))));
            }
            newClone.Anchors = temp_Anchors;
            List<Vector2> temp_Vertices = new List<Vector2>();
            for (i = 0; (i < Vertices.Count); i = (i + 1))
            {
                temp_Vertices.Add(Vertices[i]);
            }
            newClone.Vertices = temp_Vertices;
            newClone.Transform = Transform;
            newClone.ShapeType = ShapeType;
            newClone.Color = Color;
            if ((mText != null))
            {
                newClone.mText = ((ArticyValueArticyString)(mText.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.ExternalId = ExternalId;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.ShortId = ShortId;
            newClone.Visibility = Visibility;
            newClone.OutlineColor = OutlineColor;
            newClone.OutlineSize = OutlineSize;
            newClone.OutlineStyle = OutlineStyle;
            newClone.Selectability = Selectability;
            newClone.DropShadow = DropShadow;
            newClone.ClipRect = ClipRect;
            newClone.ImageOpacity = ImageOpacity;
            if ((mImageAsset != null))
            {
                newClone.mImageAsset = ((ArticyValueArticyObject)(mImageAsset.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.CachedImageWidth = CachedImageWidth;
            newClone.CachedImageHeight = CachedImageHeight;
            newClone.ShowDisplayName = ShowDisplayName;
            newClone.DisplayNameColor = DisplayNameColor;
            newClone.DisplayNameSize = DisplayNameSize;
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "DisplayName"))
            {
                DisplayName = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "PreviewImage"))
            {
                PreviewImage = ((PreviewImage)(aValue));
                return;
            }
            if ((aProperty == "Anchors"))
            {
                Anchors = ((List<LocationAnchor>)(aValue));
                return;
            }
            if ((aProperty == "Vertices"))
            {
                Vertices = ((List<Vector2>)(aValue));
                return;
            }
            if ((aProperty == "Transform"))
            {
                Transform = ((Transformation)(aValue));
                return;
            }
            if ((aProperty == "ShapeType"))
            {
                ShapeType = ((ShapeType)(aValue));
                return;
            }
            if ((aProperty == "Color"))
            {
                Color = ((Color)(aValue));
                return;
            }
            if ((aProperty == "Text"))
            {
                Text = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ExternalId"))
            {
                ExternalId = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ZIndex"))
            {
                ZIndex = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Size"))
            {
                Size = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ShortId"))
            {
                ShortId = ((UInt32)(aValue));
                return;
            }
            if ((aProperty == "Visibility"))
            {
                Visibility = ((VisibilityModes)(aValue));
                return;
            }
            if ((aProperty == "OutlineColor"))
            {
                OutlineColor = ((Color)(aValue));
                return;
            }
            if ((aProperty == "OutlineSize"))
            {
                OutlineSize = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "OutlineStyle"))
            {
                OutlineStyle = ((OutlineStyle)(aValue));
                return;
            }
            if ((aProperty == "Selectability"))
            {
                Selectability = ((SelectabilityModes)(aValue));
                return;
            }
            if ((aProperty == "DropShadow"))
            {
                DropShadow = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "ClipRect"))
            {
                ClipRect = ((Rect)(aValue));
                return;
            }
            if ((aProperty == "ImageOpacity"))
            {
                ImageOpacity = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "ImageAsset"))
            {
                ImageAsset = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "CachedImageWidth"))
            {
                CachedImageWidth = System.Convert.ToInt32(aValue);
                return;
            }
            if ((aProperty == "CachedImageHeight"))
            {
                CachedImageHeight = System.Convert.ToInt32(aValue);
                return;
            }
            if ((aProperty == "ShowDisplayName"))
            {
                ShowDisplayName = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "DisplayNameColor"))
            {
                DisplayNameColor = ((Color)(aValue));
                return;
            }
            if ((aProperty == "DisplayNameSize"))
            {
                DisplayNameSize = System.Convert.ToInt32(aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "DisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayName);
            }
            if ((aProperty == "PreviewImage"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(PreviewImage);
            }
            if ((aProperty == "Anchors"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Anchors);
            }
            if ((aProperty == "Vertices"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Vertices);
            }
            if ((aProperty == "Transform"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Transform);
            }
            if ((aProperty == "ShapeType"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShapeType);
            }
            if ((aProperty == "Color"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Color);
            }
            if ((aProperty == "Text"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Text);
            }
            if ((aProperty == "ExternalId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ExternalId);
            }
            if ((aProperty == "ZIndex"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ZIndex);
            }
            if ((aProperty == "Size"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Size);
            }
            if ((aProperty == "ShortId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShortId);
            }
            if ((aProperty == "Visibility"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Visibility);
            }
            if ((aProperty == "OutlineColor"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineColor);
            }
            if ((aProperty == "OutlineSize"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineSize);
            }
            if ((aProperty == "OutlineStyle"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineStyle);
            }
            if ((aProperty == "Selectability"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Selectability);
            }
            if ((aProperty == "DropShadow"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DropShadow);
            }
            if ((aProperty == "ClipRect"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ClipRect);
            }
            if ((aProperty == "ImageOpacity"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ImageOpacity);
            }
            if ((aProperty == "ImageAsset"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ImageAsset);
            }
            if ((aProperty == "CachedImageWidth"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CachedImageWidth);
            }
            if ((aProperty == "CachedImageHeight"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CachedImageHeight);
            }
            if ((aProperty == "ShowDisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShowDisplayName);
            }
            if ((aProperty == "DisplayNameColor"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayNameColor);
            }
            if ((aProperty == "DisplayNameSize"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayNameSize);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
