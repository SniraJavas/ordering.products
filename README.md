# ordering.products
Singular Systems Assessment for JWT, Ordering Products for Companines and using SSMS to manage Database

How does it work  :-
  - Clients\User records will be added on on swagger /api/Authenticate/register
  - User Id to perform orders will be generated and returned to user Id upon regestering
  - NB : Password to register should contain small letters, capital letters, number and a special character and emails should be unique
  - I have listed about 20 products using stored procedure and it might take me some time to make them 10 :(
  - There are only two api methods for products both are GET Methods for retrieving All products and a single Product by Id
  - Through swagger and ReactJs we can make Order given that the userId is correct (exist in the database)
  - Client can Add items to the basket
  - Can record user's order in the database through ReactsJs and Swagger
  - Client can remove items from basket
  - Basket can show cost
  - There are stored procedures that are executed in migrations to populate the database with relevant data
  - Security infrastructure have been in place to demostrate some of the content we covered on our interview using JWT and Microsoft.AspNetCore.Identity;
  
  Assumptions :-
    - Once the order is in the database can not be updated via Reactjs
    - files containig sensitive data would be excluded from the pushed\updated code using gitIgnore
    - Due to the time limmit I might have npt been consistent with Good practice in front end.
    
  Tools used :-
    -  ASP.Net Core
    -  C#
    -  HTML, CSS, JavaScript,
     - Bootrap 5
    - React
    - SQL Server and SSMS
