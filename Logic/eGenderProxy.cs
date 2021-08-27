namespace Logic
{ 
    public class GenderProxy
    {
        public string Gender => SingletonUser.FacebookUser.Gender.ToString();
    }
}
