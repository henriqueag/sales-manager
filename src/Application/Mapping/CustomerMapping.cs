﻿using Application.Dtos.Customer;
using Domain.Entities;

namespace Application.Mapping;

public class CustomerMapping : Profile
{
	public CustomerMapping()
	{
		CreateMap<Customer, CustomerData>();
		CreateMap<Customer, CustomerDetailedData>();
	}
}
