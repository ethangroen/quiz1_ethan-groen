namespace PageCounterApp.Services
{
	// Define an interface for the PageCounter service with a method to increment and retrieve page counts
	public interface IPageCounterService
    {
        int IncrementPageCount(string pageName);
    }
}
