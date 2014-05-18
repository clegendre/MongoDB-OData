using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using NUnit.Framework;

namespace RankingSystem.Tests
{
    [TestFixture]
    public class DSPEntities
    {
        [Test]
        public void InitializeDatabase_ThenRequest()
        {
            var settings = new MongoServerSettings { ConnectionMode = ConnectionMode.Automatic };
            var server = new MongoServer( settings );
            var dbSettings = new MongoDatabaseSettings();

            //.Create( @"mongodb://localhost/RankingSystem" )
            MongoDatabase ctx =  new MongoDatabase( server, "RankingSystem", dbSettings );
            Assert.That( ctx.CollectionExists( "Dealer" ) );
            var dealers = ctx.GetCollection<DSPDealer>( "Dealer" );
            Console.Out.WriteLine( dealers.Count() );
        }

        void ProcessingPipeline_ProcessingRequest( object sender, System.Data.Services.DataServiceProcessingPipelineEventArgs e )
        {

        }
    }
}
