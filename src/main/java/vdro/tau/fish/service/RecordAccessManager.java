package vdro.tau.fish.service;

import vdro.tau.fish.domain.Fish;

import java.util.Date;

public interface RecordAccessManager {
    void StoreCreate(Fish fish);
    void StoreRead(int id);
    void StoreWrite(Fish fish);

    //wlaczanie / wylaczanie
    void enable(AccessType accessType);
    void disable(AccessType accessType);
}

