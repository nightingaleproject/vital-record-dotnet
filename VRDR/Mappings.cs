// This file was generated by the script at ...

using System;
using System.Collections.Generic;

namespace VRDR
{
    /// <summary>Mappings between IJE and FHIR value sets</summary>
    public static class Mappings
    {
        /// <summary>Mappings for EducationLevel</summary>
        public static class EducationLevel
        {
            /// <summary>IJE -> FHIR Mapping for EducationLevel</summary>
            public readonly static Dictionary<string, string> IJEToFHIR = new Dictionary<string, string>
            {
                { "1", "ELEM"},
                { "2", "SEC"},
                { "3", "HS"},
                { "4", "SCOL"},
                { "5", "AA"},
                { "6", "BA"},
                { "7", "MA"},
                { "8", "POSTG"},
                { "9", "UNK"},
            };
            /// <summary>FHIR -> IJE Mapping for EducationLevel</summary>
            public readonly static Dictionary<string, string> FHIRToIJE = new Dictionary<string, string>
            {
                { "ELEM", "1"},
                { "SEC", "2"},
                { "HS", "3"},
                { "SCOL", "4"},
                { "AA", "5"},
                { "BA", "6"},
                { "MA", "7"},
                { "POSTG", "8"},
                { "UNK", "9"},
            };
        }
    }
}
