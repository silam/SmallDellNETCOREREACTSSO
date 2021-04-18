// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WelcomeScreenMeetingInformation.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WelcomeScreenMeetingInformation
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Show Organizer And Time Only
        /// </summary>
        ShowOrganizerAndTimeOnly = 1,
	
        /// <summary>
        /// Show Organizer And Time And Subject
        /// </summary>
        ShowOrganizerAndTimeAndSubject = 2,
	
    }
}