using ZeissTest.Business.Dto;

namespace ZeissTest.Business.IService
{
    public interface IMachineWebSocketService
    {
        void RecieveData(MachineWebSocketDto data);
    }
}
