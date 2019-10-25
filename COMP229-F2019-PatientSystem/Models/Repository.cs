using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_PatientSystem.Models
{
    public class Repository
    {
        // list of patients
        private static List<Patient> patientList = new List<Patient>
        {
           // initial value
           new Patient
           {
                Name = "Ederson Cardoso",
                Age = 28,
                Address = "11 Cicerela Crescent",
                Occupation = "Student",
                HasInsurance = true,
                HadOperation = false,
                MaritalStatus = "Maried",
                DateRegistration= new DateTime(2019,10,26,9,16,21)
           }
        };

    /// <summary>
    /// This method returns a list of patients
    /// </summary>
    public static IEnumerable<Patient> PatientList
        {
            get
            {
                return patientList;
            }
        }
        /// <summary>
        /// This method add patients into the patientList
        /// </summary>
        /// <param name="patient"></param>
        public static void AddPatient(Patient patient)
        {
            patientList.Add(patient);
        }
    }
}
