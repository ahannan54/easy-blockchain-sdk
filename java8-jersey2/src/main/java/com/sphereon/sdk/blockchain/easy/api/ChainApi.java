package com.sphereon.sdk.blockchain.easy.api;

import com.sphereon.sdk.blockchain.easy.handler.ApiException;
import com.sphereon.sdk.blockchain.easy.handler.ApiClient;
import com.sphereon.sdk.blockchain.easy.handler.Configuration;
import com.sphereon.sdk.blockchain.easy.handler.Pair;

import javax.ws.rs.core.GenericType;

import com.sphereon.sdk.blockchain.easy.model.CommittedChainResponse;
import com.sphereon.sdk.blockchain.easy.model.Chain;
import com.sphereon.sdk.blockchain.easy.model.VndErrors;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-14T02:45:39.206+01:00")
public class ChainApi {
  private ApiClient apiClient;

  public ChainApi() {
    this(Configuration.getDefaultApiClient());
  }

  public ChainApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  /**
   * Create a new chain
   * 
   * @param chain Create a chain using the first entry supplied. The entry needs at least a (combination of) globaly unique external Id in the complete Blockchain network! (required)
   * @return CommittedChainResponse
   * @throws ApiException if fails to make API call
   */
  public CommittedChainResponse createChain(Chain chain) throws ApiException {
    Object localVarPostBody = chain;
    
    // verify the required parameter 'chain' is set
    if (chain == null) {
      throw new ApiException(400, "Missing the required parameter 'chain' when calling createChain");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/easy/0.1.0/chains".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    
    final String[] localVarAccepts = {
      "application/json"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<CommittedChainResponse> localVarReturnType = new GenericType<CommittedChainResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
}