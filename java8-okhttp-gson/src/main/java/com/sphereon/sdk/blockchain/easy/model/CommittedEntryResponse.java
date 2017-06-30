/*
 * Easy Blockchain API
 * <b>The Easy Blockchain API is an easy to use API to store entries within chains. Currently it stores entries using the bitcoin blockchain by means of Factom or Multichain. The latter also allows for a private blockchain. In the future other solutions will be made available</b>    The flow is generally as follows:  1. Make sure a context is available using the / POST endpoint. Normally you only need one context. This is the place where backend providers and blockchain implementations are being specified.  2. Make sure a chain has been created using the /chain POST endpoint. Normally you only need one or a handful of chains. This is a relative expensive operation.  3. Store entries on the chain from step 2. The entries will contain the content and metadata you want to store forever on the specified chain.  4. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.1
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
import com.sphereon.sdk.blockchain.easy.model.CommittedEntry;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.time.OffsetDateTime;

/**
 * Committed EntryData response
 */
@ApiModel(description = "Committed EntryData response")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2017-06-30T16:07:32.641+02:00")
public class CommittedEntryResponse {
  @SerializedName("entry")
  private CommittedEntry entry = null;

  @SerializedName("commitTime")
  private OffsetDateTime commitTime = null;

  @SerializedName("creationRequestTime")
  private OffsetDateTime creationRequestTime = null;

  public CommittedEntryResponse entry(CommittedEntry entry) {
    this.entry = entry;
    return this;
  }

   /**
   * Get entry
   * @return entry
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public CommittedEntry getEntry() {
    return entry;
  }

  public void setEntry(CommittedEntry entry) {
    this.entry = entry;
  }

   /**
   * The time at which the entry creation was first requested in ISO 8601 format
   * @return commitTime
  **/
  @ApiModelProperty(example = "null", value = "The time at which the entry creation was first requested in ISO 8601 format")
  public OffsetDateTime getCommitTime() {
    return commitTime;
  }

   /**
   * The time at which the entry creation was first requested in ISO 8601 format
   * @return creationRequestTime
  **/
  @ApiModelProperty(example = "null", value = "The time at which the entry creation was first requested in ISO 8601 format")
  public OffsetDateTime getCreationRequestTime() {
    return creationRequestTime;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CommittedEntryResponse committedEntryResponse = (CommittedEntryResponse) o;
    return Objects.equals(this.entry, committedEntryResponse.entry) &&
        Objects.equals(this.commitTime, committedEntryResponse.commitTime) &&
        Objects.equals(this.creationRequestTime, committedEntryResponse.creationRequestTime);
  }

  @Override
  public int hashCode() {
    return Objects.hash(entry, commitTime, creationRequestTime);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CommittedEntryResponse {\n");
    
    sb.append("    entry: ").append(toIndentedString(entry)).append("\n");
    sb.append("    commitTime: ").append(toIndentedString(commitTime)).append("\n");
    sb.append("    creationRequestTime: ").append(toIndentedString(creationRequestTime)).append("\n");
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

