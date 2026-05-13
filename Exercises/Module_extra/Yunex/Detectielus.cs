using Protocollen;

namespace Yunex;

public class Detectielus
{
    private List<IDetect> _devices = new List<IDetect>();   

    public void Connect(IDetect device)
    {
        _devices.Add(device);
    }
    public void HmmmWatZienIkDaar()
    {
        Console.WriteLine("De detectielus detecteert iets");
        foreach (var device in _devices) 
        {
            device.Activate();
        }
    }
}
