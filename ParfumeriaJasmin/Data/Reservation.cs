﻿namespace ParfumeriaJasmin.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
