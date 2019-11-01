package vdro.tau.fish.service;

import vdro.tau.fish.domain.Fish;

import java.util.Date;

public class EntryRecord {
    public AccessType accessType;
    public Date accessDate;
    public Fish record;
    public int Id;

    public EntryRecord(AccessType access, Date date, Fish fish) {
        accessType = access;
        accessDate =date;
        record = fish;
    }


    public EntryRecord(AccessType access, Date date, int id) {
        accessType = access;
        accessDate =date;
        Id = id;
    }
    //....
}

