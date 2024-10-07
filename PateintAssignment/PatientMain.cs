using Patients;

class PatientMain{

    static double ServiceTax(Patient p){
        double i = p.getBillAmount();
        if(i<5000){
            return 0.0;
        }else if(i<10000){
            return i*0.05;
        }else{
            return i*0.10;
        }
    }

    static void Main(){
        Patient p = new Patient("kaushal",BedType.special,10);
        Patient p1 = new Patient("kaushal",BedType.special,30);
        Console.WriteLine("Patient id is {0} and name {1} has total bill of {2} and tax applied is {3}",p.id,p.patientName,p.getBillAmount(),ServiceTax(p));
        Console.WriteLine("Patient id is {0} and name {1} has total bill of {2} and tax applied is {3}",p1.id,p1.patientName,p1.getBillAmount(),ServiceTax(p1));

        InHousePatient ih = new InHousePatient("kaushal",BedType.special,20,10);
        Console.WriteLine("Patient id is {0} and name {1} has total bill of {2} and tax applied is {3}",p.id,ih.patientName,ih.getBillAmount(),ServiceTax(ih));
    }
}