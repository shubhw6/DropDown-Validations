using DropDown_Validations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DropDown_Validations.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            CitiesInfo model = new CitiesInfo();
            model.CountryInfoList.Add(new CountryInfo { CId = 0, CName = "Select Country" });
            model.CountryInfoList.Add(new CountryInfo { CId = 101, CName = "Bharat" });
            model.CountryInfoList.Add(new CountryInfo { CId = 102, CName = "Nepal" });
            model.CountryInfoList.Add(new CountryInfo { CId = 103, CName = "China" });
            model.CountryInfoList.Add(new CountryInfo { CId = 104, CName = "England" });
            return View(model);
        }


        [HttpPost]
        public ActionResult StateData(int cid)
        {

            List<StateInfo> states = new List<StateInfo>()
        {
            new StateInfo() {CId=101,SId=1,SName="bihar"},
             new StateInfo() {CId=101,SId=2,SName="UP"},
              new StateInfo() {CId=101,SId=3,SName="Delhi"},
               new StateInfo() {CId=101,SId=4,SName="PUnjab"},
                new StateInfo() {CId=101,SId=5,SName="MP"},
                 new StateInfo() {CId=102,SId=6,SName="Kathmnadu"},
                 new StateInfo() {CId=101,SId=7,SName="Kashmir"},
                 new StateInfo() {CId=103,SId=9,SName="China"},
                 new StateInfo() {CId=104,SId=9,SName="England"},
                 new StateInfo() {CId=101,SId=10,SName="Hp"},

};

            CitiesInfo model = new CitiesInfo();
            model.StateInfoList = states.Where(s => s.CId == cid).ToList();
            return Json(model);

        }


        [HttpPost]
        public ActionResult CityData(int sid)
        {
            List<CityInfo> city = new List<CityInfo>()
        {
            new CityInfo() {SId=1,CityId=1,CityName="Patna"},
             new CityInfo() {SId=2,CityId=2,CityName="Bareilly"},
              new CityInfo() {SId=2,CityId=3,CityName="Moradaabad"},
              new CityInfo() {SId=2,CityId=4,CityName="Biznor"},
               new CityInfo() {SId=2,CityId=5,CityName="Rampur"},
                 new CityInfo() {SId=4,CityId=6,CityName="Jalandar"},
                 new CityInfo() {SId=4,CityId=7,CityName="Amritsar"},
                 new CityInfo() {SId=4,CityId=8,CityName="Chandigarh"},
                new CityInfo() {SId=2,CityId=9,CityName="Banaras"},
                 new CityInfo() {SId = 4, CityId =10, CityName = "Ludhiyana"},

                };
            CitiesInfo model = new CitiesInfo();
            model.CityInfoList = city.Where(c => c.SId == sid).ToList();
            return Json(model);


        }




    }
}

