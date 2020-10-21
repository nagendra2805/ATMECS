# ATMECS

Problem Statement:

Create a Web API with endpoints to add and edit contatcs. This should be exposed via a Restful API and create a desktop WPF application utilises this Web API that allows you to add
and edit contacts. You should also be able to search and select a contact from a contact list by name.
Include any unit tests you have done in your solution.
The code must be runnable have unit test cases(TDD/BDD) and must pass.

Tools Required: Visual studio 2019(Preferable).

Languages used: Both the applicaions written on .Net Core only. so, Visual studio 2019 preferable. Xunit for unit tests.

Developer Notes:

The Web API will be hosted on "http://localhost:5001/api/Contact" when you run the solution If the web browser shows with an error "local host page can't be found".
Then don't worry its not an issue its becuase of some configuration. But, the api is hosted and works. The api will be hosted on below endpoint.

Endpoint: "http://localhost:5001/api/Contact/CreateorUpdateContact".

Both add and update contact has been done in single controller. If, the requirement really needs two endpoints for add and update we can create a new controller with PUT.
But, As i felt for a single line of code creating a new controller is not a right way to maintain the code. So, I have created a single controller for add and update contacts.
Unit test will be available to test the code and they are running successfully.

The desktop WPF application will be on ContactManagementSytem folder. Before you run wpf application please host the web api in local to get end-end output. The wpf application
allows you to create, update, search and select the contact which you desired.


Thank you so much for the opportunity and looking forward to hear from you.
