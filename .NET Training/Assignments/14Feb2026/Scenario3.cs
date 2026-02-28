public interface IPatient
{
    int PatientId { get; }
    string Name { get; }
    DateTime DateOfBirth { get; }
    BloodType BloodType { get; }
}

public enum BloodType { A, B, AB, O }
public enum Condition { Stable, Critical, Recovering }

// 1. Generic patient queue with priority
public class PriorityQueue<T> where T : IPatient
{
    private SortedDictionary<int, Queue<T>> _queues = new();
    
    // TODO: Enqueue patient with priority (1=highest, 5=lowest)
    public void Enqueue(T patient, int priority)
    {
        // Validate priority range
        if(priority<1 || priority > 5)
        {
            throw new ArgumentException("Priority Not In Range");
        }
        if (_queues.ContainsKey(priority))
        {
            _queues[priority].Enqueue(patient);
        }
        else
        {
            _queues[priority] = new Queue<T>();
            _queues[priority].Enqueue(patient);
        }
        // Create queue if doesn't exist for priority
    }
    
    // TODO: Dequeue highest priority patient
    public T Dequeue()
    {
        // Return patient from highest non-empty priority
        var result = _queues.FirstOrDefault(p=>p.Value.Count > 0);
        if(result.Value == null)
        {
            throw new Exception("Empty");
        }
        else
        {
            return result.Value.Dequeue();
        }
        // Throw if empty
    }
    
    // TODO: Peek without removing
    public T Peek()
    {
        // Look at next patient
        return _queues.FirstOrDefault(p=>p.Value.Count > 0).Value.Peek();
    }
    
    // TODO: Get count by priority
    public int GetCountByPriority(int priority)
    {
        // Return count for specific priority
        return _queues[priority].Count();
    }
}

// 2. Generic medical record
public class MedicalRecord<T> where T : IPatient
{
    private T _patient;
    private List<string> _diagnoses = new();
    private Dictionary<DateTime, string> _treatments = new();
    
    // TODO: Add diagnosis with date
    public void AddDiagnosis(string diagnosis, DateTime date)
    {
        // Add to diagnoses list
        _diagnoses.Add($"{date} : {diagnosis}");
    }
    
    // TODO: Add treatment
    public void AddTreatment(string treatment, DateTime date)
    {
        // Add to treatments dictionary
        _treatments.Add(date,treatment);
    }
    
    // TODO: Get treatment history
    public IEnumerable<KeyValuePair<DateTime, string>> GetTreatmentHistory()
    {
        // Return sorted by date
        return _treatments.OrderByDescending(t=>t.Key);
    }
}

// 3. Specialized patient types
public class PediatricPatient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType { get; set; }
    public string GuardianName { get; set; }
    public double Weight { get; set; } // in kg
}

public class GeriatricPatient : IPatient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType { get; set; }
    public List<string> ChronicConditions { get; } = new();
    public int MobilityScore { get; set; } // 1-10
}

// 4. Generic medication system
public class MedicationSystem<T> where T : IPatient
{
    private Dictionary<T, List<(string medication, DateTime time)>> _medications = new();
    
    // TODO: Prescribe medication with dosage validation
    public void PrescribeMedication(T patient, string medication, 
        Func<T, bool> dosageValidator)
    {
        // Check if dosage is valid for patient type
        if (dosageValidator(patient))
        {
            _medications.Add(patient,new List<(string medication, DateTime time)>(medication,"asdf"));
        }
        // Pediatric: weight-based validation
        // Geriatric: kidney function consideration
    }
    
    // TODO: Check for drug interactions
    public bool CheckInteractions(T patient, string newMedication)
    {
        // Return true if interaction with existing medications
    }
}