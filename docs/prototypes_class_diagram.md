## UML class diagram for Prototypes

```mermaid
---
title: Vehicle Notes
---
classDiagram
    class Program {
        StatisticsService _statsService
        createNewReminder()
    }
    Program *-- StatisticsService
    class StatisticsService {
        DisplayVehicleStats(Vehicle)
        DisplayFullStats(Driver)
    }
    class Vehicle {
        Driver _owner
        string _vin
        string _make
        string _model
        string _licensePlate
        double _currentOdometerReading
        Year _year
        Date _registrationDate
        List<Entry> _entries
        char _registeredState
        string _insurancePolicyNum
        
        Initializer(BaseVehicleInfo)
        IsRegistered() bool
        AddEntry(Entry)
    }
    class Driver {
        string _fullname
        Date _birthdate
        string _licenseNumber
        List<Vehicle> _vehicles
        StatisticsPage _stats
        
        Initializer(BaseDriverInfo)
        AddVehicle(BaseVehicleInfo)
    }
    Driver *-- Vehicle
    class VehicleEntry { <!-- baseclass -->
        int _entryID <!-- when might i need this? would i need to store these in a list outside of this class so as to be able to search/call them? -->
        Date _date
        string _description <!-- optional -->
        double _odometerReading
        double _cost 
        List<Attachment> _attachments <!-- optional -->
        
        updateMileage(_odometerReading)
    }
    class Attachment {
        
    }
    VehicleEntry *-- Attachment
    Driver *-- Attachment
    Vehicle *-- Attachment
    class FuelEntry {
        int _gallons
    }
    class WorkEntry {
        string _vendor
        bool _diy
        int _hrsSpent
        List<WorkPartMaterial> _partsMaterials
        double _laborCost
        
        <!-- maybe i could have a list of suggested common works like oil change, wiper fluid, brake pad replace, tire replace, interior clean, exterior clean, etc. ? YES, selectable options -->
    }
    class WorkParkMaterial {
        string _name
        double _cost
        int _quantity
        <!-- can this class maybe be contained in the workentry class?  NO, separate class is better -->
    }
    WorkEntry *-- WorkParkMaterial
    class IncidentEntry {
        string  _incidentDescription <!-- should this rewrite the base _description? NO -->
        string _location
        string _partyContactInfo
    }
    class InspectionEntry {
        enum _InspectionType
        string  _findingsDescription
        <!-- maybe this is overkill for now, i mean what else goes here? MEH keep it for now -->
    }
    class AdministrativeEntry {
        string _description
    }
    VehicleEntry <|-- FuelEntry
    VehicleEntry <|-- WorkEntry
    VehicleEntry <|-- IncidentEntry
    VehicleEntry <|-- InspectionEntry
    VehicleEntry <|-- AdministrativeEntry
    
    class Reminder {
        Time _timedurationinterval
        int _mileageinterval
        enum _completionstatus
        Vehicle _relatedVehicle
        string _category <!-- this would be one of the 6 entry class names: fuel, work, incident, inspection, administrative -->
        <!-- should i maybe make this a base class, and have 2 child classes mileagebased, and calendarbased? NO could be both -->
    }
```