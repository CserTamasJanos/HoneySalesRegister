using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoadAndSave
{
    class SQLQueries
    {
        public const string DatabaseExists = @" SELECT COUNT(SCHEMA_NAME) FROM INFORMATION_SCHEMA.SCHEMATA
                                                WHERE SCHEMA_NAME = @DatabaseName ";

        public const string TableExist = @"SELECT COUNT(table_name) FROM information_schema.tables
                                            WHERE table_schema = @DatabaseName 
                                            AND table_name = @TableName";

        public const string PersonDownload = @"SELECT PersonID
                                                     ,FirstName
                                                     ,SecondName
                                                     ,PersonLocation
                                                     FROM persons
                                                     ORDER BY FirstName";

        public const string HoneyTypesDownload = @"SELECT HoneyID, HoneyType FROM honeytypes
                                                        ORDER BY HoneyType";

        public const string HoneyPaymentDownload = @"SELECT PaymentID
                                                          ,PersonID
                                                          ,HoneyTypeID
                                                          ,SellingAmount
                                                          ,SellingPrice
                                                          ,SellingDate
                                                          ,Present
                                                          FROM honeypayment";

        public const string HoneyHarwestDownload = @"SELECT HoneyHarwestID
		                                                  ,HoneyTypeID
	                                                      ,HoneyHarwestDateTime
		                                                  ,HoneyHarwestLocation
	                                                      ,HoneyHarwestAmount
                                                          FROM honeyharwest";

        public const string PersonSave = @"INSERT INTO persons
                                                (FirstName
                                                ,SecondName
                                                ,PersonLocation)
                                      VALUES(@FirstName
                                      ,@SecondName
                                      ,@PersonLocation)";

        public const string HoneyPayentSave = @"INSERT INTO honeypayment
                                                     (PersonID
                                                     ,HoneyTypeID
                                                     ,SellingAmount
                                                     ,SellingPrice
                                                     ,SellingDate
                                                     ,Present)
                                      VALUES(@PersonID
                                      ,@HoneyTypeID
                                      ,@SellingAmount
                                      ,@SellingPrice
                                      ,@SellingDate
                                      ,@Present)";

        public const string HoneyHarwestSave = @"INSERT INTO honeyharwest
			                                            (HoneyTypeID
			                                            ,HoneyHarwestDateTime
			                                            ,HoneyHarwestLocation
		                                            	,HoneyHarwestAmount)
                                      VALUES(@HoneyTypeID
	                                 ,@HoneyHarwestDateTime
                                	 ,@HoneyHarwestLocation
                                	 ,@HoneyHarwestAmount)";

        public const string YearHarwHappAll = @" SELECT DISTINCT(YEAR(HoneyHarwestDateTime)) FROM honeyharwest {0} ";
        public const string YearHarwHappByHoneyType = @" WHERE HoneyTypeID = {0} ";

        public const string HoneyTypeQForPaymentsAll = @"SELECT DISTINCT(HoneyTypeID) FROM honeypayment ";

        public const string YearQForActualYaersAll = @"SELECT DISTINCT(YEAR(SellingDate)) FROM honeypayment ";

        public const string HoneyTypeForHarwest = @"SELECT DISTINCT(HoneyTypeID) FROM honeyharwest";

        public const string HPQueryForPaymentsAll = @"SELECT PaymentID, PersonID, HoneyTypeID, SellingAmount, SellingPrice, SellingDate, Present FROM honeypayment";

        public const string QForHarwestAll = @"SELECT HoneyHarwestID, HoneyTypeID, HoneyHarwestDateTime, HoneyHarwestLocation, HoneyHarwestAmount FROM honeyharwest ";

        public const string WherePresent = @" WHERE Present = {0} ";
        public const string ByPerson = @" AND PersonId = {0} ";
        public const string ByHoneyType = @" AND HoneyTypeID = {0} ";
        public const string ByYearOfSelling = @" AND YEAR(SellingDate) = {0} ";
        public const string ByYearOfHarwest = @" ";

        public const string QForHarwestWhereYear = @" WHERE YEAR(HoneyHarwestDateTime) = {0} ";
        public const string QFOrHarwestWhereHoneyType = " WHERE HoneyTypeID = {0} ";
        public const string QForHarwestYear = @"AND YEAR(HoneyHarwestDateTime) = {0}";

        public const string EndCharacter = " ; ";
    }

    public class SQLErrorText
    {
        public const string ServerConnectionErrorText = "A szerverhez való kapcsolódás közben hiba történt.";
        public const string PersonDownloadErrorText = "A személyadatok betöltése közben hiba történt.";
        public const string HoneyTypesDownloadErrorText = "A méztípusokbetöltése közben hiba trörtént.";
        public const string PersonSaveErrorText = "A személynevek mentése közben hiba történt.";
        public const string HoneyPaymentSaveErrorText = "A mézvásárlás adatok mentése közben hiba történt.";
        public const string HoneyHarwestSaveErrorText = "A pergetésadatok mentése közben hiba történt.";
        public const string ActualHarwestYearsErrorText = "A pergetésadatokhoz tartozó évekszámok letöltése közben hiba történt.";
        public const string ActualSalesYearsErrorText = "Az eladásadatokhoz tartozó évszámok letöltése közben hiba történt.";
        public const string HoneyTypesForSalesErrorText = "Az eladásadatokhoz tartozó méztípusok letöltése közben hiba történt.";
        public const string HoneyTypesForHarwestErrorText = "A pergetésadatokhoz tartozó méztípusok letöltése közben hiba történt.";
        public const string HoneySalesAllTypesDownloadErrorText = "Azeladásadatok letöltése közben hiba történt.";
        public const string HoneyHarwestAllTypesDownloadErrorText = "A pergetésadatok letöltése közben hiba történt.";
        public const string DatabaseCheckConnectionErrortext = "Az adatbázis ellenőrzése közben hibatörtént.";
        public const string DatabaseTableCheckConnectionErrorText = "Az adatbázis táblák ellenőrzése közben hiba történt";
    }
}
