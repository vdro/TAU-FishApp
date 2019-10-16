package vdro.tau.fish.service;
import vdro.tau.fish.domain.Product;

import java.rmi.NoSuchObjectException;
import java.util.HashMap;
import java.util.Map;

public class ProductImpl implements ProductServiceManager {

    private Map<Integer, Product> ProductList = new HashMap<>();

    @Override
    public void create(Product product) {
        if(ProductList.containsKey(product.getId()))
            throw new IllegalArgumentException("Product with Id (" + product.getId() + ")already exists");

        ProductList.put(product.getId(), product);
    }

    @Override
    public Map<Integer, Product> readAll() {
        return ProductList;
    }

    @Override
    public Product read(int Id) throws NoSuchObjectException {
        if(!ProductList.containsKey(Id))
            throw new NoSuchObjectException("Product with Id (" + Id + ") does not exist.");

        return ProductList.get(Id);
    }

    @Override
    public void update(Product product) throws NoSuchObjectException {
        if(!ProductList.containsKey(product.getId()))
            throw new NoSuchObjectException("Product with (" + product.getId() + ") does not exist.");

        ProductList.put(product.getId(), product);
    }

    @Override
    public void delete(int Id) throws NoSuchObjectException {
        if(!ProductList.containsKey(Id))
            throw new NoSuchObjectException("Product with (" + Id + ") does not exist.");

        ProductList.remove(Id);
    }
}

