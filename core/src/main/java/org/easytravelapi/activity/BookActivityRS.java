package org.easytravelapi.activity;

import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.easytravelapi.common.AbstractRS;

/**
 * Created by miguel on 26/7/17.
 */
@ApiModel(description = "Response for the activity booking confirmation")
public class BookActivityRS extends AbstractRS {

    @ApiModelProperty(value = "The resultant booking id. You will use it to later cancel the service, if you need to")
    private String bookingId;


    public String getBookingId() {
        return bookingId;
    }

    public void setBookingId(String bookingId) {
        this.bookingId = bookingId;
    }
}
