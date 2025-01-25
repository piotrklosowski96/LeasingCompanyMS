﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeasingCompanyMS.Utils;

namespace LeasingCompanyMS.Model
{
    public static class CarsRepository
    {
        private static readonly JsonUtils _jsonUtils = new JsonUtils();
        private static List<Car> cars;


        public static List<Car> GetAll()
        {
            if (cars == null)
            {
                string jsonString = _jsonUtils.ReadFromJson(GetPathToCarsJson());
                cars = _jsonUtils.MapJsonStringToCarList(jsonString);
            }
            return cars;
        }

        private static string GetPathToCarsJson()
        {
            string? projectPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            if (projectPath == null)
            {
                throw new Exception("Project path not found");
            }
            return Path.Combine(projectPath, "Json", "cars.json");
        }
    }
}
