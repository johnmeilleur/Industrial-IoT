﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Publisher.Config.Models {
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains the nodes which should be
    /// </summary>
    [DataContract]
    public class PublishedNodesEntryModel {

        /// <summary> Id Identifier of the DataFlow - DataSetWriterId. </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string DataSetWriterId { get; set; }

        /// <summary> The Group the stream belongs to - DataSetWriterGroup. </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string DataSetWriterGroup { get; set; }

        /// <summary> The Publishing interval for a dataset writer in miliseconds.</summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public int? DataSetPublishingInterval { get; set; }

        /// <summary> The Publishing interval for a dataset writer in timespan format.</summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public TimeSpan? DataSetPublishingIntervalTimespan { get; set; }

        /// <summary> The endpoint URL of the OPC UA server.</summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public Uri EndpointUrl { get; set; }

        /// <summary> Secure transport should be used to connect to the opc server.</summary>
        [DataMember(EmitDefaultValue = true, IsRequired = false)]
        public bool UseSecurity { get; set; }

        /// <summary> The node to monitor in "ns=" syntax. </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public NodeIdModel NodeId { get; set; }

        /// <summary> authentication mode </summary>
        [DataMember(EmitDefaultValue = true, IsRequired = false)]
        public OpcAuthenticationMode OpcAuthenticationMode { get; set; }

        /// <summary> encrypted username </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string EncryptedAuthUsername { get; set; }

        /// <summary> encrypted password </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string EncryptedAuthPassword { get; set; }

        /// <summary> plain username </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string OpcAuthenticationUsername { get; set; }

        /// <summary> plain password </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string OpcAuthenticationPassword { get; set; }

        /// <summary> User assigned tag. </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Tag { get; set; }

        /// <summary> Nodes defined in the collection. </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public List<OpcNodeModel> OpcNodes { get; set; }
    }
}
