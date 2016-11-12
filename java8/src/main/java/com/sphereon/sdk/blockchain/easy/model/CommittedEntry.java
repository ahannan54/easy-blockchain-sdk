/**
 * Easy Blockchain API
 * <b>The Easy Blockchain API is an easy to use API to store entries within chains. Currently it stores entries using the bitcoin blockchain by means of Factom. In the future other solutions will be made available</b>    The flow is generally as follows:  1. Make sure a chain has been created using the /chain POST endpoint. Normally you only need one or a handful of chains. This is an expensive operation.  2. Store entries on the chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


package com.sphereon.sdk.blockchain.easy.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import com.sphereon.sdk.blockchain.easy.model.Entry;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


/**
 * Commited Entry
 */
@ApiModel(description = "Commited Entry")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-12T22:38:27.092+01:00")
public class CommittedEntry   {
  @SerializedName("entry")
  private Entry entry = null;

  @SerializedName("chainId")
  private String chainId = null;

  /**
   * Gets or Sets dataStructure
   */
  public enum DataStructureEnum {
    @SerializedName("Factom")
    FACTOM("Factom");

    private String value;

    DataStructureEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("dataStructure")
  private DataStructureEnum dataStructure = null;

  /**
   * Gets or Sets blockchainImplementation
   */
  public enum BlockchainImplementationEnum {
    @SerializedName("Bitcoin")
    BITCOIN("Bitcoin");

    private String value;

    BlockchainImplementationEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("blockchainImplementation")
  private BlockchainImplementationEnum blockchainImplementation = null;

  @SerializedName("entryId")
  private String entryId = null;

  public CommittedEntry entry(Entry entry) {
    this.entry = entry;
    return this;
  }

   /**
   * Get entry
   * @return entry
  **/
  @ApiModelProperty(example = "null", value = "")
  public Entry getEntry() {
    return entry;
  }

  public void setEntry(Entry entry) {
    this.entry = entry;
  }

   /**
   * Chain ID
   * @return chainId
  **/
  @ApiModelProperty(example = "null", value = "Chain ID")
  public String getChainId() {
    return chainId;
  }

   /**
   * Get dataStructure
   * @return dataStructure
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public DataStructureEnum getDataStructure() {
    return dataStructure;
  }

   /**
   * Get blockchainImplementation
   * @return blockchainImplementation
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public BlockchainImplementationEnum getBlockchainImplementation() {
    return blockchainImplementation;
  }

   /**
   * Entry ID
   * @return entryId
  **/
  @ApiModelProperty(example = "null", value = "Entry ID")
  public String getEntryId() {
    return entryId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CommittedEntry committedEntry = (CommittedEntry) o;
    return Objects.equals(this.entry, committedEntry.entry) &&
        Objects.equals(this.chainId, committedEntry.chainId) &&
        Objects.equals(this.dataStructure, committedEntry.dataStructure) &&
        Objects.equals(this.blockchainImplementation, committedEntry.blockchainImplementation) &&
        Objects.equals(this.entryId, committedEntry.entryId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(entry, chainId, dataStructure, blockchainImplementation, entryId);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CommittedEntry {\n");
    
    sb.append("    entry: ").append(toIndentedString(entry)).append("\n");
    sb.append("    chainId: ").append(toIndentedString(chainId)).append("\n");
    sb.append("    dataStructure: ").append(toIndentedString(dataStructure)).append("\n");
    sb.append("    blockchainImplementation: ").append(toIndentedString(blockchainImplementation)).append("\n");
    sb.append("    entryId: ").append(toIndentedString(entryId)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

