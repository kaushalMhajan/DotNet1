namespace Patients
{
  class InHousePatient: Patient
    {
        private double discount;

        public InHousePatient(string name,BedType type,int days,double d):base(name,type,days){
            discount = d;
        }

        public double Discount{
            get{
                return discount;
            }
            set{
                discount = value;
            }
        }

        public override double getBillAmount(){
            double amount = base.getBillAmount();
            if(amount!=0){
                discount = discount/100;
            }else{
                discount = amount > 5000 ? 0.10:0.05;
            }

            return amount*(1-discount);
        }
    }  
}
    
