﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ZeissTest.Business.Dto;
using ZeissTest.Business.IService;
using ZeissTest.Data;
using ZeissTest.Data.Entities;

namespace ZeissTest.Business.Service
{
    public class MachineService : IMachineService
    {
        private readonly ZeissTestDatabaseContext _context;
        private readonly IMapper _mapper;

        public MachineService(
            ZeissTestDatabaseContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<MachineDto> GetAllMachines()
        {
            return _mapper.Map<IList<MachineDto>>(_context.Machine.AsNoTracking().ToList());
        }

        public MachineDto GetMachineById(string machineId)
        {
            return _mapper.Map<MachineDto>(_context.Machine.FirstOrDefault(m => m.MachineId == machineId));
        }

        public string GetMachineStatus(string machineId)
        {
            return _context.Machine.Where(m => m.MachineId == machineId).Select(m => m.Status.ToString()).FirstOrDefault();
        }

        public void SaveMachineData(MachineDto machine)
        {
            var existedMachine = _context.Machine.FirstOrDefault(m => m.MachineId == machine.MachineId);

            if (existedMachine != null)
            {
                existedMachine = _mapper.Map(machine, existedMachine);
            }
            else
            {
                _context.Machine.Add(_mapper.Map<Machine>(machine));
            }

            _context.SaveChanges();
        }

        //public void SaveMachineDataHistory(MachineHistoryDto machineHistory)
        //{
        //    _context.MachineHistory.Add(_mapper.Map<MachineHistory>(machineHistory));
        //    _context.SaveChanges();
        //}
    }
}
