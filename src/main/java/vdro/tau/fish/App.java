package vdro.tau.fish;

import vdro.tau.fish.service.*;

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
        FishServiceManager fishService = new FishTrackedImpl(realService, accessManager);

        //dodanie kilku rybek

        //wybranie rybki

        //wyswietlenie loga

    }
}
