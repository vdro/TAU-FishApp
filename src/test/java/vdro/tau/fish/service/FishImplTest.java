package vdro.tau.fish.service;
import vdro.tau.fish.domain.Fish;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.JUnit4;

import java.rmi.NoSuchObjectException;
import java.util.HashMap;
import java.util.Map;

import static org.junit.Assert.*;


@RunWith(JUnit4.class)
public class FishImplTest {

    @Test
    public void fishImplIsImplementedTest(){
        assertNotNull(new FishImpl());
    }

    @Test
    public void createFishMethodAddsProductToList(){
        Map<Integer, Fish> testList = new HashMap<>();
        Fish testFish = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This Fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        testList.put(testFish.getId(), testFish);

        FishImpl fishImpl = new FishImpl();
        fishImpl.create(testFish);

        assertEquals(testList, fishImpl.readAll());
    }

    @Test(expected = IllegalArgumentException.class)
    public void createFishMethodShouldAcceptOnlyUniqueIdProducts(){
        Fish testFish1 = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        Fish testFish2 = new Fish(
                1,
                "TEST_Fish2",
                "Test Fish2",
                "This fish has been created in test class",
                3,
                15,
                1.50f,
                1.90f,
                true
        );

        FishImpl fishImpl = new FishImpl();

        fishImpl.create(testFish1);
        fishImpl.create(testFish2);
    }

    @Test(expected = NoSuchObjectException.class)
    public void readFishMethodShouldThrowExceptionWhenProductDoesNotExist() throws NoSuchObjectException {
        Fish testFish1 = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        FishImpl fishImpl = new FishImpl();

        fishImpl.create(testFish1);
        fishImpl.read(200);
    }

    @Test
    public void readFishMethodReturnsExpectedProduct() throws NoSuchObjectException {
        Fish testFish1 = new Fish(
                5,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        FishImpl fishImpl = new FishImpl();
        fishImpl.create(testFish1);

        assertEquals(testFish1, fishImpl.read(5));
    }

    @Test(expected = NoSuchObjectException.class)
    public void updateFishMethodShouldThrowExceptionWhenProductDoesNotExist() throws NoSuchObjectException {
        Fish testFish1 = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        FishImpl fishImpl = new FishImpl();
        fishImpl.create(testFish1);

        Fish testFish2 = new Fish(
                2,
                "TEST_Fish2",
                "Test Fish2",
                "This fish has been created in test class",
                1,
                5,
                1.20f,
                1.60f,
                true
        );

        fishImpl.update(testFish2);
    }

    @Test
    public void updateFishMethodIsRewritingObjectOfSpecifiedKey() throws NoSuchObjectException {
        Fish testFish1 = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        FishImpl fishImpl = new FishImpl();
        fishImpl.create(testFish1);

        Fish testFishUpdated = new Fish(
                1,
                "UPDATED_TEST_Fish",
                "Updated Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.70f,
                1.90f,
                true
        );

        fishImpl.update(testFishUpdated);

        assertNotEquals(fishImpl.read(1), testFish1);
    }

    @Test(expected = NoSuchObjectException.class)
    public void deleteFishMethodShouldThrowExceptionWhenProductDoesNotExist() throws NoSuchObjectException {
        Fish testFish1 = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        FishImpl fishImpl = new FishImpl();

        fishImpl.create(testFish1);
        fishImpl.delete(2);
    }

    @Test(expected = NoSuchObjectException.class)
    public void deleteFishMethodShouldRemoveProductFromList() throws NoSuchObjectException {
        Fish testFish1 = new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        );

        FishImpl fishImpl = new FishImpl();

        fishImpl.create(testFish1);
        fishImpl.delete(1);
        fishImpl.read(1);
    }
}