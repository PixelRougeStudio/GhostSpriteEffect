﻿using UnityEngine;
using UnityEditor;

namespace VermillionVanguard.GhostSprite.InspectorAttributes
{
    [CustomPropertyDrawer(typeof(ShowInPlayModeAttribute))]
    public class ShowInPlayModeAttributeDrawer : BasePropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (!Application.isPlaying)
            {
                return 0f;
            }

            return base.GetPropertyHeight(property, label);
        }
    }
}
