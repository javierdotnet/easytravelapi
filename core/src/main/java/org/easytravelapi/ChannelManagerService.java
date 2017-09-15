package org.easytravelapi;


import io.swagger.annotations.Api;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiParam;
import org.easytravelapi.channelManager.*;

import javax.jws.WebService;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by miguel on 26/7/17.
 */
@WebService
@Path("{authtoken}/channel")
@Produces(MediaType.APPLICATION_JSON)
@Consumes({MediaType.APPLICATION_JSON, MediaType.APPLICATION_FORM_URLENCODED, MediaType.MULTIPART_FORM_DATA})
@Api(description = "Operations related to the channel manager service")
public interface ChannelManagerService {

    @POST
    @Path("/granted")
    @ApiOperation(value = "Use this method to know which hotels are you allowed to update. It provides the ids to be used by the channel manager")
    public GetGrantedHotelsRS getGrantedHotels(
            @ApiParam(value = "Auth token provided by your partner, and possibly renewed by using the /commons/newtoken method") @PathParam("authtoken") String token
    );

    @PUT
    @Path("/hotel/inventory")
    @ApiOperation(value = "Use this method to update hotel inventory")
    public UpdateRS update(
            @ApiParam(value = "Auth token provided by your partner, and possibly renewed by using the /commons/newtoken method") @PathParam("authtoken") String token,
            @ApiParam(value = "List of operations you want to perform on hote inventories")
            @FormParam("operations") List<UpdateOperation> operations
    );

    @POST
    @Path("/confirm")
    @ApiOperation(value = "Use this method to confirm or reject services")
    public ConfirmServicesRS confirmServices(
            @ApiParam(value = "Auth token provided by your partner, and possibly renewed by using the /commons/newtoken method") @PathParam("authtoken") String token,
            @ApiParam(value = "List of service confirmations (or rejections)")
            @FormParam("serviceconfirmations") List<ServiceConfirmation> serviceConfirmations

    );

    @GET
    @Path("/roominglist")
    @ApiOperation(value = "Use this method to download the list of hotel bookings")
    public GetRoomingListRS getRoomingList(
            @ApiParam(value = "Auth token provided by your partner, and possibly renewed by using the /commons/newtoken method") @PathParam("authtoken") String token,
            @ApiParam(value = "Starting date you want service bookings confirmed from. In YYYYMMDD format")
            @QueryParam("confirmedfrom") int fromConfirmationDate,
            @ApiParam(value = "Ending date you want service bookings confirmed to. In YYYYMMDD format")
            @QueryParam("confirmedto") int toConfirmationDate,
            @ApiParam(value = "Starting date you want service bookings starting from. In YYYYMMDD format")
            @QueryParam("startingfrom") int fromStartDate,
            @ApiParam(value = "Ending date you want service bookings starting from. In YYYYMMDD format")
            @QueryParam("startingto") int toStartDate
    );
}
