package vdro.tau.fish.service;


import vdro.tau.fish.domain.Fish;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;



public class RecordAccessManagerImpl implements AccessManager{
    private TimeProvider timeProvider;
    List<EntryRecord> auditHistory = new ArrayList<EntryRecord>();
    boolean storeCreationFact = true;
    boolean storeReadFact = true;
    boolean storeWriteFact = true;

    public RecordAccessManagerImpl(TimeProvider timeProvider){
        this.timeProvider = timeProvider;
    }

    public RecordAccessManagerImpl(){
        this.timeProvider = new TimeProvider() {
            @Override
            public Date Now() {
                return new Date();
            }
        };
    }

    public void enable(AccessType accessType){
        switch (accessType){
            case Create:
                storeCreationFact = true;
                break;
            case Read:
                storeReadFact = true;
                break;
            case Write:
                storeWriteFact = true;
                break;
        }
    }

    public void disable(AccessType accessType){
        switch (accessType){
            case Create:
                storeCreationFact = false;
                break;
            case Read:
                storeReadFact = false;
                break;
            case Write:
                storeWriteFact = false;
                break;
        }
    }

    @Override
    public void StoreCreate(Fish fish) {
        EntryRecord creationFact = new EntryRecord(AccessType.Create,timeProvider.Now(), fish);
        if(storeCreationFact){
            auditHistory.add(creationFact);
        }
    }

    @Override
    public void StoreRead(int id) {
        EntryRecord readFact = new EntryRecord(AccessType.Read,timeProvider.Now(), id);
        if(storeReadFact) {
            auditHistory.add(readFact);
        }
    }

    @Override
    public void StoreWrite(Fish fish) {
        EntryRecord writeFact = new EntryRecord(AccessType.Write,timeProvider.Now(), fish);
        if(storeCreationFact){
            auditHistory.add(writeFact);
        }
    }

    @Override
    public List<EntryRecord> ReadAll() {
        return auditHistory;
    }
}

