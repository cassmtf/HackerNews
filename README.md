# HackerNews

Running & Testing:

1. Load and build the HackerNews Visual Studio solution
2. using "IIS Express" run the web service application (Choose the preferred web browser if needed)
3. Use SOAPUI / Fiddler / PowerShell to invoke the GET API
   For example - if using the PowerShell, type in the prompt :

      Invoke-RestMethod http://localhost:50000/api/hnews -Method GET
 			[OR]
      Invoke-RestMethod http://localhost:50000/api/hnews


Assumptions:
1. In order to avoid overloading Hacker News API, the stories are cached and refreshed every 2 minutes. 
   2 minutes is assumed to be reasonable for this exercise but can be changed if needed.
       [CACHETIMEOUT defined in HackerNewsService]
2. It is also assumed invoking Hacker News API always retrieves the story ids and stories. Hence the Cache can always
be constructed to service client requests. 


Future Enhancements:
1. Unit Tests can be added
2. Cache is constructed when the first client requests the stories and also when the cache expires every 2 minutes. This means one of the client requests may need to wait few seconds when the cache is constructed. 
Also when stories can't be retrieved from HackerNews, the cache may be blank. Depends on the requirement this behaviour can be altered in a thread safe way. 
