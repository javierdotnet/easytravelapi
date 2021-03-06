package org.easytravelapi.cms;

import io.swagger.annotations.ApiModel;

import java.util.ArrayList;
import java.util.List;

@ApiModel(description = "A calendar month")
public class HotelAvailabilityCalendarMonth {

    private String title;

    private int year;

    private int month;

    private List<HotelAvailabilityCalendarWeek> weeks = new ArrayList<HotelAvailabilityCalendarWeek>();


    public HotelAvailabilityCalendarMonth() {

    }

    public HotelAvailabilityCalendarMonth(String title, int year, int month) {
        this.title = title;
        this.year = year;
        this.month = month;
    }


    public List<HotelAvailabilityCalendarWeek> getWeeks() {
        return weeks;
    }

    public void setWeeks(List<HotelAvailabilityCalendarWeek> weeks) {
        this.weeks = weeks;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public int getMonth() {
        return month;
    }

    public void setMonth(int month) {
        this.month = month;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }
}
