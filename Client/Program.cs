namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemoteService remoteService = new RemoteServiceStub();
            Console.WriteLine("Stub를 이용한 원격 데이터 호출");

            int id = 1;
            string data = remoteService.GetData(id);

            Console.WriteLine($"서버에서 받은 데이터: {data}");
        }
    }
}