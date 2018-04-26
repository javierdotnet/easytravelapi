package org.easytravelapi.hotel;

import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.easytravelapi.common.AbstractRS;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by miguel on 26/7/17.
 */
@ApiModel(description = "Container for the getavailability response")
public class GetHotelRatesRS extends AbstractRS {

    @ApiModelProperty(value = "List of available hotels, including prices")
    private List<Option> rates = new ArrayList<Option>();

    public List<Option> getRates() {
        return rates;
    }

    public void setRates(List<Option> rates) {
        this.rates = rates;
    }
}
