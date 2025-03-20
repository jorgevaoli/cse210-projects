using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry newEntry)
        {
            // Stub: Add entry
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            // Stub: Display entry
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string file)
        {
            // Stub: Save entries
        }

        public void LoadFromFile(string file)
        {
            // Stub: Load entries
        }
    }
}
