using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorkflowTools
{
    [ExecuteAlways]
    public class HideHierarchy : MonoBehaviour
    {
#if UNITY_EDITOR
        private void Awake()
        {
            HideChildren(false);
        }

        private void HideChildren(bool hidden)
        {
            Transform[] children = GetComponentsInChildren<Transform>();

            foreach (Transform child in children)
            {
                if (child.gameObject == gameObject) continue;
                HideFlags flags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
                if (!hidden) flags = HideFlags.None;
                child.gameObject.hideFlags = flags;
            }
        }
#endif
    }
}