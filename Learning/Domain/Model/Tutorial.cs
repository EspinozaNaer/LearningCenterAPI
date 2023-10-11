using Org.BouncyCastle.Asn1.X509;
using System.ComponentModel;

namespace LearningCenter.API.Learning.Domain.Model
{
    public class Tutorial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
