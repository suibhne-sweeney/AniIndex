public class SeasonResponse
{
    public PaginationSeason? pagination;
    public DataSeason[]? data;

}

public class PaginationSeason
{
    public int last_visible_page;
    public bool has_next_page;
}


public class DataSeason
{
    public int year;
    public Seasons[]? seasons;

}

public class Seasons
{
    public string? winter;
    public string? spring;
    public string? summer;
    public string? fall;
}