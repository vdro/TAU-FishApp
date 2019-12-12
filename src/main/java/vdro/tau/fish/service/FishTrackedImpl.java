package vdro.tau.fish.service;
import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;
import java.sql.SQLException;
import java.util.Map;

public abstract class FishTrackedImpl implements FishServiceManager {

    private final RecordAccessManager recordAccessManager;
    private final FishServiceManager realFishServiceManager;


    public FishTrackedImpl(FishServiceManager serviceManager, RecordAccessManager recordAccessManager){
        this.realFishServiceManager = serviceManager;
        this.recordAccessManager = recordAccessManager;
    }

    @Override
    public int create(Fish fish) {
        recordAccessManager.StoreCreate(fish);
        realFishServiceManager.create(fish);
        return 0;
    }

    @Override
    public Fish read(int Id) throws NoSuchObjectException {
        recordAccessManager.StoreRead(Id);
        return realFishServiceManager.read(Id);
    }

    @Override
    public int update(Fish fish) throws NoSuchObjectException, SQLException {
        recordAccessManager.StoreWrite(fish);
        realFishServiceManager.update(fish);
        return 0;
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

