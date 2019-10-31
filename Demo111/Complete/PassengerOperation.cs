using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrainTK;

namespace Demo111
{
    class PassengerOperation
    {
        public static List<Passenger> getAllPassenger(string userName)
        {
            string sql =
                "SELECT personID,personName,IDType,IDNum,phoneNum,passengerType FROM Contacts WHERE userName='" +
            userName+"'";
            List<Passenger> passengers=new List<Passenger>();
            DataTable dt=new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Count; i++)
            {
                Passenger passenger=new Passenger();
                passenger.PersonID = (int)dt.DefaultView.Table.Rows[i][0];
                passenger.PersonName = dt.DefaultView.Table.Rows[i][1].ToString();
                passenger.IDType = dt.DefaultView.Table.Rows[i][2].ToString();
                passenger.IDNum = dt.DefaultView.Table.Rows[i][3].ToString();
                //passengers[i].Sex = dt.DefaultView.Table.Rows[i][4].ToString();
                passenger.PhoneNum = dt.DefaultView.Table.Rows[i][4].ToString();
                //passengers[i].TelePhone = dt.DefaultView.Table.Rows[i][6].ToString();
                //passengers[i].Email = dt.DefaultView.Table.Rows[i][7].ToString();
                //passengers[i].Address = dt.DefaultView.Table.Rows[i][8].ToString();
                //passengers[i].PostCode = dt.DefaultView.Table.Rows[i][9].ToString();
                passenger.PassengerType = dt.DefaultView.Table.Rows[i][5].ToString();
                //passengers[i].AddDate = (DateTime)dt.DefaultView.Table.Rows[i][11];
                //passengers[i].UserName = dt.DefaultView.Table.Rows[i][12].ToString();
                //passengers[i].Country = dt.DefaultView.Table.Rows[i][13].ToString();
                passengers.Add(passenger);
            }
            return passengers;
        }

        public static Passenger GetPassenger(string userName, string personName)
        {
            Passenger passenger=new Passenger();

            string sql =
                "SELECT personID,personName,IDType,IDNum,phoneNum,passengerType FROM Contacts WHERE userName='" + userName + "' and personName='"+personName+"'";
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Count; i++)
            {
                passenger.PersonID = (int)dt.DefaultView.Table.Rows[i][0];
                passenger.PersonName = dt.DefaultView.Table.Rows[i][1].ToString();
                passenger.IDType = dt.DefaultView.Table.Rows[i][2].ToString();
                passenger.IDNum = dt.DefaultView.Table.Rows[i][3].ToString();
                passenger.PhoneNum = dt.DefaultView.Table.Rows[i][4].ToString();
                passenger.PassengerType = dt.DefaultView.Table.Rows[i][5].ToString();
            }
            return passenger;
        }

        public static int DeletePassenger(string userName, string personName)
        {
            string sql =
                "DELETE FROM Contacts WHERE userName='"+userName+"' AND personName='" + personName + "'";
            return SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
