using System;
using System.Threading;
public class Foo {

    private SemaphoreSlim semaphoreSecond = new SemaphoreSlim(0);
    private SemaphoreSlim semaphoreThird = new SemaphoreSlim(0);

    public Foo() {}

    public void First(Action printFirst) {
        // Print first
        printFirst();
        // Signal second to proceed
        semaphoreSecond.Release();
    }

    public void Second(Action printSecond) {
        // Wait for first to complete
        semaphoreSecond.Wait();
        // Print second
        printSecond();
        // Signal third to proceed
        semaphoreThird.Release();
    }

    public void Third(Action printThird) {
        // Wait for second to complete
        semaphoreThird.Wait();
        // Print third
        printThird();
    }
}