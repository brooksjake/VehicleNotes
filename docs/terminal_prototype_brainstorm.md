10/31/2026

## Terminal Based Prototype description, plan, notes, brainstorm
just a single 'driver', maybe multiple vehicles     
through the terminal a user can add new vehicles, add entries, and view stats   
    
how to implement reading/writing to a file as well? 
vehicles are stored as folders with:
1) a main data file, containing all basic info/stats about the vehicle
2) another fail, containing all the entries (each new line being a separate entry)
    
that way when called to display stats, the data can be pulled from the file, then calculated.
    
    
-- mmm no, not 2   
it'd be better if there was just one file per vehicle   
consider JSON? i don't have hardly any experience, but it'd be worth learning   
and that mean's both prototypes could use those files because they both support it, i wouldn't have to write doubly


#### brainstorm -- Taxonomy of Entry Categories
suggested by claude:
- scheduled maintenance
- fluids, consumables
- repairs
- parts replacement
- modifications, upgrades
- damage, incidents
- inspections, compliance
- administrative, financial
- care, cleaning
- usage, observation

my revision:
- non-chronic work entry
	- repairs, parts replacement
	- modification, upgrade
- chronic work entry (with ability to set scheduled reminder)
	- fluids, consumables
	- gas refill
- benign
	- usage, observation
	- damage, incident report
	- administrative renewal/ change
	- care, cleaning

This is the distinction between inheritance and categorization. Not every category needs to become a class. 


mmm no. like this better:
- Driver
- Vehicle
- VehicleEntry (abstract base class)
    - FuelEntry
    - WorkEntry
    - IncidentEntry
    - InspectionEntry
    - AdministrativeEntry
    - CareEntry
    
and what kind of datastructure to store entries?    
variable size, but i'd never need to edit an entry after storing it. just loop through for stats    
possiblities:
- query? no
- dictionary? maybe
- linkedlist? yeah maybe
- set? maybe