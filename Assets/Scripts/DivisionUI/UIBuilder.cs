using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DivisionUI
{
    public class UIBuilder : ScriptableObject
    {
        private static Vector2 defaultPanelSize = new Vector2(150, 150);
        private static Texture2D defaultPanelTexture = Texture2D.whiteTexture;

        private static GameObject CreateRootObject(string name, Vector2 size)
        {
            GameObject child = new GameObject(name);
            UITransform transform = child.AddComponent<UITransform>();
            transform.size = size;

            return child;
        }

        private static GameObject CreaeUIObect(string name, GameObject parent)
        {
            GameObject o = CreateRootObject(name, defaultPanelSize);
            o.AddComponent<UITransform>();
            SetupHierarchy(o, parent);

            return o;
        }

        private static void SetupHierarchy(GameObject child, GameObject parent)
        {
            if (parent == null)
                return;

            child.transform.SetParent(parent.transform, false);
            int layer = parent.layer;
            child.layer = layer;

            Transform t = child.transform;

            for (int i = 0; i < t.childCount; i++)
            {
                t.GetChild(i).transform.gameObject.layer = layer;
            }
        }

        [AddComponentMenu("Assets/DivisionUI/Panel")]
        public static GameObject CreatePanel()
        {
            GameObject panelRoot = CreateRootObject("Panel", defaultPanelSize);
            Panel panel = panelRoot.AddComponent<Panel>();
            UITransform transform = panelRoot.GetComponent<UITransform>();
            panel.uiTransform = transform;

            panel.texture = defaultPanelTexture;
            panel.SetRect(transform.position, transform.size);

            return panelRoot;
        }
    }
}