// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;content&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/me/drive/items/{itemId}/children/{childId}/versions/{versionId}/content</para>
    ///     <para type="description">Retrieves the data stream from the &quot;content&quot; object.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Items_Children_Versions_Content")]
    [ODataType("Edm.Stream")]
    public class Get_Me_Drive_Items_Children_Versions_Content : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/versions/{versionId}/content";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;content&quot; property on a &quot;microsoft.graph.driveItemVersion&quot; object.</para>
    ///     <para type="description">PUT ~/me/drive/items/{itemId}/children/{childId}/versions/{versionId}/content</para>
    ///     <para type="description">Sets the data for the &quot;content&quot; property on a &quot;microsoft.graph.driveItemVersion&quot; object.</para>
    /// </summary>
    [Cmdlet("Set", "Me_Drive_Items_Children_Versions_Content", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("Edm.Stream")]
    public class Set_Me_Drive_Items_Children_Versions_Content : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/versions/{versionId}/content";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;content&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/items/{itemId}/children/{childId}/versions/{versionId}/content/$ref</para>
    ///     <para type="description">Removes a reference from a &quot;content&quot; resource (which is of type &quot;Edm.Stream&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Items_Children_Versions_ContentData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("Edm.Stream")]
    public class Remove_Me_Drive_Items_Children_Versions_ContentData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;children&quot; collection.")]
        public System.String childId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/items/{itemId}/children/{childId}/versions/{versionId}/content";
        }
    }
}