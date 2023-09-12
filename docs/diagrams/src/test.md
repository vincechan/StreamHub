@startuml

package Core {
    component ReservationService
}

package Infrastructure {
    component ClientRepo
    component ProviderRepo
    component AppointmentRepo
}

package Api {
    component ReservationApi
}

ReservationService --> ClientRepo
ReservationService --> ProviderRepo
ReservationService --> AppointmentRepo

ReservationApi --> ReservationService

@enduml