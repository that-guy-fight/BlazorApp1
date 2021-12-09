namespace BlazorApp1.Shared
{
    public class SearchFilter
    {
        public SearchFilter(string searchText, bool sortDescending)
        {
            SearchText = searchText;
            SortDescending = sortDescending;
        }
        
        public string SearchText { get; set; }

        public bool SortDescending { get; set; }
    }
}
