using System.Collections.Generic;
using ZeissTest.Business.Dto;

namespace ZeissTest.Business.IService
{
    public interface IMachineService
    {
        void SaveMachineData(MachineDto machine);
        //void SaveMachineDataHistory(MachineHistoryDto machineHistory);
        IList<MachineDto> GetAllMachines();
        MachineDto GetMachineById(string machineId);
        string GetMachineStatus(string machineId);
    }
}
