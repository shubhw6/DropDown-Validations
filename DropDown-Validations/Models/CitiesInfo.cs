namespace DropDown_Validations.Models
{
    public class CitiesInfo
    {
        private List<CountryInfo> countryInfo = new List<CountryInfo>();
        public List<CountryInfo> CountryInfoList
        {
            get { return countryInfo; }
            set { countryInfo = value; }

        }


        private List<StateInfo> stateInfo = new List<StateInfo>();
        public List<StateInfo> StateInfoList
        {
            get { return stateInfo; }
            set { stateInfo = value; }

        }


        private List<CityInfo> cityInfo = new List<CityInfo>();
        public List<CityInfo> CityInfoList
        {
            get { return cityInfo; }
            set { cityInfo = value; }

        }


    }


    public class CountryInfo
    {
        public int CId { get; set; }

        public string CName { get; set; }
    }

    public class StateInfo
    {

        public int SId { get; set; }
        public int CId { get; set; }
        public string SName { get; set; }
    }


    public class CityInfo
    {
        public int CityId { get; set; }
        public int SId { get; set; }
        public string CityName { get; set; }
    }




}
