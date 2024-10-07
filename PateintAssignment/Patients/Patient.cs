namespace Patients{
    enum BedType {special=1,semispecial=2,general=3};
    
    class Patient{
        private static int count = 0;
        public int id{get;}
        public string patientName{get;set;}
        public BedType bedType{get;set;}
        public int noOfDays{get;set;}
        public Patient(string name,BedType type,int days){
            id = ++count;
            patientName = name;
            bedType = type;
            noOfDays = days;
        }

        public Patient(): this("guest",BedType.general,1){}

        public virtual double getBillAmount(){
            int price;
                switch (bedType)
                {
                    case BedType.special:
                        price = 500;
                        break;
                    case BedType.semispecial:
                        price = 350;
                        break;
                    case BedType.general:
                        price = 200;
                        break;
                    default:
                        price = 100;
                        break;
                }
            double amount = noOfDays * price;
            return amount;
        }
    }
}