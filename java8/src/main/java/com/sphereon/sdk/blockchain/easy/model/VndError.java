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
import com.sphereon.sdk.blockchain.easy.model.Link;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * VndError
 */
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-12T22:38:27.092+01:00")
public class VndError   {
  @SerializedName("logref")
  private String logref = null;

  @SerializedName("link")
  private Map<String, Link> link = new HashMap<String, Link>();

  @SerializedName("message")
  private String message = null;

  public VndError logref(String logref) {
    this.logref = logref;
    return this;
  }

   /**
   * Get logref
   * @return logref
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getLogref() {
    return logref;
  }

  public void setLogref(String logref) {
    this.logref = logref;
  }

  public VndError link(Map<String, Link> link) {
    this.link = link;
    return this;
  }

  public VndError putLinkItem(String key, Link linkItem) {
    this.link.put(key, linkItem);
    return this;
  }

   /**
   * Get link
   * @return link
  **/
  @ApiModelProperty(example = "null", value = "")
  public Map<String, Link> getLink() {
    return link;
  }

  public void setLink(Map<String, Link> link) {
    this.link = link;
  }

  public VndError message(String message) {
    this.message = message;
    return this;
  }

   /**
   * Get message
   * @return message
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getMessage() {
    return message;
  }

  public void setMessage(String message) {
    this.message = message;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    VndError vndError = (VndError) o;
    return Objects.equals(this.logref, vndError.logref) &&
        Objects.equals(this.link, vndError.link) &&
        Objects.equals(this.message, vndError.message);
  }

  @Override
  public int hashCode() {
    return Objects.hash(logref, link, message);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VndError {\n");
    
    sb.append("    logref: ").append(toIndentedString(logref)).append("\n");
    sb.append("    link: ").append(toIndentedString(link)).append("\n");
    sb.append("    message: ").append(toIndentedString(message)).append("\n");
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

