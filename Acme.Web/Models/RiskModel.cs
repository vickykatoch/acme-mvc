using Acme.Domain;
using Heroic.AutoMapper;
using System;

namespace Acme.Web.Models
{
    public class RiskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CustomerId { get; set; }
    }
}