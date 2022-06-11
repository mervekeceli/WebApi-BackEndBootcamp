using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GelAllHotels();

        Hotel GetHotelById(int id);

        Hotel CreateHotel(Hotel hotel);

        Hotel UpdateHotel(Hotel hotel);

        void DeleteHotel(int id);
    }
}
