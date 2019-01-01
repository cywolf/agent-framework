﻿using System.Collections.Generic;

namespace AgentFramework.Core.Models.Connections
{
    /// <summary>
    /// Config for controlling invitation creation.
    /// </summary>
    public class AcceptInviteConfiguration
    {
        /// <summary>
        /// Id of the resulting connection record created
        /// by the invite.
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Id of the service to disclose in the invite.
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Alias object for marking the invite subject
        /// with an alias for giving the inviter greater context. 
        /// </summary>
        public ConnectionAlias TheirAlias { get; set; } = new ConnectionAlias();

        /// <summary>
        /// For optionally setting my alias information
        /// on the invite.
        /// </summary>
        public ConnectionAlias MyAlias { get; set; } = new ConnectionAlias();

        /// <summary>
        /// Controls the tags that are persisted against the invite/connection record.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>();
    }
}