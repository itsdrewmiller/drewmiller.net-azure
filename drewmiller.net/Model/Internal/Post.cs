namespace Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    internal partial class Post
    {
        public int Id { get; set; }

        [Required]
        public string HtmlText { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        public DateTimeOffset DatePosted { get; set; }
    }
}
