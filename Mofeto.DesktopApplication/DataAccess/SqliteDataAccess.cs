/*
*----------------------------------------------------------------------------------
*          Filename:	SqliteDataAccess.cs
*          Date:        2020.06.02 22:58:03
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Documents;
using Dapper;
using Mofeto.DesktopApplication.Models;

namespace Mofeto.DesktopApplication.DataAccess

{
    public class SqliteDataAccess
    {

        #region Fields



        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Methods


        #region Car Operations
        public static List<CarModel> LoadCars()
        {
            List<CarModel> allCarModels = new List<CarModel>();
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                allCarModels = cnn.Query<CarModel>("SELECT * FROM Car").ToList();

                foreach (CarModel carModel in allCarModels)
                {
                    List<EntryModel> allEntriesForCar = new List<EntryModel>();
                    carModel.Brand = cnn.QueryFirstOrDefault<string>($"SELECT brandname FROM Brand WHERE {carModel.BrandId} = id").ToString();
                    carModel.ModelType = cnn.QueryFirst<string>($"SELECT modelname FROM Model WHERE {carModel.ModelId} = id").ToString();
                    carModel.FuelType = cnn.QueryFirst<string>($"SELECT TypeOfFuel from TypeOfFuel WHERE {carModel.Typeoffuelid} = id").ToString();
                    allEntriesForCar = cnn.Query<EntryModel>($"SELECT * FROM Entry WHERE {carModel.Id} = carId").ToList();
                    carModel.Entries = new ObservableCollection<EntryModel>(allEntriesForCar);
                }
            }
            return allCarModels;
        }

        public static void SaveCar(CarModel carToSave)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                throw new NotImplementedException("Not implemented Yet");
            }

        }

        public static void UpdateCar(CarModel carToUpdate)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                throw new NotImplementedException("Not implemented Yet");
            }
        }

        public static void DeleteCar(CarModel carToDelete)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                throw new NotImplementedException("Not implemented Yet");
            }
        }

        #endregion
        
        #region private Methods

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        #endregion

        #endregion

        #region EventHandler

        #endregion


    }
}