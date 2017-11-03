using System;
using System.Runtime.Serialization;


namespace CarRent
{
    [DataContract]
    public class DateOfRent
    {
        [DataMember]
        private DateTime _firstDate;
        [DataMember]
        private DateTime _lastDate;


        public DateTime FindLastDate(Car car)
        {
            DateTime lastDate = car.getDateOfRent()[0]._lastDate;

            for (int i = 1; i < car.getDateOfRent().Count; i++)
            {
                if (car.getDateOfRent()[i]._lastDate.CompareTo(lastDate) > 0)
                {
                    lastDate = car.getDateOfRent()[i]._lastDate;
                }
            }
            return lastDate;
        }


        public DateOfRent(DateTime firstDate, DateTime lastDate)
        {
            _firstDate = firstDate;
            _lastDate = lastDate;
        }

        public DateOfRent() { }
        

        public DateTime getFirstDate ()
        {
            return _firstDate;
        }

        public DateTime getLastDate()
        {
            return _firstDate;
        }

        
        public void setFirstDate(DateTime firstDate)
        {
            _firstDate = firstDate;
        }

        public void setLastDate(DateTime lastDate)
        {
            _lastDate = lastDate;
        }
        
    }
}
