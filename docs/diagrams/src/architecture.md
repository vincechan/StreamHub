@startuml
left to right direction

package {
    database database
    component [Data Collector]
    component [Data Analyzer]
    component [Web]
}

cloud {
    interface "User / Browser" as user
}

cloud {
    interface "External API" as api1
    interface "External API" as api2
}

database --> [Web]
database --> [Data Collector]
database --> [Data Analyzer]
user ..> [Web] : view popular shows \nand the streaming platforms \nthey are availble in 
[Data Collector] ..> api1 : fetch popular shows
[Data Analyzer] ..> api2 : fetch which streaming platforms \n shows are available in

@enduml