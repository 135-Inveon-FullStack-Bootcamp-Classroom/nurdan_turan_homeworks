using System.ComponentModel.DataAnnotations.Schema;

namespace ImdbWebApi;

public class Imdb
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Rated { get; set; }
    public string ReleasedDate { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public string Writer { get; set; }
    public string Language { get; set; }
    public string Country { get; set; }
    public string imdbRating { get; set; }
    public string imdbVotes { get; set; }
    public string Type { get; set; }
    public string Actors { get; set; }
    public string imdbID { get; set; }
 
 
}