﻿namespace NarkoCenter.Domain.Dtos.Services
{
    public class ServiceCreateDto
    {
        public string ServiceName { get; set; } = default!;
        public decimal PriceADay { get; set; } = default!;
        public int HowManyPeopleThisRoom { get; set; } = default!;
        public int DoctorId { get; set; }
        public string IconPath { get; set; }
    }
}