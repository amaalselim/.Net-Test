EventManager eventManager = new EventManager();

eventManager.AddEventHandler(MyEvent);
eventManager.Event();

eventManager.RemoveEventHandler(MyEvent);
eventManager.Event();


static void MyEvent()
{
    Console.WriteLine("Event Handeled");
}

public delegate void EventHandler();
public class EventManager
{
    private EventHandler eventHandler;

    public void AddEventHandler(EventHandler handler)
    {
        eventHandler += handler;
    }

    public void RemoveEventHandler(EventHandler handler)
    {
        eventHandler -= handler;
    }
    public void Event()
    {
        if(eventHandler != null)
        {
            eventHandler.Invoke();
        }
    }
}