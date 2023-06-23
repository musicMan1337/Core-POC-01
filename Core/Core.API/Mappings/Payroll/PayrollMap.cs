using AutoMapper;
using Core.API.DTOs.Payroll;
using Core.Domain.Payroll.Entities;

namespace Core.API.Mappings.Payroll;

public class PayrollMap : Profile
{
    public PayrollMap()
    {
        CreateMap<PayrollEntity, PayrollDTO>();
    }
}

