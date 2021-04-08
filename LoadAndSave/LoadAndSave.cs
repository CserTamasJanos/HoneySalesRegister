using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DataLoadAndSave
{
    public enum ErrorMessages
    {
        ServerConnection = 1,
        PersonDownload = 2,
        HoneyTypesDownload = 3,
        PersonSave = 4,
        HoneyPaymentSave = 5,
        HoneyHarwestSave = 6,
        ActualHarwestYears = 7,
        ActualSalesYears = 8,
        HoneyTypesForSales = 9,
        HoneyTypesForHarwest = 10,
        HoneySalesAllTypesDownload = 11,
        HoneyHarwestAllTypesDownload = 12,
        DatabaseConnection = 13,
        DatabaseTableCheckConnection = 14,
    }

    public class DataLoadAndSave
    {
        public delegate void ErrorMessage(string ErrorText);
        public static event ErrorMessage ErrorMessageEvent;

        private const string Database = "yourDatabaseName";

        private static List<Person> personData = new List<Person>();
        private static List<HoneyType> honeyTypes = new List<HoneyType>();

        public static List<Person> PersonData { get { return personData; } }
        public static List<HoneyType> HoneyTypes { get { return honeyTypes; } }

        #region Helpers
        public static MySqlConnection ConnectionMaker(bool check)
        {

            if(check)
            {
                return new MySqlConnection(ConfigurationManager.ConnectionStrings["DatabaseCheckConnection"].ConnectionString);
            }
            else
            {
                return new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            }
        }

        public static string ErrorMessageText(ErrorMessages selectedQuery, string exceptionMessage)
        {
            string errorText = String.Empty;

            switch (selectedQuery)
            {
                case ErrorMessages.ServerConnection:
                    errorText = SQLErrorText.ServerConnectionErrorText;
                    break;
                case ErrorMessages.PersonDownload:
                    errorText = SQLErrorText.PersonDownloadErrorText;
                    break;
                case ErrorMessages.HoneyTypesDownload:
                    errorText = SQLErrorText.HoneyTypesDownloadErrorText;
                    break;
                case ErrorMessages.PersonSave:
                    errorText = SQLErrorText.PersonSaveErrorText;
                    break;
                case ErrorMessages.HoneyPaymentSave:
                    errorText = SQLErrorText.HoneyPaymentSaveErrorText;
                    break;
                case ErrorMessages.HoneyHarwestSave:
                    errorText = SQLErrorText.HoneyHarwestSaveErrorText;
                    break;
                case ErrorMessages.ActualHarwestYears:
                    errorText = SQLErrorText.ActualHarwestYearsErrorText;
                    break;
                case ErrorMessages.ActualSalesYears:
                    errorText = SQLErrorText.ActualSalesYearsErrorText;
                    break;
                case ErrorMessages.HoneyTypesForSales:
                    errorText = SQLErrorText.HoneyTypesForSalesErrorText;
                    break;
                case ErrorMessages.HoneyTypesForHarwest:
                    errorText = SQLErrorText.HoneyTypesForHarwestErrorText;
                    break;
                case ErrorMessages.HoneySalesAllTypesDownload:
                    errorText = SQLErrorText.HoneySalesAllTypesDownloadErrorText;
                    break;
                case ErrorMessages.HoneyHarwestAllTypesDownload:
                    errorText = SQLErrorText.HoneyHarwestAllTypesDownloadErrorText;
                    break;
                case ErrorMessages.DatabaseConnection:
                    errorText = SQLErrorText.DatabaseCheckConnectionErrortext;
                    break;

            }
            return errorText + Environment.NewLine + exceptionMessage;
        }
        #endregion

        #region SQLoperations

        public static int DatabaseCheck()
        {
            MySqlConnection connection = ConnectionMaker(true);
            int result = -1;

            try
            {
                using (MySqlCommand command = new MySqlCommand(SQLQueries.DatabaseExists, connection))
                {
                    command.Parameters.Add("@DatabaseName", MySqlDbType.Text);
                    command.Parameters[0].Value = Database;

                    connection.Open();

                    result = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.DatabaseConnection, a.Message));
            }
            return result;
        }

        public static int TableCheck(int table)
        {
            Dictionary<int, string> tableNames = new Dictionary<int, string>()
                {{0,"persons"},{1,"honeytypes"},{2,"honeyharwest"},{3,"honeypayment"}};

            MySqlConnection connection = ConnectionMaker(false);
            int result = -1;

            try
            {
                using (MySqlCommand command = new MySqlCommand(SQLQueries.TableExist, connection))
                {
                    command.Parameters.Add("@DatabaseName", MySqlDbType.Text);
                    command.Parameters[0].Value = Database;

                    command.Parameters.Add("@TableName", MySqlDbType.Text);
                    command.Parameters[1].Value = tableNames[table];

                    connection.Open();

                    result = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.DatabaseTableCheckConnection, a.Message));
            }
            return result;
        }

        public static bool SQLPersonDownload()
        {
            personData.Clear();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand (SQLQueries.PersonDownload, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    personData.Add(new Person(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                }

                connection.Close();
            }
            catch(Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.PersonDownload, a.Message));
                return false;
            }
            return true;
        }

        public static bool SQLHoneyTypesDownload()
        {
            honeyTypes.Clear();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(SQLQueries.HoneyTypesDownload, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    honeyTypes.Add(new HoneyType(Convert.ToInt32(reader[0]), reader[1].ToString()));
                }

                connection.Close();
            }
            catch(Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneyTypesDownload, a.Message));
                return false;
            }
            return true;
        }

        public static bool SQLPersonSave(string Firstname, string SecondName, string PersonLocation)
        {
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(SQLQueries.PersonSave, connection);
                connection.Open();

                command.Parameters.Add("@FirstName", MySqlDbType.Text);
                command.Parameters[0].Value = Firstname;

                command.Parameters.Add("@SecondName", MySqlDbType.Text);
                command.Parameters[1].Value = SecondName;

                command.Parameters.Add("@PersonLocation", MySqlDbType.Text);
                command.Parameters[2].Value = PersonLocation;

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.PersonSave, a.Message));
                return false;
            }
            return true;
        }

        public static bool SQLHoneyPaymentSave(int PersonID, int HoneyTypeID, int SellingAmount,
                                               int SellingPrice, DateTime SellingDate, int Present)
        {
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(SQLQueries.HoneyPayentSave, connection);
                connection.Open();

                command.Parameters.Add("@PersonID", MySqlDbType.Int32);
                command.Parameters[0].Value = PersonID;

                command.Parameters.Add("@HoneyTypeID", MySqlDbType.Int32);
                command.Parameters[1].Value = HoneyTypeID;

                command.Parameters.Add("@SellingAmount", MySqlDbType.Int32);
                command.Parameters[2].Value = SellingAmount;

                command.Parameters.Add("@SellingPrice", MySqlDbType.Int32);
                command.Parameters[3].Value = SellingPrice;

                command.Parameters.Add("@SellingDate", MySqlDbType.DateTime);
                command.Parameters[4].Value = SellingDate;

                command.Parameters.Add("@Present", MySqlDbType.Int32);
                command.Parameters[5].Value = Present;

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneyPaymentSave, a.Message));
                return false;
            }
            return true;
        }

        public static bool SQLHoneyHarwestSave(int HoneyTypeID, DateTime HoneyHarwestDateTime, string HoneyHarwestLocation,
                                               int HoneyHarwestAmount)
        {
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(SQLQueries.HoneyHarwestSave, connection);
                connection.Open();

                command.Parameters.Add("@HoneyTypeID", MySqlDbType.Int32);
                command.Parameters[0].Value = HoneyTypeID;

                command.Parameters.Add("@HoneyHarwestDateTime", MySqlDbType.DateTime);
                command.Parameters[1].Value = HoneyHarwestDateTime;

                command.Parameters.Add("@HoneyHarwestLocation", MySqlDbType.Text);
                command.Parameters[2].Value = HoneyHarwestLocation;

                command.Parameters.Add("@HoneyHarwestAmount", MySqlDbType.Int32);
                command.Parameters[3].Value = HoneyHarwestAmount;

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneyHarwestSave, a.Message));
                return false;
            }
            return true;
        }

        public static bool ActualHarwestYears(int selectedHoneyTypeID, out List<int> harwestYears)
        {
            harwestYears = new List<int>();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(string.Format(SQLQueries.YearHarwHappAll, (selectedHoneyTypeID == 0 ? "" :
                    string.Format(SQLQueries.YearHarwHappByHoneyType, selectedHoneyTypeID))), connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    harwestYears.Add(Convert.ToInt32(reader[0]));
                }

                connection.Close();
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.ActualHarwestYears, a.Message));
                return false;
            }
            return true;
        }

        public static bool ActualSalesYears(int selectedPersonID, int selectedHoneyTypeID, int present, out List<int> years)
        {
            years = new List<int>();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(YearQueryForActualSalesYears(selectedPersonID,
                    selectedHoneyTypeID,present), connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    years.Add(Convert.ToInt32(reader[0]));
                }

                connection.Close();
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.ActualSalesYears, a.Message));
                return false;
            }
            return true;
        }

        public static bool HoneyTypesForSales(int personID, int present, out List<int> honeyTypeIDs)
        {
            honeyTypeIDs = new List<int>();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(HoneyTypeQueryForPayments(personID,present), connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    honeyTypeIDs.Add(Convert.ToInt32(reader[0]));
                }

                connection.Close();
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneyTypesForSales, a.Message));
                return false;
            }
            return true;
        }

        public static bool HoneyTypesForHarwest(out List<int> honeyTypeIDs)
        {
            honeyTypeIDs = new List<int>();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(SQLQueries.HoneyTypeForHarwest, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    honeyTypeIDs.Add(Convert.ToInt32(reader[0]));
                }

                connection.Close();
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneyTypesForHarwest, a.Message));
                return false;
            }
            return true;
        }
        public static bool HoneySalesAllTypesDownload(int personID, int honeyTypeId, int selectedYear,
                                                 int present, out List<HoneyPayment> actualPayments)
        {
            actualPayments = new List<HoneyPayment>();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(HPQueryForPayments(personID, honeyTypeId, selectedYear, present), connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    actualPayments.Add(new HoneyPayment(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                        Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]),
                           Convert.ToDateTime(reader[5]), Convert.ToInt32(reader[6])));
                }

                connection.Close();
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneySalesAllTypesDownload, a.Message));
                return false;
            }
            return true;
        }

        public static List<int> PersonIDBoughtHoneyList(int presentInt)
        {
            List<HoneyPayment> honeyPayments = new List<HoneyPayment>();
            HoneySalesAllTypesDownload(0, 0, 0, presentInt, out honeyPayments);
            return honeyPayments.Select(x => x.PersonID).Distinct().ToList();
        }

        public static bool HoneyHarwestAllTypesDownload(int selectedHoneyTypeID, int selectedYear, out List<HoneyHarwest> actualHarwest)
        {
            actualHarwest = new List<HoneyHarwest>();
            MySqlConnection connection = ConnectionMaker(false);

            try
            {
                MySqlCommand command = new MySqlCommand(QueriesForHarwest(selectedHoneyTypeID, selectedYear), connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    actualHarwest.Add(new HoneyHarwest(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                        Convert.ToDateTime(reader[2]), reader[3].ToString(), Convert.ToInt32(reader[4])));
                }

                connection.Close();
            }
            catch (Exception a)
            {
                if (ErrorMessageEvent != null)
                    ErrorMessageEvent.Invoke(ErrorMessageText(ErrorMessages.HoneyHarwestAllTypesDownload, a.Message));
                return false;
            }
            return true;
        }
        #endregion

        #region QueryBuilders
        private static string HoneyTypeQueryForPayments(int personID, int present)
        {
            string honeyType = SQLQueries.HoneyTypeQForPaymentsAll + string.Format(SQLQueries.WherePresent, present);

            if(personID > 0)
            {
                honeyType += string.Format(SQLQueries.ByPerson,personID);
            }
            honeyType += SQLQueries.EndCharacter;
            return honeyType;
        }

        private static string YearQueryForActualSalesYears(int selectedPersonID, int selectedHoneyTypeID, int present)
        {
            string years = SQLQueries.YearQForActualYaersAll + string.Format(SQLQueries.WherePresent, present);

            if (selectedPersonID > 0)
            {
                years += string.Format(SQLQueries.ByPerson,selectedPersonID);
            }
            if (selectedHoneyTypeID > 0)
            {
                years += string.Format(SQLQueries.ByHoneyType,selectedHoneyTypeID);
            }
            years += SQLQueries.EndCharacter;

            return years;
        }

        private static string HPQueryForPayments(int personID, int honeyTypeId, int selectedYear, int present)
        {
            string paymentQuery = SQLQueries.HPQueryForPaymentsAll + string.Format(SQLQueries.WherePresent,present);
                
            if(personID > 0)
            {
                paymentQuery += string.Format(SQLQueries.ByPerson,personID);
            }
            if(honeyTypeId > 0)
            {
                paymentQuery += string.Format(SQLQueries.ByHoneyType,honeyTypeId);
            }
            if(selectedYear > 0)
            {
                paymentQuery += string.Format(SQLQueries.ByYearOfSelling,selectedYear);
            }
            paymentQuery += SQLQueries.EndCharacter;

            return paymentQuery;
        }

        private static string QueriesForHarwest(int honeyTypeId, int selectedYear)
        {
            string honeyHarwestQuery = SQLQueries.QForHarwestAll;
                
            if(honeyTypeId > 0 && selectedYear > 0)
            {
                honeyHarwestQuery += string.Format(SQLQueries.QFOrHarwestWhereHoneyType,honeyTypeId) + string.Format(SQLQueries.QForHarwestYear,selectedYear);
            }
            else if (honeyTypeId > 0)
            {
                honeyHarwestQuery += string.Format(SQLQueries.QFOrHarwestWhereHoneyType,honeyTypeId);
            }
            else if (selectedYear > 0)
            {
                honeyHarwestQuery += string.Format(SQLQueries.QForHarwestWhereYear,selectedYear);
            }
            honeyHarwestQuery += SQLQueries.EndCharacter;

            return honeyHarwestQuery;
        }
        #endregion
    }
}
