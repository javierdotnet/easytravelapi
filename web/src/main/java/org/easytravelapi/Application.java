package org.easytravelapi;

import io.swagger.jaxrs.config.BeanConfig;
import org.easytravelapi.implementations.*;

import java.util.HashSet;
import java.util.Set;

public class Application  extends javax.ws.rs.core.Application {

    public Application() {

        System.out.println("hola 4!");

        BeanConfig beanConfig = new BeanConfig();
        beanConfig.setTitle("EasyTravelApi");
        beanConfig.setDescription("API for travel agencies");
        beanConfig.setVersion("0.0.2");
        beanConfig.setSchemes(new String[]{"http"});
        beanConfig.setHost("test.easytravelapi:80");
        beanConfig.setBasePath("/api");
//        beanConfig.classes().add(CommonsService.class);
//        beanConfig.classes().add(ActivityBookingService.class);
        beanConfig.setResourcePackage("org.easytravelapi");
        beanConfig.setScan(true);
    }


    @Override
    public Set<Class<?>> getClasses() {
        Set<Class<?>> s = new HashSet<Class<?>>();
        s.add(CommonsServiceImpl.class);
        s.add(ChannelManagerServiceImpl.class);
        s.add(ActivityBookingServiceImpl.class);
        s.add(HotelBookingServiceImpl.class);
        s.add(TransferBookingServiceImpl.class);

        s.add(io.swagger.jaxrs.listing.ApiListingResource.class);
        s.add(io.swagger.jaxrs.listing.SwaggerSerializers.class);

        return s;
    }
}