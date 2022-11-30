﻿using System;
using System.Windows.Forms;

namespace SEM5_LR6.Tools
{
    public interface ITool
    {
        void OnClearClick(EventArgs e);
        void OnDrawClick(EventArgs e);

        void OnMouseDown(MouseEventArgs e);
        void OnMouseMove(MouseEventArgs e);
        void OnMouseUp(MouseEventArgs e);
    }
}
