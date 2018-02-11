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
    
    public partial class Display
    {
        public int DisplayId { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public int CanvasId { get; set; }
        public int LocationId { get; set; }
        public byte[] Version { get; set; }
        public bool NoScroll { get; set; }
        public int ReadyTimeout { get; set; }
        public int PollInterval { get; set; }
        public int ErrorLength { get; set; }
        public bool NoCursor { get; set; }
        public Nullable<System.TimeSpan> RecycleTime { get; set; }
    
        public virtual Canvas Canvas { get; set; }
        public virtual Location Location { get; set; }
    }
}
