package vdro.tau.fish.service;

import vdro.tau.fish.domain.Fish;

import java.sql.SQLException;
import java.util.List;

public interface FishServiceManager {

    Integer create(Fish fish) throws IllegalStateException;
    List<Fish> getAll();
    Fish get(int Id) throws SQLException;
    Integer update(Fish fish) throws SQLException;
    Integer delete(Long Id) throws SQLException;
}