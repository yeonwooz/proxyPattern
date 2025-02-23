namespace Client
{
    internal class RemoteServiceStub : IRemoteService
    {
        private readonly HttpClient _httpClient;

        public RemoteServiceStub()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5249/api/data/");
        }

        public string GetData(int id)
        {
            var response = _httpClient.GetStringAsync(id.ToString()).Result;
            return response;
        }
    }
}
