﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WijayanthaHardware.Models
{
    public class PaintViewModel
    {
        [Display(Name = "Paint Category")]
        public int PaintCategoryId { get; set; }
        public SelectList PaintCatergoryList { get; set; }
        [Display(Name = "Paint")]
        public int PaintSubCategoryId { get; set; }
        public SelectList PaintSubategoryList { get; set; }
       
        public string PaintColour { get; set; }
        public string Volume { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int PaintId { get; set; }
        public string CostCode { get; set; }
        public SelectList Volumes { get; set; }
        public int VolumeId { get; set; }
        public int Quantity { get; set; }
        public int ColourId { get; set; }
        public string Colour { get; set; }
        public int PaintMasterId { get; set; }

    }
}