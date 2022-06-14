namespace DevExp.Models
{
    public class Model
    {
        public List<DevExp.EntityFramework.Models.ProductSale> Sales { get; set; }
        public List<string> Years { get { 
                var a=new List<int>() { 2022,2021,2020,2019,2018, 2017, 2016, 2015, 2014, 2013, 2012, 2011, 2010};
                var b = new List<string>();
                foreach (var item in a)
                {
                    b.Add(item.ToString());
                }
                return b;
            } }
        public List<string> Monts
        {
            get
            {
                var a = new List<int>() {12,11,10,9,8,7,6,5,4,3,2,1 };
                var b = new List<string>();
                foreach (var item in a)
                {
                    b.Add(item.ToString());
                }
                return b;
            }
        }
    }
}
