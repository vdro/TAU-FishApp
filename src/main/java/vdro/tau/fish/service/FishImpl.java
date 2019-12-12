package vdro.tau.fish.service;
import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class FishImpl implements FishServiceManager {

    private static int id;
    private Map<Integer, Fish> FishList = new HashMap<>();

    @Override
    public int create(Fish fish) {
        if(FishList.containsKey(fish.getId()))
            throw new IllegalArgumentException("Fish with Id (" + fish.getId() + ")already exists");

        FishList.put(fish.getId(), fish);
        return 0;
    }

    @Override
    public List<Fish> getAll() {
        return null;
    }

    @Override
    public Fish get(int Id) throws SQLException {
        return null;
    }

    @Override
    public  Map<Integer, Fish> readAll() {
        return FishList;
    }

    @Override
    public  Fish read(int Id) throws NoSuchObjectException {
        id = Id;
        if(!FishList.containsKey(Id))
            throw new NoSuchObjectException("Fish with Id (" + Id + ") does not exist.");

        return FishList.get(Id);
    }

    @Override
    public int update(Fish fish) throws NoSuchObjectException {
        if(!FishList.containsKey(fish.getId()))
            throw new NoSuchObjectException("Fish with (" + fish.getId() + ") does not exist.");

        FishList.put(fish.getId(), fish);
        return 0;
    }

    @Override
    public Integer delete(Long Id) throws SQLException {
        return null;
    }

    @Override
    public void delete(int Id) throws NoSuchObjectException {
        if(!FishList.containsKey(Id))
            throw new NoSuchObjectException("Fish with (" + Id + ") does not exist.");

        FishList.clear();
        //.remove(Id);
    }
}

