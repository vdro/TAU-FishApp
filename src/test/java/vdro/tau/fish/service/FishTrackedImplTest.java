package vdro.tau.fish.service;

import org.junit.Test;
import vdro.tau.fish.domain.Fish;

import java.rmi.NoSuchObjectException;
import java.util.Date;
import java.util.List;

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

        //mocks preparation
        FishServiceManager realFishServiceMock = mock(FishImpl.class);
        when(realFishServiceMock.read(testId)).thenReturn(fish);

        RecordAccessManager accessManagerMock = mock(RecordAccessManager.class);

        // real service under test (using mokcs)
        FishServiceManager SUT = new FishTrackedImpl(realFishServiceMock, accessManagerMock);


        //act
        Fish readFish = SUT.read(1);

        //assert
        verify(realFishServiceMock, times(1)).read(testId);
        verify(accessManagerMock, times(1)).StoreRead(testId);

        assertTrue(fish == readFish);
        assertEquals(fish.getId(), readFish.getId());
        assertEquals(fish.getLabel(), readFish.getLabel());

    }

    @Test
    public void RecordAccessManager_has_no_records_of_ReadWriteCreate_at_the_begining(){
        RecordAccessManagerImpl SUT = new RecordAccessManagerImpl();

        List<EntryRecord> list =  SUT.ReadAll();
        assertTrue(list.isEmpty());
    }

    @Test
    public void RecordAccessManager_contains_number_of_recors_equal_to_Number_of_operations_performed(){
        //arange
        RecordAccessManagerImpl SUT = new RecordAccessManagerImpl();

        int count = 10;
        for(int i=0;i<count;i++) {
            SUT.StoreRead(1);
        }

        List<EntryRecord> list =  SUT.ReadAll();
        assertEquals(count, list.size());
    }

    @Test
    public void RecordAccessManager_does_not_store_records_when_disabled(){
        RecordAccessManagerImpl SUT = new RecordAccessManagerImpl();
        SUT.disable(AccessType.Read);

        SUT.StoreRead(1);

        List<EntryRecord> list =  SUT.ReadAll();
        assertTrue(list.isEmpty());
    }

    @Test
    public void RecordAccessManager_does_not_store_records_after_being_disabled(){
        RecordAccessManagerImpl SUT = new RecordAccessManagerImpl();
        SUT.StoreRead(1);

        SUT.disable(AccessType.Read);   //wylaczenie zapisu o odczycie

        SUT.StoreRead(1);           //ten odczyt nie jest zapisany

        SUT.enable(AccessType.Read);    //ponowne wlacznie zapisu
        SUT.StoreRead(1);           //ten odczyt jest zapisany

        List<EntryRecord> list =  SUT.ReadAll();
        assertEquals(2, list.size());
    }

    @Test
    public void Time_verification(){
        TimeProvider timeProviderMock = mock(TimeProvider.class);
        when(timeProviderMock.Now()).thenReturn(new Date(12345));
//        RecordAccessManagerImpl SUT = new RecordAccessManagerImpl(timeProviderMock);
        RecordAccessManagerImpl SUT = new RecordAccessManagerImpl();

        SUT.StoreRead(1);

        EntryRecord readFact =  SUT.ReadAll().get(0);
        assertEquals(new Date(12345), readFact.accessDate);
    }

}
