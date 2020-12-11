A simple and strongly typed Signal implementation

## Usage

```
public class Main : MonoBehaviour
{
    void Start()
    {
        SignalHub hub = new SignalHub();
        hub.AddListener<TestSignal>(OnTestSignal);
        hub.Dispatch<TestSignal>(new TestSignal());
    }

    private void OnTestSignal(TestSignal signal)
    {
        Debug.Log(signal.count);
    }
}

public class TestSignal : Signal
{
    public int count = 5;
}
```
