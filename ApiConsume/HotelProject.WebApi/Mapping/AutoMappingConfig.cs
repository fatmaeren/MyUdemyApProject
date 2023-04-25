using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMappingConfig:Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<AddRoomDto, Room>();
            CreateMap<Room, AddRoomDto>();


            CreateMap<RoomUpdateDto, Room>().ReverseMap();

            
        }
    }
}
