package vdro.tau.fish;

import vdro.tau.fish.domain.Fish;
import vdro.tau.fish.service.*;

import java.sql.SQLException;
import java.util.List;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        System.out.println( "Hello World! just a small test" );

        FishServiceManager realService = new FishImpl();
        RecordAccessManager accessManager = new RecordAccessManagerImpl();
        FishServiceManager fishService = new FishTrackedImpl(realService, accessManager) {
            @Override
            public List<Fish> getAll() {
                return null;
            }

            @Override
            public Fish get(int Id) throws SQLException {
                return null;
            }

            @Override
            public Integer delete(Long Id) throws SQLException {
                return null;
            }
        };

        //dodanie kilku rybek

        //wybranie rybki

        //wyswietlenie loga

    }
}
