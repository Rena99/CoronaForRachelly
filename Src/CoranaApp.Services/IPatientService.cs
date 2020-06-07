namespace CoronaApp.Services
{
    public interface IPatientService
    {
        Patient Get(Patient patient);

        void Save(Patient patient);

        Location Add(int id, Location location);

        void Delete(int id, int location);
    }
}
