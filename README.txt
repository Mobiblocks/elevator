How to build and launch:

- Build ElevatorAPIWeb.sln
- start ElevatorAPIWeb.exe command line app
- open browser and navigate to http://localhost:8080/elevator or http://localhost:8080/car

OR

- Open ElevatorAPIWeb.sln in Visual Studio
- Launch ElevatorAPIWeb profile (not IIS Express)
- browser will open at http://localhost:8080/elevator

REST API spec:

GET /elevator/sendcartofloor/5
	A person requests an elevator be sent to their current floor

GET /elevator/takemetofloor/5
	A person requests that they be brought to a floor

GET /car/currentservicingfloors
	An elevator car requests all floors that it’s current passengers are servicing (e.g. to light up the buttons that show which floors the car is going to)

GET /car/nextfloor
	An elevator car requests the next floor it needs to service