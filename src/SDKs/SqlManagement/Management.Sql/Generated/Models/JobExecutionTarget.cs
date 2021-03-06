// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The target that a job execution is executed on.
    /// </summary>
    public partial class JobExecutionTarget
    {
        /// <summary>
        /// Initializes a new instance of the JobExecutionTarget class.
        /// </summary>
        public JobExecutionTarget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobExecutionTarget class.
        /// </summary>
        /// <param name="type">The type of the target. Possible values include:
        /// 'TargetGroup', 'SqlDatabase', 'SqlElasticPool', 'SqlShardMap',
        /// 'SqlServer'</param>
        /// <param name="serverName">The server name.</param>
        /// <param name="databaseName">The database name.</param>
        public JobExecutionTarget(string type = default(string), string serverName = default(string), string databaseName = default(string))
        {
            Type = type;
            ServerName = serverName;
            DatabaseName = databaseName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of the target. Possible values include:
        /// 'TargetGroup', 'SqlDatabase', 'SqlElasticPool', 'SqlShardMap',
        /// 'SqlServer'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the server name.
        /// </summary>
        [JsonProperty(PropertyName = "serverName")]
        public string ServerName { get; private set; }

        /// <summary>
        /// Gets the database name.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; private set; }

    }
}
