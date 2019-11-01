package vdro.tau.fish.service;
import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

class FishTrackedImpl implements FishServiceManager {

    private final RecordAccessManager recordAccessManager;
    private final FishServiceManager realFishServiceManager;


    public FishTrackedImpl(FishServiceManager serviceManager, RecordAccessManager recordAccessManager){
        this.realFishServiceManager = serviceManager;
        this.recordAccessManager = recordAccessManager;
    }

    @Override
    public void create(Fish fish) {
        recordAccessManager.StoreCreate(fish);
        realFishServiceManager.create(fish);
    }

    @Override
    public Fish read(int Id) throws NoSuchObjectException {
        recordAccessManager.StoreRead(Id);
        return realFishServiceManager.read(Id);
    }

    @Override
    public void update(Fish fish) throws NoSuchObjectException {
        recordAccessManager.StoreWrite(fish);
        realFishServiceManager.update(fish);
    }

    @Override
    public void delete(int Id) throws NoSuchObjectException {
        realFishServiceManager.delete(Id);
    }

    @Override
    public Map<Integer, Fish> readAll() {
        return realFishServiceManager.readAll();
    }

}

