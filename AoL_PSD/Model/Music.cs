//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AoL_PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Music
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Music()
        {
            this.Playlists = new HashSet<Playlist>();
        }
    
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string FileLocation { get; set; }
    
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Playlist> Playlists { get; set; }
        public virtual User User { get; set; }
    }
}