// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.fieldValueSet&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.fieldValueSet&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "FieldValueSetObject", DefaultParameterSetName = @"microsoft.graph.fieldValueSet")]
    [ODataType("microsoft.graph.fieldValueSet")]
    public class New_FieldValueSetObject : ObjectFactoryCmdletBase
    {
    }
}