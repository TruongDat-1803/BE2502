namespace DemoWeb.Services
{
    public class Service : IServiceA
    {

        public Service()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
