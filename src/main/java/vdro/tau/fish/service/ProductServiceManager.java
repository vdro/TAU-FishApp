package vdro.tau.fish.service;
import vdro.tau.fish.domain.Product;
import java.rmi.NoSuchObjectException;
import java.util.Map;

public interface ProductServiceManager {

    void create(Product product);
    Map<Integer, Product> readAll();
    Product read(int Id) throws NoSuchObjectException;
    void update(Product product) throws NoSuchObjectException;
    void delete(int Id) throws NoSuchObjectException;
}
