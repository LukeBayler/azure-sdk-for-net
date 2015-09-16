// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// A table defines the schema of the data as well as its storage.
    /// </summary>
    public partial class Table
    {
        private string _name;
        
        /// <summary>
        /// Required. Name of the table.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private TableProperties _properties;
        
        /// <summary>
        /// Required. Table properties.
        /// </summary>
        public TableProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Table class with required
        /// arguments.
        /// </summary>
        public Table(string name, TableProperties properties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Name = name;
            this.Properties = properties;
        }
    }
}