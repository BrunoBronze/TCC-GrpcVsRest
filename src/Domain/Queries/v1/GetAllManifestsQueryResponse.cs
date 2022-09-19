using System;
using System.Collections.Generic;

namespace Manifest.Api.Domain.Queries.v1
{
    public class GetAllManifestsQueryResponse
    {
        public IEnumerable<ManifestGetAllManifestsQueryResponse> Manifests { get; set; }
        public IEnumerable<FlightGetAllManifestsQueryResponse> Flights { get; set; }
    }

    public class ManifestGetAllManifestsQueryResponse
    {
        public FlightIdentifierGetAllManifestsQueryResponse FlightIdentifier { get; set; }
        public IEnumerable<PassengerGetAllManifestsQueryResponse> Passengers { get; set; }
    }

    public class PassengerGetAllManifestsQueryResponse
    {
        public PassengerNameGetAllManifestsQueryResponse Name { get; set; }
        public FidelityProgramGetAllManifestsQueryResponse FidelityProgram { get; set; }
        public IEnumerable<SegmentGetAllManifestsQueryResponse> Segments { get; set; }
    }

    public class PassengerNameGetAllManifestsQueryResponse
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public class FidelityProgramGetAllManifestsQueryResponse
    {
        public string LevelCode { get; set; }
        public int CustomerNumber { get; set; }
    }

    public class SegmentGetAllManifestsQueryResponse
    {
        public FlightIdentifierGetAllManifestsQueryResponse FlightIdentifier { get; set; }
        public LegGetAllManifestsQueryResponse Legs { get; set; }
    }

    public class LegGetAllManifestsQueryResponse
    {
        public FlightIdentifierGetAllManifestsQueryResponse FlightIdentifier { get; set; }
        public string LiftStatus { get; set; }
        public IEnumerable<SpecialStatusRequest> Ssrs { get; set; }
    }

    public class SpecialStatusRequest
    {
        public string Code { get; set; }
        public string Detail { get; set; }
    }

    public class FlightIdentifierGetAllManifestsQueryResponse
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public string Arrival { get; set; }
        public DateTime Std { get; set; }
        public DateTime Sta { get; set; }
    }

    public class FlightGetAllManifestsQueryResponse
    {
        public FlightIdGetAllManifestsQueryResponse Id { get; set; }
        public FlightTimesGetAllManifestsQueryResponse Times { get; set; }
    }

    public class FlightIdGetAllManifestsQueryResponse
    {
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string FlightNumber { get; set; }
        public DateTime StdLocal { get; set; }
    }

    public class FlightTimesGetAllManifestsQueryResponse
    {
        public DateTime Original { get; set; }
        public DateTime Actual { get; set; }
    }
}