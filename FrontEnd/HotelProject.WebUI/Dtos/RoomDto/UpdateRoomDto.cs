﻿namespace HotelProject.WebUI.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int ID { get; set; }

        public string RoomImage { get; set; }

        public string RoomNumber { get; set; }

        public int Price { get; set; }

        public string Title { get; set; }

        public string BedCount { get; set; }

        public string BathCount { get; set; }

 

        public string Description { get; set; }
    }
}
