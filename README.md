# ASP.NET Core WebApi for Quadcare application a hospital management application.

See the examples here: 

## Versions

``` https://quadcareapis.azurewebsites.net/swagger ```

![ASPNETCOREWebAPIVersions](./.github/Swagger API Version.png)

## GET All Appointments

``` https://quadcareapis.azurewebsites.net/api/appointment/GetAllAppointments ```

![ASPNETCOREWebAPIGET](./.github/GetAllAppointments.png)

## POST - Book an Appointment

``` https://quadcareapis.azurewebsites.net/api/appointment/BookAppointments ```

![ASPNETCOREWebAPIGET](./.github/BookAppointments.png)

```javascript
  {
       "id": 0,
      "time": "13:00",
      "date": "12/14/2022",
      "patientId": 34,
      "patientName": "",
      "doctorName": "",
      "doctorId": 0,
      "isAssigned": true
  }
```
