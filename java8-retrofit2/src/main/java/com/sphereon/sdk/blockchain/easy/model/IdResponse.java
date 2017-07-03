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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * Id response
 */
@ApiModel(description = "Id response")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2017-07-03T11:09:47.419+02:00")
public class IdResponse {
  /**
   * Gets or Sets exists
   */
  public enum ExistsEnum {
    @SerializedName("True")
    TRUE("True"),
    
    @SerializedName("False")
    FALSE("False"),
    
    @SerializedName("Unknown")
    UNKNOWN("Unknown");

    private String value;

    ExistsEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("exists")
  private ExistsEnum exists = null;

  @SerializedName("Id")
  private String id = null;

  public IdResponse exists(ExistsEnum exists) {
    this.exists = exists;
    return this;
  }

   /**
   * Get exists
   * @return exists
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public ExistsEnum getExists() {
    return exists;
  }

  public void setExists(ExistsEnum exists) {
    this.exists = exists;
  }

  public IdResponse id(String id) {
    this.id = id;
    return this;
  }

   /**
   * The Id
   * @return id
  **/
  @ApiModelProperty(example = "null", value = "The Id")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    IdResponse idResponse = (IdResponse) o;
    return Objects.equals(this.exists, idResponse.exists) &&
        Objects.equals(this.id, idResponse.id);
  }

  @Override
  public int hashCode() {
    return Objects.hash(exists, id);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class IdResponse {\n");
    
    sb.append("    exists: ").append(toIndentedString(exists)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
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

