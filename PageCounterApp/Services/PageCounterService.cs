using System.Collections.Generic;

namespace PageCounterApp.Services
{
	// Implement the IPageCounterService interface in the PageCounterService class
	public class PageCounterService : IPageCounterService
    {
		// Store page visit counts in memory using a dictionary
		private readonly Dictionary<string, int> _pageCounts = new Dictionary<string, int>();

		// Increment the count for the given page and return the updated count
		public int IncrementPageCount(string pageName)
        {
            if (!_pageCounts.ContainsKey(pageName))
                _pageCounts[pageName] = 0;

            _pageCounts[pageName]++;
            return _pageCounts[pageName];
        }
    }
}
    