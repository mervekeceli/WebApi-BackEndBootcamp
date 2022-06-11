using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    // iş kuralları ekleniyor daha büyük projelerde 
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;


        public HotelManager()
        {
            _hotelRepository = new HotelRepository();
        }


        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }


        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }


        public List<Hotel> GelAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }


        public Hotel GetHotelById(int id)
        {
            if(id > 0)
            {
                return _hotelRepository.GetHotelById(id);
            }

            throw new Exception("Id can not be less than 1");
        }


        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
