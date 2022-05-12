# ordering.products
Singular Systems Assessment for JWT, Ordering Products for Companines and using SSMS to manage Database, View for more details......

**How does it work  :-**
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
  
**Assumptions :-**

    o  Once the order is in the database can not be updated via Reactjs.
    
    o  files containig sensitive data would be excluded from the pushed\updated code using gitIgnore.
    
    o  Due to the time limmit I might have npt been consistent with Good practice in front end.
    
    o  There will be a differnt system to load product i.e CRUD.
    
    o  The whole assessmet was to demostrate my capabilities and it was an open assessment that I could drag and be creative.
    
     o The best way to manage my app state and storing data on Reactjs throughout my app is Redux but I got a delay the hence I optioned to use local storage in some parts. 
    
    o  It was really nice to revisit Reactjs after some time 🤐
    
 **Tools used :-**
  
    o  ASP.Net Core
    
    o  C#
    
    o  HTML, CSS, JavaScript,
    
    o  Bootrap 5
    
    o  React
    
    o  SQL Server and SSMS
