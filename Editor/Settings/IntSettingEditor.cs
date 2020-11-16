﻿using System;
using UnityEditor;
using UnityEngine;

namespace GameSettings.Editor
{
    [CustomEditor(typeof(IntSetting), true)]
    public class IntSettingEditor : GameSettingEditor
    {
        public override void OnInspectorGUI()
        {
            DrawLoadOnStartupToggle();
            DrawValue();
            DrawProperties();
        }

        protected void DrawValue(bool delayed = false)
        {
            var intSetting = (IntSetting)target;

            try
            {
                EditorGUI.BeginChangeCheck();
                var newValue = delayed
                    ? EditorGUILayout.DelayedIntField(intSetting.settingName, intSetting.value)
                    : EditorGUILayout.IntField(intSetting.settingName, intSetting.value);
                if(EditorGUI.EndChangeCheck())
                {
                    intSetting.value = newValue;
                }
            }
            catch(Exception e)
            {
                Debug.LogError(e);
            }
}
    }
}

