using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
namespace WebApplication5
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        // For directly accessing using static
        public static List<Car> GetCarDeatails()
        {   // Storing data into a list
            List<Car> carList = new List<Car>()
            {
                new Car("Mehran"),
                new Car("Lamborgini"),
                new Car("Tesla"),
                new Car("City"),
                new Car("Civic"),
                new Car("Corolla"),
                new Car("Suzuki"),
                new Car("Swift"),
                new Car("Wagnor"),
                new Car("Cultus"),
                new Car("Avantandor"),
                new Car("Thar"),
                new Car("Gwagon"),
                new Car("Coure"),
                new Car("Austin martin"),
                new Car("Jeep Gladiator"),
                new Car("Dodge Stealth"),
                new Car("GMC Syclone"),
                new Car("GMC Typhoon"),
                new Car("Sonata")
             };
           
            return carList;
        }

        [WebMethod]
        // function calling with ajax
        public static List<string> GetCarNames(string term)
        {
            List<Car> carList = GetCarDeatails();
            // Making New List for returning data 
            List<string> list = new List<string>();
            var carListLength = carList.Count;
                for (int i = 0; i < carListLength; i++)
                {
                    if (carList[i].Name.ToLower().Contains(term.ToLower()))
                    {   // Sending Data into new List
                        list.Add(carList[i].Name.ToString());
                    }
                }

            return list;
        }

    }
}