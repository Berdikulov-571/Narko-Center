﻿namespace NarkoCenter.Domain.Dtos.HospitalNews
{
    public class HospitalNewsUpdateDto
    {
        public int HospitalNewsId { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}