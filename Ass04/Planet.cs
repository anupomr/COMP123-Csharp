﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name       : Anupom Roy
Date       : July 11, 2017
Description:This is the abstract class Planet which other subclasses will
            derive from.
Version    :
*/
namespace Ass04
{
    /// <summary>
    /// This is the Planet Abstract class
    /// </summary>
    public abstract class Planet
    {
        // Private Fields (Instance Variables)----------------------
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // Public Properties ----------------------------------------
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        // Constructors -----------------------------------------------
        public Planet(string name, double diameter, double mass)
        {
            this.Name = name;
            this.Diameter = diameter;
            this.Mass = mass;
        }


        // Constructors -----------------------------------------------
        public Planet(string name, double diameter)
        {
            this.Name = name;
            this.Diameter = diameter;
         
        }


    }
}