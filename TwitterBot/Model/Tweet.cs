using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwitterBot.Model
{

    [Table("TweetsInfo")]
    public class TweetsInfo
    {
        [Column("id")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("IdTwiter")]
        public long? IdTwiter { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("FullText")]
        [StringLength(250)]
        public string FullText { get; set; }

        [Column("UserId")]
        public long? UserId { get; set; }

        [Column("UserName")]
        public string UserName { get; set; }

        [Column("UserFollowersCount")]
        public long? UserFollowersCount { get; set; }

        [Column("url")]
        [StringLength(200)]
        public string url { get; set; }

    }

}
