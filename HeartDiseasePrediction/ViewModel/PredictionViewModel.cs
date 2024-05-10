using System.ComponentModel.DataAnnotations;

namespace HeartDiseasePrediction.ViewModel
{
    public class PredictionViewModel
    {
        //public int Id { get; set; }
        [Display(Name = "Gender")]
        public int Sex { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Smoking")]
        public int Smoker { get; set; }
        [Display(Name = "Number Of Cigarettes")]
        public int CigsPerDay { get; set; }
        [Display(Name = "Blood Pressure Medicine")]
        public int BPMeds { get; set; }
        [Display(Name = "Prevalent Stroke")]
        public int PrevalentStroke { get; set; }
        [Display(Name = "Prevalent hypertension")]
        public int PrevalentHyp { get; set; }
        [Display(Name = "Diabetes")]
        public int Diabetes { get; set; }
        [Display(Name = "Cholesterol Level")]
        public int Cholesterol { get; set; }
        [Display(Name = "Systolic Blood Pressure")]
        public float SysBP { get; set; }
        [Display(Name = "Diastolic Blood Pressure")]
        public float DiaBP { get; set; }
        [Display(Name = "BMI")]
        public float BMI { get; set; }
        [Display(Name = "Heart Rate")]
        public int HeartRate { get; set; }
        [Display(Name = "Glucose")]
        public int Glucose { get; set; }
        //public long PatientSSN { get; set; }
        //public string PatientName { get; set; }
        //public string MedicalAnalystName { get; set; }
        //public string PatientEmail { get; set; }
        //public string LabEmail { get; set; }
        //public DateTime Date { get; set; }
    }
}
