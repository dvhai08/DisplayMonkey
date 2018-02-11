/*!
* DisplayMonkey source file
* http://displaymonkey.org
*
* Copyright (c) 2018 Fuel9 LLC and contributors
*
* Released under the MIT license:
* http://opensource.org/licenses/MIT
*/

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisplayMonkey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clock : Frame
    {
        public ClockTypes Type { get; set; }
        public bool ShowDate { get; set; }
        public bool ShowTime { get; set; }
        public string Label { get; set; }
        public string TimeZone { get; set; }
        public bool ShowSeconds { get; set; }
    }
}
