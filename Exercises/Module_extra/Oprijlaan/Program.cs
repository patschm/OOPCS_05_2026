using Canon;
using DoomsdayPreppers;
using Heras;
using Philips;
using Yunex;

namespace Oprijlaan;

class Program
{
    static void Main(string[] args)
    {
        var detectielus = new Detectielus();
        var hek = new Hek();
        var valkuil = new Valkuil();
        var lamp = new Lamp();
        var camera = new Camera();

        detectielus.Connect(hek);
        detectielus.Connect(valkuil);
        detectielus.Connect(lamp);
        detectielus.Connect(camera);

        detectielus.HmmmWatZienIkDaar();
        
    }
}
