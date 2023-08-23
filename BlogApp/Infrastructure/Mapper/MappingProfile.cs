using System;
using AutoMapper;
using Entities.DTos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Entities.DTos;

namespace BlogApp.Infrastructure.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ProductDtoForInsertion, Product>();
			CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
			CreateMap<UserDtoForCreation, IdentityUser>();
			CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();
        }


		
	}
}

