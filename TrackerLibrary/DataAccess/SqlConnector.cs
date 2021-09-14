using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess

{

 //   @PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
 //   @PrizePercentage float,
	//@id int=0 output

    public class SqlConnector : IDataConnection
    {
        // TODO: Make the 'CreatePrize' method actually save to the Database.
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information with the 'Id'</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // 'using' statement: As soon as the code gets to the end of the {} brackets, the connection gets destroyed. Thus preventing memory leaks.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
