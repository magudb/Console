﻿using System.Management.Automation;
using System.Management.Automation.Internal;
using Cognifide.PowerShell.Core.Utility;
using Sitecore.Data.Items;

namespace Cognifide.PowerShell.Commandlets.Security
{
    [Cmdlet(VerbsSecurity.Protect, "Item", SupportsShouldProcess = true)]
    [OutputType(typeof (Item), ParameterSetName = new[] {"Item from Pipeline", "Item from Path", "Item from ID"})]
    public class ProtectItemCommand : BaseEditItemCommand
    {
        protected override void EditItem(Item item)
        {
            if (ShouldProcess(item.GetProviderPath(), "Protect item"))
            {
                item.Appearance.ReadOnly = true;
            }
        }
    }
}