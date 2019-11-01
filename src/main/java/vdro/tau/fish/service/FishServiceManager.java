package vdro.tau.fish.service;
import vdro.tau.fish.domain.Fish;
import java.rmi.NoSuchObjectException;
import java.util.Map;

public interface FishServiceManager {

    void create(Fish product);
    Map<Integer, Fish> readAll();
    Fish read(int Id) throws NoSuchObjectException;
    void update(Fish product) throws NoSuchObjectException;
    void delete(int Id) throws NoSuchObjectException;
}