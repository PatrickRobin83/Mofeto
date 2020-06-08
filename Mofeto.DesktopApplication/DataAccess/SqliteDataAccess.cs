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
                allCarModels = cnn.Query<CarModel>("SELECT * FROM Car WHERE isActive = 1").ToList();

                foreach (CarModel carModel in allCarModels)
                {
                    List<EntryModel> allEntriesForCar = new List<EntryModel>();
                    carModel.Brand = cnn.QueryFirst<BrandModel>($"SELECT * FROM Brand WHERE {carModel.BrandId} = id");
                    carModel.ModelType = cnn.QueryFirst<ModelTypeModel>($"SELECT * FROM Model WHERE {carModel.ModelId} = id");
                    carModel.FuelType = cnn.QueryFirst<FuelTypeModel>($"SELECT * from TypeOfFuel WHERE {carModel.TypeoffuelId} = id");
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
                // Todo: implement the SafeCar Query
                throw new NotImplementedException("Not implemented Yet");
            }

        }
        public static void UpdateCar(CarModel carToUpdate)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // ToDo: Implement the Update Car Query
                throw new NotImplementedException("Not implemented Yet");
            }
        }
        public static void DeleteCar(CarModel carToDelete)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // ToDo: Implement the DeleteCar Query
                throw new NotImplementedException("Not implemented Yet");
            }
        }
        public static List<BrandModel> LoadAllBrands()
        {
            List<BrandModel> allBrands = new List<BrandModel>();
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                allBrands = cnn.Query<BrandModel>("SELECT * FROM Brand").ToList();
                return allBrands;
            }
        }
        public static List<ModelTypeModel> ModelsFromBrands( int brandId)
        {
            List<ModelTypeModel> carModels = new List<ModelTypeModel>();
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                carModels = cnn.Query<ModelTypeModel>($"SELECT * FROM Model WHERE {brandId} = brandId").ToList();

                return carModels;
            }
        }
        #endregion

        public static List<FuelTypeModel> LoadAllFuelTypes()
        {
            List<FuelTypeModel> fuelTypesList = new List<FuelTypeModel>();

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                fuelTypesList = cnn.Query<FuelTypeModel>($"SELECT * FROM TypeOfFuel").ToList();

                return fuelTypesList;
            }
        }

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