using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;

namespace RankingSystem
{
    public class DSPDealer
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement( "CERTIFICATE-NUMBER" )]
        public string CertificateNumber { get; set; }
    }
}