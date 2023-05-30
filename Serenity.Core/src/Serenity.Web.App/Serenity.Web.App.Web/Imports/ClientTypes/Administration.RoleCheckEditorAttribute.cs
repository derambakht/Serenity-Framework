using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity.Web.App.Administration
{
    public partial class RoleCheckEditorAttribute : CustomEditorAttribute
    {
        public const string MainKey = "Serenity.Web.App.Administration.RoleCheckEditor";

        public RoleCheckEditorAttribute()
            : base(MainKey)
        {
        }
    }
}