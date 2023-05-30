using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity.Web.App.Administration
{
    public partial class PermissionCheckEditorAttribute : CustomEditorAttribute
    {
        public const string MainKey = "Serenity.Web.App.Administration.PermissionCheckEditor";

        public PermissionCheckEditorAttribute()
            : base(MainKey)
        {
        }

        public bool ShowRevoke
        {
            get { return GetOption<bool>("showRevoke"); }
            set { SetOption("showRevoke", value); }
        }
    }
}