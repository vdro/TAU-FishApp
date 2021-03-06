package vdro.tau.fish.domain;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.JUnit4;
import static org.junit.Assert.*;

@RunWith(JUnit4.class)
public class FishTest {

@Test
public void fishIsImplementedTest() {
        assertNotNull(new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This Fish has been created in test class",
                1,
                1,
                1.20f,
                1.60f,
                true
        ));
}

        @Test(expected = IllegalArgumentException.class)
        public void fishIdArgumentShouldAcceptOnlyPositiveNumberTest(){
                new Fish(
                        -1,
                        "TEST_Fish",
                        "Test Fish",
                        "This fish has been created in test class",
                        1,
                        1,
                        1.20f,
                        1.60f,
                        true
                );
        }
        @Test(expected = IllegalArgumentException.class)
        public void FishCategoryIdArgumentShouldAcceptOnlyPositiveNumberTest(){
                new Fish(
                        1,
                        "TEST_Fish",
                        "Test Fish",
                        "This fish has been created in test class",
                        -1,
                        1,
                        1.20f,
                        1.60f,
                        true
                );
        }
        @Test(expected = IllegalArgumentException.class)
        public void fishQuantityArgumentShouldAcceptOnlyPositiveNumberTest(){
                new Fish(
                        1,
                        "TEST_Fish",
                        "Test Fish",
                        "This fish has been created in test class",
                        1,
                        -1,
                        1.20f,
                        1.60f,
                        true
                );
        }

    @Test(expected = IllegalArgumentException.class)
    public void fishNetPriceArgumentShouldAcceptOnlyPositiveNumberTest(){
        new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                -1.20f,
                1.60f,
                true
        );
    }
    @Test(expected = IllegalArgumentException.class)
    public void fishGrossPriceArgumentShouldAcceptOnlyPositiveNumberTest(){
        new Fish(
                1,
                "TEST_Fish",
                "Test Fish",
                "This fish has been created in test class",
                1,
                1,
                1.20f,
                -1.60f,
                true
        );
    }
        }
