package vdro.tau.fish.service;


import vdro.tau.fish.domain.Fish;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class RecordAccessManagerImpl implements AccessManager{
    List<EntryRecord> auditHistory = new ArrayList<EntryRecord>();

    @Override
    public void StoreCreate(Fish fish) {
        EntryRecord creationFact = new EntryRecord(AccessType.Create, new Date(), fish);
        auditHistory.add(creationFact);
    }

    @Override
    public void StoreRead(int id) {
        EntryRecord readFact = new EntryRecord(AccessType.Read, new Date(), id);
        auditHistory.add(readFact);
    }

    @Override
    public void StoreWrite(int id) {
        EntryRecord writeFact = new EntryRecord(AccessType.Write, new Date(), id);
        auditHistory.add(writeFact);
    }

    @Override
    public void StoreWrite(Fish fish) {
        EntryRecord writeFact = new EntryRecord(AccessType.Write, new Date(), fish);
        auditHistory.add(writeFact);
    }

    @Override
    public List<EntryRecord> ReadAll() {
        return auditHistory;
    }
}

