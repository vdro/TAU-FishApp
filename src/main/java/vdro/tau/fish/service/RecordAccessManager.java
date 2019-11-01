package vdro.tau.fish.service;

import vdro.tau.fish.domain.Fish;

public interface RecordAccessManager {
    void StoreCreate(Fish fish);
    void StoreRead(int id);
    void StoreWrite(int id);
    void StoreWrite(Fish fish);
}

