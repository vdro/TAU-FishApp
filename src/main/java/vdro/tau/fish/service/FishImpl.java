package vdro.tau.fish.service;
import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;
import java.util.HashMap;
import java.util.Map;

public class FishImpl implements FishServiceManager {

    private Map<Integer, Fish> FishList = new HashMap<>();

    @Override
    public void create(Fish fish) {
        if(FishList.containsKey(fish.getId()))
            throw new IllegalArgumentException("Fish with Id (" + fish.getId() + ")already exists");

        FishList.put(fish.getId(), fish);
    }

    @Override
    public Map<Integer, Fish> readAll() {
        return FishList;
    }

    @Override
    public Fish read(int Id) throws NoSuchObjectException {
        if(!FishList.containsKey(Id))
            throw new NoSuchObjectException("Fish with Id (" + Id + ") does not exist.");

        return FishList.get(Id);
    }

    @Override
    public void update(Fish fish) throws NoSuchObjectException {
        if(!FishList.containsKey(fish.getId()))
            throw new NoSuchObjectException("Fish with (" + fish.getId() + ") does not exist.");

        FishList.put(fish.getId(), fish);
    }

    @Override
    public void delete(int Id) throws NoSuchObjectException {
        if(!FishList.containsKey(Id))
            throw new NoSuchObjectException("Fish with (" + Id + ") does not exist.");

        FishList.clear();
        //.remove(Id);
    }
}

