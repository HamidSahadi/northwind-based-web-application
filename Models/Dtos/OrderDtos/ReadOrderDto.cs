﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NorthwindBasedWebApplication.Models.Dtos.EmployeeDtos;
using NorthwindBasedWebApplication.Models.Dtos.ShipperDtos;
using NorthwindBasedWebApplication.Models.Dtos.CustomerDtos;
using NorthwindBasedWebApplication.Models.Dtos.OrderDetailsDto;


namespace NorthwindBasedWebApplication.Models.Dtos.OrderDtos
{
    public class ReadOrderDto
    {

        [Display(Name = "Id")]
        public int Id { get; set; }



        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }



        [Display(Name = "Required Date")]
        public DateTime RequiredDate { get; set; }



        [Display(Name = "Shipped Date")]
        public DateTime? ShippedDate { get; set; }



 
        [Display(Name = "Freight")]
        public decimal Freight { get; set; }



    
        [Display(Name = "Ship Name")]
        public string ShipName { get; set; }




        [Display(Name = "Shipped Address")]
        public string ShipAddress { get; set; }



       
        [Display(Name = "Ship City")]
        public string ShipCity { get; set; }



        [Display(Name = "Ship Region")]
        public string? ShipRegion { get; set; }


        [Display(Name = "Ship Postal Code")]
        public string? ShipPostalCode { get; set; }



    
        [Display(Name = "Ship Country")]
        public string ShipCountry { get; set; }


        [Display(Name = "Picture")]
        public string? PictureUrl { get; set; }



        //Navigation Properties

        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        public ReadEmployeeDto EmployeeDto { get; set; }



        [Display(Name = "Ship Via")]

        public int ShipVia { get; set; }
        public ReadShipperDto ShipperDto { get; set; }




        [Display(Name = "Customer Id")]

        public int CustomerId { get; set; }
        public ReadCustomerDto CustomerDto { get; set; }


        public ICollection<ReadOrderDetailsDto> OrderDetailsDto { get; set; }
    }
}
