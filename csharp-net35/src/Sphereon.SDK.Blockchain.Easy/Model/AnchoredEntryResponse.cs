/* 
 * Easy Blockchain API
 *
 * <b>The Easy Blockchain API is an easy to use API to store entries within chains. Currently it stores entries using the bitcoin blockchain by means of Factom or Multichain. The latter also allows for a private blockchain. In the future other solutions will be made available</b>    The flow is generally as follows:  1. Make sure a context is available using the / POST endpoint. Normally you only need one context. This is the place where backend providers and blockchain implementations are being specified.  2. Make sure a chain has been created using the /chain POST endpoint. Normally you only need one or a handful of chains. This is a relative expensive operation.  3. Store entries on the chain from step 2. The entries will contain the content and metadata you want to store forever on the specified chain.  4. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sphereon.SDK.Blockchain.Easy.Model
{
    /// <summary>
    /// Anchored Entry response
    /// </summary>
    [DataContract]
    public partial class AnchoredEntryResponse :  IEquatable<AnchoredEntryResponse>
    {
        /// <summary>
        /// Gets or Sets AnchorState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AnchorStateEnum
        {
            
            /// <summary>
            /// Enum REQUESTED for "REQUESTED"
            /// </summary>
            [EnumMember(Value = "REQUESTED")]
            REQUESTED,
            
            /// <summary>
            /// Enum COMMITTED for "COMMITTED"
            /// </summary>
            [EnumMember(Value = "COMMITTED")]
            COMMITTED,
            
            /// <summary>
            /// Enum NOTFOUND for "NOT_FOUND"
            /// </summary>
            [EnumMember(Value = "NOT_FOUND")]
            NOTFOUND
        }

        /// <summary>
        /// Gets or Sets AnchorState
        /// </summary>
        [DataMember(Name="anchorState", EmitDefaultValue=false)]
        public AnchorStateEnum? AnchorState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnchoredEntryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnchoredEntryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnchoredEntryResponse" /> class.
        /// </summary>
        /// <param name="AnchoredEntry">AnchoredEntry (required).</param>
        /// <param name="AnchorTimes">The times at which the anchoredEntry was anchored in the blockchain in ISO 8601 format.</param>
        public AnchoredEntryResponse(CommittedEntry AnchoredEntry = null, List<DateTime?> AnchorTimes = null)
        {
            // to ensure "AnchoredEntry" is required (not null)
            if (AnchoredEntry == null)
            {
                throw new InvalidDataException("AnchoredEntry is a required property for AnchoredEntryResponse and cannot be null");
            }
            else
            {
                this.AnchoredEntry = AnchoredEntry;
            }
            this.AnchorTimes = AnchorTimes;
        }
        
        /// <summary>
        /// Gets or Sets AnchoredEntry
        /// </summary>
        [DataMember(Name="anchoredEntry", EmitDefaultValue=false)]
        public CommittedEntry AnchoredEntry { get; set; }
        /// <summary>
        /// The times at which the anchoredEntry was anchored in the blockchain in ISO 8601 format
        /// </summary>
        /// <value>The times at which the anchoredEntry was anchored in the blockchain in ISO 8601 format</value>
        [DataMember(Name="anchorTimes", EmitDefaultValue=false)]
        public List<DateTime?> AnchorTimes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnchoredEntryResponse {\n");
            sb.Append("  AnchoredEntry: ").Append(AnchoredEntry).Append("\n");
            sb.Append("  AnchorTimes: ").Append(AnchorTimes).Append("\n");
            sb.Append("  AnchorState: ").Append(AnchorState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AnchoredEntryResponse);
        }

        /// <summary>
        /// Returns true if AnchoredEntryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnchoredEntryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnchoredEntryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnchoredEntry == other.AnchoredEntry ||
                    this.AnchoredEntry != null &&
                    this.AnchoredEntry.Equals(other.AnchoredEntry)
                ) && 
                (
                    this.AnchorTimes == other.AnchorTimes ||
                    this.AnchorTimes != null &&
                    this.AnchorTimes.SequenceEqual(other.AnchorTimes)
                ) && 
                (
                    this.AnchorState == other.AnchorState ||
                    this.AnchorState != null &&
                    this.AnchorState.Equals(other.AnchorState)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AnchoredEntry != null)
                    hash = hash * 59 + this.AnchoredEntry.GetHashCode();
                if (this.AnchorTimes != null)
                    hash = hash * 59 + this.AnchorTimes.GetHashCode();
                if (this.AnchorState != null)
                    hash = hash * 59 + this.AnchorState.GetHashCode();
                return hash;
            }
        }
    }

}