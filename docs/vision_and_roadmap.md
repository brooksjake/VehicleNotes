2026
### Vision for the Final Product:
A mobile app available for anyone on the app stores to download for free. Distinct user profiles (with possible login with Gmail if desired), in which each user is a driver who can own one or many vehicles, and store 1) information about their vehicles, 2) information about their insurance policy, and 3) logs pertaining to their vehicles. A driver can also set maintenance schedules about when to perform chronic actions and receive reminder notifications for those schedules.
1) *Non-changing data stored about vehicle:* VIN number, year, make, model
   *Changing data stored about the vehicle:* optional nickname, pictures of the vehicle, license plate, registration info, insurance policy, mileage, market value estimate, list of pertinent drivers
2) *Data stored about the insurance policy:* monthly cost, policy number, policy provider, coverage type, vehicles covered, drivers covered, coverage start and end/renewal dates
3) *Logs pertaining to a vehicle:* entries including the following types:
	1) simple gas refill (cost, gallons, mileage update, date)
	2) maintenance (maintenance type/description, list of parts/tools/materials bought, total cost, time spent estimate, date, whether it was done at home or outsourced, receipts, pictures)
	3) registration renewal or insurance policy renewal (new coverage dates, updated monthly cost, receipts, date)
	4) crash/damage report (date, description of damage, drivers included and their contact/insurance information, pictures)

Additional functionality includes:
- A driver will be able to use the camera to scan VIN number to extract vehicle information, scan drivers license to extract driver information, store pictures of receipts or maintenance or of the vehicle.
- a page dedicated to extensive statistics for the vehicle(s) on maintenance, costs, mileage, etc.
- market value estimate storage and retrieval via kellybluebook or other publicly available vehicle value website
- automatic creation of a vehicle notes summary pdf/text for the driver to share with buyers, for the purpose of selling the vehicle

### Vision for an MVP:
A mobile app available for anyone on the app stores to download for free. Distinct user profiles (by device individuality), in which each user is a driver who can own one vehicle, and store 1) information about their vehicles, and 2) logs pertaining to their vehicles.
1) *Non-changing data stored about vehicle:* VIN number, year, make, model
   *Changing data stored about the vehicle:* optional nickname, pictures of the vehicle, license plate, registration info, insurance policy number, mileage
2) *Logs pertaining to a vehicle:* entries including the following types:
	1) simple gas refill (cost, gallons, mileage update, date)
	2) maintenance (maintenance type/description, list of parts/tools/materials bought, total cost, time spent estimate, date, whether it was done at home or outsourced, receipts, pictures)

Additional functionality includes:
- A driver will be able to use the camera to scan VIN number to extract vehicle information, scan drivers license to extract driver information, store pictures of receipts or maintenance or of the vehicle.
- a page dedicated to statistics for the vehicle on maintenance, costs, mileage, etc.




### Roadmap
- so, i thought i'd start with a terminal based program, just to work out the logic and get a good sense of what the project structure should be.
- then i'd probably make a database schema.
- then i think i'd want to make a model, work out the basic functional core. I have no experience creating mobile apps or anything like that, mostly just some general knowledge and experience in terminal based programs using c# or java or python and web building. so i've heard flutter would be a great application to use to make the model. maybe there are other good applications as well that i haven't heard of yet. 
- then i'd want to work on making it publicly available, ensuring that i take all the legal precautions for protecting user data and publishing the correct way. or like, if i use any api's that whatever needs to be done about citation is done correctly
- then i'd want to work on image storage, and using the camera to scan stuff, then interpret, then store. if possible maybe i could build a small and separate mvp to just work on and learn the employment of this functionality


### Learning Flutter/Dart
sourcebank:
- [fireship tutorial](https://www.youtube.com/watch?v=1xipg02Wu8s)
- [flutter tutorial playlist](https://www.youtube.com/playlist?list=PLjxrf2q8roU2bqkohF-r9TNmo8HWSu0TG)
- [flutter learn pathway](https://docs.flutter.dev/learn/pathway)
