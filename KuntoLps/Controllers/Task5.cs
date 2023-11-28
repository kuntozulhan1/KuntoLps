namespace KuntoLps.Controllers
{
    public class Task5
    {
        static void Main(string[] args)
        {
            var publisher = new EventPublisher();

            while (true)
            {
                var subscriber = new EventSubscriber(publisher);

                /// <summary>
                /// using dispose method
                /// </summary>
                subscriber.Dispose();
            }

        }
        class EventPublisher
        {
            public event EventHandler MyEvent;
            public void RaiseEvent()
            {
                MyEvent?.Invoke(this, EventArgs.Empty);
            }
        }
        class EventSubscriber : IDisposable
        {
            private readonly EventPublisher _publisher;
            private bool _disposed = false;
            public EventSubscriber(EventPublisher publisher)
            {
                _publisher = publisher;
                _publisher.MyEvent += OnMyEvent;
            }

            private void OnMyEvent(object sender, EventArgs e)
            {
                Console.WriteLine("MyEvent raised");
            }

            protected virtual void Dispose(bool disposing)
            {
                if (_disposed)
                    return;

                if (disposing)
                {
                    _publisher.MyEvent -= OnMyEvent;
                }

                _disposed = true;
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
    }
}
