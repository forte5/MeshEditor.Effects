﻿using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace MeshEditor.Effects
{
    /// <summary>
    /// 编辑器工具箱
    /// </summary>
    public static class EditorToolkit
    {
        #region 层级视图新建菜单
        /// <summary>
        /// 新建Vortex特效
        /// </summary>
        [@MenuItem("GameObject/MeshEditor/Effects/Vortex", false, 0)]
        private static void CreateXLuaValidate()
        {
            GameObject obj = Selection.activeGameObject;
            if (obj == null)
            {
                obj = new GameObject("New Vortex");
                obj.transform.localPosition = Vector3.zero;
                obj.transform.localRotation = Quaternion.identity;
                obj.transform.localScale = Vector3.one;
                obj.SetActive(true);
            }

            obj.AddComponent<MeshVortex>();
            Selection.activeGameObject = obj;
            EditorSceneManager.MarkSceneDirty(obj.scene);
        }
        #endregion
    }
}