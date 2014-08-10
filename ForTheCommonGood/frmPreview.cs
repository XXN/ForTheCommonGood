﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ForTheCommonGood
{
    public partial class frmPreview: Form
    {
        public frmPreview()
        {
            InitializeComponent();

            Text = Localization.GetString("PreviewCommonsWikitext_Hyperlink");
            button1.Text = Localization.GetString("Close_Button");

            SetContent("<center style=\"font: 10pt Tahoma;\"><b>Loading...</b></center>");
        }

        public void SetContent(string html)
        {
            webBrowser1.DocumentText = "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" /><link rel=\"stylesheet\" " +
                "href=\"http://bits.wikimedia.org/commons.wikimedia.org/load.php?debug=false&amp;lang=en&amp;modules=ext.filepage%7Cmediawiki.legacy.shared%7Cskins.common.interface%7Cskins.vector.styles&amp;only=styles&amp;skin=vector&amp;*\" />" +
                "<link rel=\"stylesheet\" " +
                "href=\"http://bits.wikimedia.org/commons.wikimedia.org/load.php?debug=false&amp;lang=en&amp;modules=site&amp;only=styles&amp;skin=vector&amp;*\" />" +
                "<base href=\"http://" + MorebitsDotNet.GetDomain(Wiki.Commons) + "/wiki/x\" target=\"_blank\" />" +
                "<style>body { font-size: 0.8em; background-color: white; color: black; padding: 0.8em; } .editsection, .mw-editsection { display: none; }</style>" + 
                html;
        }
    }
}
