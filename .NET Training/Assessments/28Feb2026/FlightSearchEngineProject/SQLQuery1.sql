CREATE DATABASE FlightSearchDB;

USE FlightSearchDB;

CREATE TABLE Flights
(
    FlightId INT PRIMARY KEY IDENTITY(1,1),
    FlightName NVARCHAR(100) NOT NULL,
    FlightType NVARCHAR(50) NOT NULL,
    Source NVARCHAR(100) NOT NULL,
    Destination NVARCHAR(100) NOT NULL,
    PricePerSeat DECIMAL(18,2) NOT NULL
);

CREATE TABLE Hotels
(
    HotelId INT PRIMARY KEY IDENTITY(1,1),
    HotelName NVARCHAR(100) NOT NULL,
    HotelType NVARCHAR(50) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    PricePerDay DECIMAL(18,2) NOT NULL
);

INSERT INTO Flights VALUES
('Indigo 101','Domestic','Delhi','Mumbai',5000),
('Air India 202','Domestic','Delhi','Chennai',6000),
('Emirates 303','International','Delhi','Dubai',20000);

INSERT INTO Hotels VALUES
('Taj Mumbai','5 Star','Mumbai',8000),
('ITC Chennai','5 Star','Chennai',7000),
('Burj Hotel','Luxury','Dubai',15000);

CREATE PROCEDURE sp_GetSources
AS
BEGIN
    SELECT DISTINCT Source FROM Flights;
END

CREATE PROCEDURE sp_GetDestinations
AS
BEGIN
    SELECT DISTINCT Destination FROM Flights;
END

CREATE PROCEDURE sp_SearchFlights
    @Source NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons INT
AS
BEGIN
    SELECT 
        FlightId,
        FlightName,
        FlightType,
        Source,
        Destination,
        PricePerSeat * @Persons AS TotalCost
    FROM Flights
    WHERE Source = @Source AND Destination = @Destination;
END

CREATE PROCEDURE sp_SearchFlightsWithHotels
    @Source NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons INT
AS
BEGIN
    SELECT 
        f.FlightId,
        f.FlightName,
        f.Source,
        f.Destination,
        h.HotelName,
        (f.PricePerSeat * @Persons) + h.PricePerDay AS TotalCost
    FROM Flights f
    INNER JOIN Hotels h ON f.Destination = h.Location
    WHERE f.Source = @Source AND f.Destination = @Destination;
END

