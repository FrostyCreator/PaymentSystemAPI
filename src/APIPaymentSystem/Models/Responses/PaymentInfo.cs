﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentSystemAPI.Models.Responses
{
    public class PaymentInfo
    {
        [Key]
        public string SessionId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,5)")]
        public decimal Amount { get; set; }             //  Сумма платежа

        [Required]
        public string Description { get; set; }         //  Назначение

        [Required]
        public DateTime ArrivalTime { get; set; }       //  Время поступления заявки
    }
}