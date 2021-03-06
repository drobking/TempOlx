﻿using System.Collections.Generic;

namespace DTO.Models
{
    public class TovarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public int CategoryId { get; set; }
        public CategoriesDTO Category { get; set; }

        public UserAdditionalInfoDTO UserAdditionalInfo { get; set; }
        public virtual ICollection<Tovar_ImageDTO> Images { get; set; }
    }
}