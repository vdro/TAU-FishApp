package vdro.tau.fish.service;

import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;
import java.sql.SQLException;
import java.util.List;
import java.util.Map;

public interface FishServiceManager {

    int create(Fish fish) throws IllegalStateException;
    List<Fish> getAll();
    Fish get(int Id) throws SQLException;

    Map<Integer, Fish> readAll();

    Fish read(int Id) throws NoSuchObjectException;

    int update(Fish fish) throws SQLException, NoSuchObjectException;
    Integer delete(Long Id) throws SQLException;

    void delete(int Id) throws NoSuchObjectException;
}