using System;
using AutoMapper;
using ZeissTest.Business.Dto;
using ZeissTest.Business.IService;
using ZeissTest.Common.Enums;

namespace ZeissTest.Business.Service
{
    internal class MachineWebSocketService : IMachineWebSocketService
    {
        private readonly IMachineService _machineService;
        private readonly IMapper _mapper;

        public MachineWebSocketService(
            IMachineService machineService,
            IMapper mapper)
        {
            _machineService = machineService;
            _mapper = mapper;
        }

        public void RecieveData(MachineWebSocketDto data)
        {
            _machineService.SaveMachineData(data.Machine);
        }
    }
}
