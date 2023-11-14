# DaprServiceInnvocation

Service invocation in Dapr is a fundamental feature that allows microservices to communicate with each other in a distributed application. ​

Dapr provides a simple and language-agnostic way for services to call each other without needing to know the specific network location or address of the target service.

Example of Service Invocation implementation 

Below is the project structure having an Web Project and a API Project

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/e9efdb3e-035e-495e-b7ec-177c4147fd1b)

In both the appSetting.Json we will keep below code 

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/c6754ff4-5260-4d8d-ab13-cd4aec9190ea)

Create a Model for ProductData 

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/a879a2c3-6e4b-44ee-b92c-5b62ddd2f6b3)


Lets create Interface and service to get the list of products in API Project

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/b5bccf58-8102-488b-bf14-1c7f7b590e17)

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/6725d900-7a9b-4476-9821-767414b8bedb)

We need to register the service and the interface created in Program.cs 

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/66c413bf-8985-4134-8703-4e792a7a5333)

This will be consumed in controller 

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/0d5d75c2-f14d-4fbd-ab3c-bcccbbbbfec4)


Lets Setup Web Project to consume the product list using service invocation 

Dapr.AspNetCore package needs to be installed in the web panel

Create a model in the Web Project to map the data 

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/7cf3cb48-710f-4be7-b073-b1e1bf0ac5dc)


Create Client interface and class to call the GetProductList

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/78d1ca4f-2f8c-4152-926c-beea57da4426)

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/eddd4e87-59a7-4130-8805-4ad29f0ebca3)

/getproductlist : is the name of the endpoint in the API project

This client will be called in controller as below

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/e8938bf6-16c1-4940-b1de-dbc279a504fa)


Below changes needs to be done in Program.cs

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/02f31f54-120d-4f35-8cba-8c4bb1a9cb72)

Final make the following changes in the launchSetting.Json to specify the port . 

For ProductApi below is the port selected

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/348ebe23-560b-4e43-9167-5eb58aff64bd)

For ProductWeb below is the port selected 

![image](https://github.com/dilaara-simform/DaprServiceInnvocation/assets/62933242/252a0fb0-700b-427f-bdb8-7467976e201a)

Below is the command to run in two separate powershell 

Path should be set to ProductApi: 

**dapr run --app-id productapi --app-port 5001 --dapr-http-port 50001 dotnet run**
Note : This Id is used in the program.cs file of Product Web project to invoke httpclient.

Path should be set to Product Web:

**dapr run --app-id frontend --app-port 5002 --dapr-http-port 50002 dotnet run**

App-Id : used for unique identification
App-Port : Port specified in the launchSettings
Dapr-Http-Port : Port required for dapr http request


















