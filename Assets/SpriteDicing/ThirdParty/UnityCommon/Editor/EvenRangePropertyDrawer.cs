﻿// Copyright 2012-2017 Elringus (Artyom Sovetnikov). All Rights Reserved.

namespace UnityCommon
{
    using UnityEditor;
    using UnityEngine;
    
    [CustomPropertyDrawer(typeof(EvenRangeAttribute))]
    public class EvenRangePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            var evenRangeAttribute = attribute as EvenRangeAttribute;
            var min = evenRangeAttribute.Min;
            var max = evenRangeAttribute.Max;
            property.intValue = EditorGUI.IntSlider(position, label, property.intValue, min, max).ToNearestEven(max);
        }
    }
    
}