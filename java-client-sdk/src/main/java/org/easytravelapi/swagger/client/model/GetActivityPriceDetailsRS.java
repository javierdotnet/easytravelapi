package org.easytravelapi.swagger.client.model;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * Container for the activity price details
 */
@ApiModel(description = "Container for the activity price details")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2017-09-18T08:43:59.135Z")
public class GetActivityPriceDetailsRS {
  @SerializedName("statusCode")
  private Integer statusCode = null;

  @SerializedName("msg")
  private String msg = null;

  @SerializedName("systemTime")
  private String systemTime = null;

  @SerializedName("cancellationCosts")
  private List<CancellationCost> cancellationCosts = new ArrayList<CancellationCost>();

  @SerializedName("remarks")
  private List<Remark> remarks = new ArrayList<Remark>();

  public GetActivityPriceDetailsRS statusCode(Integer statusCode) {
    this.statusCode = statusCode;
    return this;
  }

   /**
   * status code for the operation. It will be 200 if it was OK and any other value if something went wrong. Provider dependant
   * @return statusCode
  **/
  @ApiModelProperty(value = "status code for the operation. It will be 200 if it was OK and any other value if something went wrong. Provider dependant")
  public Integer getStatusCode() {
    return statusCode;
  }

  public void setStatusCode(Integer statusCode) {
    this.statusCode = statusCode;
  }

  public GetActivityPriceDetailsRS msg(String msg) {
    this.msg = msg;
    return this;
  }

   /**
   * error message, if needed
   * @return msg
  **/
  @ApiModelProperty(value = "error message, if needed")
  public String getMsg() {
    return msg;
  }

  public void setMsg(String msg) {
    this.msg = msg;
  }

  public GetActivityPriceDetailsRS systemTime(String systemTime) {
    this.systemTime = systemTime;
    return this;
  }

   /**
   * System time in ISO8651 format. Useful for bug resolution
   * @return systemTime
  **/
  @ApiModelProperty(value = "System time in ISO8651 format. Useful for bug resolution")
  public String getSystemTime() {
    return systemTime;
  }

  public void setSystemTime(String systemTime) {
    this.systemTime = systemTime;
  }

  public GetActivityPriceDetailsRS cancellationCosts(List<CancellationCost> cancellationCosts) {
    this.cancellationCosts = cancellationCosts;
    return this;
  }

  public GetActivityPriceDetailsRS addCancellationCostsItem(CancellationCost cancellationCostsItem) {
    this.cancellationCosts.add(cancellationCostsItem);
    return this;
  }

   /**
   * Cancellation costs for this activity
   * @return cancellationCosts
  **/
  @ApiModelProperty(value = "Cancellation costs for this activity")
  public List<CancellationCost> getCancellationCosts() {
    return cancellationCosts;
  }

  public void setCancellationCosts(List<CancellationCost> cancellationCosts) {
    this.cancellationCosts = cancellationCosts;
  }

  public GetActivityPriceDetailsRS remarks(List<Remark> remarks) {
    this.remarks = remarks;
    return this;
  }

  public GetActivityPriceDetailsRS addRemarksItem(Remark remarksItem) {
    this.remarks.add(remarksItem);
    return this;
  }

   /**
   * Remarks which should be visible for the customer
   * @return remarks
  **/
  @ApiModelProperty(value = "Remarks which should be visible for the customer")
  public List<Remark> getRemarks() {
    return remarks;
  }

  public void setRemarks(List<Remark> remarks) {
    this.remarks = remarks;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GetActivityPriceDetailsRS getActivityPriceDetailsRS = (GetActivityPriceDetailsRS) o;
    return Objects.equals(this.statusCode, getActivityPriceDetailsRS.statusCode) &&
        Objects.equals(this.msg, getActivityPriceDetailsRS.msg) &&
        Objects.equals(this.systemTime, getActivityPriceDetailsRS.systemTime) &&
        Objects.equals(this.cancellationCosts, getActivityPriceDetailsRS.cancellationCosts) &&
        Objects.equals(this.remarks, getActivityPriceDetailsRS.remarks);
  }

  @Override
  public int hashCode() {
    return Objects.hash(statusCode, msg, systemTime, cancellationCosts, remarks);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetActivityPriceDetailsRS {\n");
    
    sb.append("    statusCode: ").append(toIndentedString(statusCode)).append("\n");
    sb.append("    msg: ").append(toIndentedString(msg)).append("\n");
    sb.append("    systemTime: ").append(toIndentedString(systemTime)).append("\n");
    sb.append("    cancellationCosts: ").append(toIndentedString(cancellationCosts)).append("\n");
    sb.append("    remarks: ").append(toIndentedString(remarks)).append("\n");
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
