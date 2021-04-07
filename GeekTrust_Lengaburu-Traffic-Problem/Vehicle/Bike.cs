﻿using System;
using System.Collections.Generic;
using System.Text;
using geektrust.Base;
using geektrust.Enums;

namespace geektrust.Vehicle
{
    public class Bike : VehicleBase<Bike>
    {
        public override string Name { get { return _name; } }
        public override double Speed { get { return _speed; } }
        public override double TimeToCrossCrater { get { return _timeToCrossCrater; } }
        public override VehicleTypeEnum VehicleType { get { return _vehicleType; } }

        private string _name { get; set; }
        private double _speed { get; set; }
        private double _timeToCrossCrater { get; set; }
        private VehicleTypeEnum _vehicleType { get; set; }

        public Bike()
        {
            _name = "BIKE";
            _speed = 10;
            _timeToCrossCrater = 2;
            _vehicleType = VehicleTypeEnum.BIKE;
        }
        public override bool CanTravel(WeatherEnum weather)
        {
            return weather == WeatherEnum.SUNNY ||
                weather == WeatherEnum.WINDY;
        }
    }
}
