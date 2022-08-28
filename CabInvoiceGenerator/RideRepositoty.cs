using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepositoty
    {
        Dictionary<string,List<Ride>> userRides=null;

        public RideRepositoty()
        {
            this.userRides=new Dictionary<string,List<Ride>>(); 
        }

        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList=this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride>list=new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userId,list);    
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Ride are null");
            }
        }

        public Ride[]GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user id");
            }
        }
    }
}
