using System.Diagnostics;
using System;
using TratamentoExcecoes2.ExceptionDomain;

namespace TratamentoExcecoes2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var res = new Reservation(10, DateTime.Parse("2020-10-11"), DateTime.Parse("2020-10-12"));
                System.Console.WriteLine("Quantidade de dias:" + res.Duration().ToString());    
            }
            catch (TratamentoExcecoes2.ExceptionDomain.ExceptionDomain e)
            {
                System.Console.WriteLine(e.GetMessage());
                
            }
            
        }
    }
}

public class Reservation{

    private int roomNumber;
    public int RoomNumber
    {
        get { return roomNumber; }
        set { roomNumber = value; }
    }
    private DateTime checkin;
    public DateTime Checkin
    {
        get { return checkin; }
        set { 
                if(value > DateTime.Now){
                    throw new ExceptionDomain("Data futura nao permitida");
                }    
                checkin = value; 
            }

    }
    private DateTime checkout;
    public DateTime Checkout
    {
        get { return checkout; }
        set { checkout = value; }
    }
    public Reservation(){}

    public Reservation(int roomNumber, DateTime checkin, DateTime checkout){

            if(checkin > checkout)
                throw new ExceptionDomain("Checkout deve ser maior do que o checkin!");

            this.RoomNumber = roomNumber;
            this.Checkin = checkin;
            this.Checkout = checkout;
    }

    public int Duration(){
        return this.Checkout.Day - this.Checkin.Day;
    }

    public void UpdateDates(DateTime checkin, DateTime checkout ){
        if(checkout > checkin)
            throw new ExceptionDomain("Checkout deve ser maior do que o checkin!");
    
        this.Checkin = checkin;
        this.Checkout = checkout;
    }
}