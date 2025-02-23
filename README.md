# proxyPattern

[ Client (콘솔 앱) ]
1. Program.cs
   - RemoteServiceStub 인스턴스 생성
   - `remoteService.GetDataAsync(1)` 호출

2. RemoteServiceStub.cs
   - `_httpClient.GetStringAsync("1")` 요청
   - `https://localhost:5001/api/data/1` 호출

----------------------------------------

[ Server (ASP.NET Web API) ]
3. RemoteServiceController.cs
   - `[HttpGet("{id}")]` 메서드 실행
   - `"Data for ID 1 from server"` 반환

----------------------------------------

[ Client (콘솔 앱) ]
4. RemoteServiceStub.cs
   - 서버 응답(JSON)을 받아 문자열 반환

5. Program.cs
   - 결과 출력: `"서버에서 받은 데이터: Data for ID 1 from server"`
