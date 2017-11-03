using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace CarRent
{
    [DataContract]
    public class Car
    {
        public Car(string model, string color)//, OccupationStatus status)
        {
            _model = model;
            _color = color;
            //occupationStatus = status;
            dateOfRent = new List<DateOfRent>();
    }

        public void SendToRent(DateTime firstDateOfRent, DateTime lastDateOfRent)
        {
            //occupationStatus = OccupationStatus.Rented;
            dateOfRent.Add(new DateOfRent(firstDateOfRent, lastDateOfRent));
            _countOfRent++;
            //ReturnBack();
        }
        /*
        public void ReturnBack()
        {
            occupationStatus = OccupationStatus.Free;
        }
        */
        public void SendToCheckUp()
        {
            _countOfRent = 0;
            //occupationStatus = OccupationStatus.OnCheckUp;
            DateOfRent dateOfCheckUp = new DateOfRent();
            dateOfCheckUp.setFirstDate(dateOfCheckUp.FindLastDate(this).AddDays(1));
            dateOfCheckUp.setLastDate(dateOfCheckUp.FindLastDate(this).AddDays(7));
            dateOfRent.Add(dateOfCheckUp);
            //ReturnBack();
        }
        /*
        public bool IsFreeToRent()
        {
            return (occupationStatus == OccupationStatus.Free);    
        }
        */
        [DataMember]
        private string _model;
        [DataMember]
        private string _color;
        [DataMember]
        private int _countOfRent;
        //[DataMember]
        //private OccupationStatus occupationStatus;
        [DataMember]
        private List<DateOfRent> dateOfRent;

        public List<DateOfRent> getDateOfRent()
        {
            return dateOfRent;
        }

        public int getCountOfRent()
        {
            return _countOfRent;
        }

        public void setCoundOfRent(int countOfRent)
        {
            _countOfRent = countOfRent;
        }
        /*
        public OccupationStatus getOccupationStatus()
        {
            return occupationStatus;
        }

        public void setOccupationStatus(OccupationStatus occupationStatus)
        {
            this.occupationStatus = occupationStatus;
        }
        */
    }
}
