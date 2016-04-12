using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoWebApp.Web.Helpers
{
    public class SelectListProviders
    {
        public static List<SelectListItem> GetGeneralStateSelectList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Sunčano",
                    Value = ((int)GeneralStateConditions.Sunny).ToString(),
                    Selected = true
                },
                new SelectListItem
                {
                    Text = "Djelomično oblačno",
                    Value = ((int)GeneralStateConditions.PartlyCloudy).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Oblačno",
                    Value = ((int)GeneralStateConditions.Cloudy).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Kiša",
                    Value = ((int)GeneralStateConditions.Rain).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Snijeg",
                    Value = ((int)GeneralStateConditions.Snow).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Pljusak s grmljavinom",
                    Value = ((int)GeneralStateConditions.ThunderStorm).ToString(),
                    Selected = false
                }
            };
        }

        public static List<SelectListItem> GetWindDirectionSelectList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Sjevernjak - S",
                    Value = ((int)WindDirections.N).ToString(),
                    Selected = true
                },
                new SelectListItem
                {
                    Text = "Sjeveroistočnjak - SI",
                    Value = ((int)WindDirections.NE).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Istočnjak - I",
                    Value = ((int)WindDirections.E).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Jugoistočnjak - JI",
                    Value = ((int)WindDirections.SE).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Južni - J",
                    Value = ((int)WindDirections.S).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Jugozapadnjak - JZ",
                    Value = ((int)WindDirections.SW).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Zapadnjak - Z",
                    Value = ((int)WindDirections.W).ToString(),
                    Selected = false
                },
                new SelectListItem
                {
                    Text = "Sjeverozapadnjak - SZ",
                    Value = ((int)WindDirections.NW).ToString(),
                    Selected = false
                }
            };
        }
    }
}