using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DivisionUI
{
    public class Panel : Container
    {
        private Rect rect;
        public Texture2D texture;

        public void SetRect(Vector2 position, Vector2 size)
        {
            rect = new Rect(position, size);
        }

        public Panel()
        {
            rect = new Rect();
        }

        private void calculateRects()
        {

        }

        protected override void Render()
        {
            Graphics.DrawTexture(rect, texture);
        }
    }
}