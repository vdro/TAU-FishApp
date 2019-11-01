package vdro.tau.fish.service;

import org.junit.Test;
import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;

import static org.junit.Assert.*;
import static org.mockito.Mockito.*;


public class FishTrackedImplTest {


    @Test
    public void StoringReadInformation() throws NoSuchObjectException {

        //arrange
        int testId = 1;
        String Label = "Fish label";
        String Name = "Fish name";
        String Description = "Fish description";
        int CategoryId = 0;
        int Quantity = 1;
        float NetPrice =  100.0f;
        float GrossPrice = 123.0f;
        boolean FakeFish = false;
        Fish fish = new Fish(testId, Label, Name, Description, CategoryId, Quantity, NetPrice, GrossPrice, FakeFish);

        FishServiceManager realFishServiceMock = mock(FishImpl.class);
        RecordAccessManager accessManagerMock = mock(RecordAccessManager.class);
        FishServiceManager SUT = new FishTrackedImpl(realFishServiceMock, accessManagerMock);

        when(realFishServiceMock.read(1)).thenReturn(fish);

        //act
        Fish readFish = SUT.read(1);

        //assert
        assertEquals(fish.getId(), readFish.getId());
        assertEquals(fish.getLabel(), readFish.getLabel());
        verify(accessManagerMock, times(1)).StoreRead(1);

    }

    @Test
    public void otherTest(){

    }
}
