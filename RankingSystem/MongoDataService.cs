using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq.Expressions;
using Mongo.Context.Queryable;

namespace RankingSystem
{
    public class MongoDataService : MongoQueryableDataService
    {
        public MongoDataService()
            : base( ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString )
        {
        }

        // This method is called only once to initialize service-wide policies.
        public static void InitializeService( DataServiceConfiguration config )
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            config.SetEntitySetAccessRule( "*", EntitySetRights.AllRead );
            config.SetServiceOperationAccessRule( "*", ServiceOperationRights.All );
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
            config.DataServiceBehavior.AcceptCountRequests = true;
            config.DataServiceBehavior.AcceptProjectionRequests = true;
            config.UseVerboseErrors = true;
        }

        protected override void OnStartProcessingRequest( ProcessRequestArgs args )
        {
            base.OnStartProcessingRequest( args );
        }

        protected override void HandleException( HandleExceptionArgs args )
        {
            base.HandleException( args );
        }

        [QueryInterceptor( "Dealer" )]
        public Expression<Func<DSPDealer, bool>> OnQueryDealer()
        {
            return x => true;
        }

    }
}
