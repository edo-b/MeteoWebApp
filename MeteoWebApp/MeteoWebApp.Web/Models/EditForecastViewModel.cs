using MeteoWebApp.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoWebApp.Web.Models
{
    public partial class EditForecastViewModel
    {
        public int ForecastRecordId { get; set; }
        public int CityId { get; set; }
        public int Temperature { get; set; }
        public int GeneralStateEdit { get; set; }
        public int WindDirectionEdit { get; set; }
        public int WindSpeed { get; set; }
        public int RainChance { get; set; }
        public string GeneralStateImageUrl { get; set; }
        public string GeneralStateCaption { get; set; }
        public string WindDirectionImageUrl { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset FirstDate { get; set; }
    }

    public partial class EditForecastViewModel
    {
        public bool ValidateInputValues()
        {
            var returnValue = true;

            if (this.CityId <= 0)
            {
                returnValue = false;
            }
            if (this.GeneralStateEdit <= 0 || this.GeneralStateEdit > 6)
            {
                returnValue = false;
            }
            if (this.RainChance < 0 || this.RainChance > 100)
            {
                returnValue = false;
            }
            if (this.WindDirectionEdit < 0 || this.WindDirectionEdit > 9)
            {
                returnValue = false;
            }
            if (this.WindSpeed < 0)
            {
                returnValue = false;
            }
            if (this.Date == null)
            {
                returnValue = false;
            }

            return returnValue;
        }

        public void PrepareDataForStoring()
        {
            switch (this.GeneralStateEdit)
            {
                case (int)GeneralStateConditions.Sunny:
                    this.GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clear-icon.png";
                    this.GeneralStateCaption = "Sunčano";
                    break;
                case (int)GeneralStateConditions.PartlyCloudy:
                    this.GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-clouds-icon.png";
                    this.GeneralStateCaption = "Djelomično oblačno";
                    break;
                case (int)GeneralStateConditions.Cloudy:
                    this.GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-many-clouds-icon.png";
                    this.GeneralStateCaption = "Oblačno";
                    break;
                case (int)GeneralStateConditions.Rain:
                    this.GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-showers-scattered-icon.png";
                    this.GeneralStateCaption = "Kiša";
                    break;
                case (int)GeneralStateConditions.Snow:
                    this.GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-snow-scattered-icon.png";
                    this.GeneralStateCaption = "Snijeg";
                    break;
                case (int)GeneralStateConditions.ThunderStorm:
                    this.GeneralStateImageUrl = "/Content/Images/WeatherImages/Status-weather-storm-night-icon.png";
                    this.GeneralStateCaption = "Pljusak s grmljavinom";
                    break;
            }
            switch (this.WindDirectionEdit)
            {
                case (int)WindDirections.N:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDown.png";
                    break;
                case (int)WindDirections.NE:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDownLeft.png";
                    break;
                case (int)WindDirections.E:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowLeft.png";
                    break;
                case (int)WindDirections.SE:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpLeft.png";
                    break;
                case (int)WindDirections.S:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUp.png";
                    break;
                case (int)WindDirections.SW:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowUpRight.png";
                    break;
                case (int)WindDirections.W:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowRight.png";
                    break;
                case (int)WindDirections.NW:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/ArrowDownRight.png";
                    break;
                case (int)WindDirections.NoWind:
                    this.WindDirectionImageUrl = "/Content/Images/WindArrows/NoWind.png";
                    break;
            }

            if (this.WindSpeed == 0)
            {
                this.WindDirectionImageUrl = "/Content/Images/WindArrows/NoWind.png";
                this.WindDirectionEdit = (int)WindDirections.NoWind;
            }

            if(this.WindDirectionEdit == (int)WindDirections.NoWind)
            {
                this.WindSpeed = 0;
            }
        }
    }
}