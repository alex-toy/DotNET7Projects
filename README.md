# .NET 7 Projects

## Generic Repository and Unit of Work .NET 7

In this project, we will see how to implement the **Generic Repository Pattern** and **Unit of Work**.This pattern provides the following benefits: 
- reduces redundancy of code, 
- forces developper to work using the same pattern, 
- creates possibility of less error,
- makes it easy to maintain the centralized data access logic.

We will dive deep into Entity Framework Relations types : One to Many, One to One and Many to Many.

### Nuget Packages

- in *MovieManagement.DataAccess*
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```


## Create and use JSON Web Tokens with .NET 7

JSON Web Tokens (JWT) are a standard for representing claims securely between two parties. They are typically used to authenticate users and authorize their access to certain resources. In this project, we'll see how to implement JWT authentication in a .NET 7 Web API using Entity Framework.

### Nuget Packages
```
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

### Migrations
```
Add-Migration init
Update-Database
```

### Run App

- get weather forecast without authentication
<img src="/pictures/app.png" title="run app"  width="900">

- login
<img src="/pictures/app1.png" title="run app"  width="900">

- get token
<img src="/pictures/app2.png" title="run app"  width="900">

- get weather forecast with authentication
<img src="/pictures/app3.png" title="run app"  width="900">
